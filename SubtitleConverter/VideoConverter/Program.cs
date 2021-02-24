using Google.Apis.Upload;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using Microsoft.Azure.Cosmos.Table;
using Microsoft.Extensions.Configuration;
using StreamingTools;
using StreamingTools.Azure;
using StreamingTools.Twitch;
using StreamingTools.YouTube;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.CommandLine.IO;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TwitchLib.Api;
using TwitchLib.Api.Core;
using TwitchVideo = TwitchLib.Api.Helix.Models.Videos.GetVideos.Video;
using YouTubeVideo = Google.Apis.YouTube.v3.Data.Video;

namespace VideoConverter
{
    class Program
    {
        public static async Task<int> Main(
            IConsole console,
            string? twitchUserId = null,
            string? twitchClientId = null,
            string? twitchClientSecret = null,
            string? azureStorageAccountKey = null,
            string? youTubeClientId = null,
            string? youTubeClientSecret = null)
        {
            var configBuilder = new ConfigurationBuilder();
            configBuilder.AddEnvironmentVariables();
            configBuilder.AddUserSecrets(typeof(Program).Assembly);
            var config = configBuilder.Build();
            var section = config.GetSection(nameof(VideoConverter));

            twitchUserId ??= section["TwitchUserId"] ?? throw new InvalidOperationException("No Twitch user id specified");
            twitchClientId ??= section["TwitchClientId"] ?? throw new InvalidOperationException("No Twitch client id specified");
            twitchClientSecret ??= section["TwitchClientSecret"] ?? throw new InvalidOperationException("No Twitch client secret specified");
            azureStorageAccountKey ??= section["AzureStorageAccountKey"] ?? throw new InvalidOperationException("No Azure storage account key specified");
            youTubeClientId ??= section["YouTubeClientId"] ?? throw new InvalidOperationException("No YouTube client id specified");
            youTubeClientSecret ??= section["YouTubeClientSecret"] ?? throw new InvalidOperationException("No YouTube client secret specified");

            var storageAccount = CloudStorageAccount.Parse($"DefaultEndpointsProtocol=https;AccountName=streamautomation;AccountKey={azureStorageAccountKey};EndpointSuffix=core.windows.net");
            var tableClient = storageAccount.CreateCloudTableClient();
            var streamVideoTables = tableClient.GetTableReference("streamvideos");
            var youtubeSettingsTable = tableClient.GetTableReference("youtubesettings");

            TwitchAPI api = new(settings: new ApiSettings()
            {
                ClientId = twitchClientId,
                Secret = twitchClientSecret
            });

            var httpClient = new HttpClient();
            var twitchClinet = new Twitch(httpClient);

            //return;
            var videoResponse = await api.Helix.Videos.GetVideoAsync(userId: twitchUserId);

            foreach (TwitchVideo video in videoResponse.Videos)
            {
                // Check if video exists in storage
                var row = streamVideoTables.CreateQuery<VideoRow>()
                    .Where(x => x.PartitionKey == nameof(VideoConverter) && x.TwitchVideoId == video.Id)
                    .Select(x => new VideoRow() { PartitionKey = x.PartitionKey, RowKey = x.RowKey, TwitchVideoId = x.TwitchVideoId, YouTubeVideoId = x.YouTubeVideoId })
                    .FirstOrDefault();
                if (!string.IsNullOrWhiteSpace(row?.YouTubeVideoId))
                {
                    console.Out.WriteLine($"Twitch video {video.Id} already has YouTube id '{row.YouTubeVideoId}'; skipping");
                    continue;
                }
                console.Out.WriteLine($"Processing Twitch video {video.Id}");

                string downloadedFilePath = await twitchClinet.DownloadVideoFileAsync(video.Id);
                console.Out.WriteLine($"Downloaded video to '{downloadedFilePath}'");

                string trimmedFilePath = await Ffmpeg.TrimLeadingSilence(downloadedFilePath);
                if (string.IsNullOrWhiteSpace(trimmedFilePath))
                {
                    console.Error.WriteLine($"Failed to trim silence from '{downloadedFilePath}'");
                    return 1;
                }
                console.Out.WriteLine($"Trimmed silence '{trimmedFilePath}'");
                File.Delete(downloadedFilePath);

                string youTubeId = await UploadVideoAsync(trimmedFilePath, video, youtubeSettingsTable, youTubeClientId, youTubeClientSecret, console);
                if (string.IsNullOrWhiteSpace(youTubeId))
                {
                    console.Error.WriteLine($"Failed to upload '{trimmedFilePath}'");
                    return 1;
                }
                console.Out.WriteLine($"Uploaded to YouTube '{youTubeId}'");

                var videoRow = new VideoRow
                {
                    PartitionKey = nameof(VideoConverter),
                    TwitchVideoId = video.Id,
                    TwitchPublishedAt = DateTime.Parse(video.PublishedAt ?? video.CreatedAt),
                    YouTubeVideoId = youTubeId
                };
                TableOperation insertOperation = TableOperation.InsertOrReplace(videoRow);

                // Execute the operation.
                TableResult _ = await streamVideoTables.ExecuteAsync(insertOperation);

                break;
            }
            return 0;
        }

        private static async Task<string> UploadVideoAsync(string videoPath, TwitchVideo video, CloudTable youtubeSettingsTable,
            string youTubeClientId, string youTubeClientSecret, IConsole console)
        {
            var service = await YouTubeFactory.GetServiceAsync(
                new CloudTableDataStore(youtubeSettingsTable, nameof(VideoConverter)),
                youTubeClientId,
                youTubeClientSecret,
                YouTubeService.Scope.Youtube, YouTubeService.Scope.YoutubeUpload);

            string description = video.Description;


            List<string> tags = new()
            {
                "programming"
            };
            if (video.Title.Contains("C#"))
            {
                tags.Add("C#");
            }
            if (video.Title.Contains("WPF"))
            {
                tags.Add("WPF");
            }
            if (video.Title.Contains("XAML"))
            {
                tags.Add("XAML");
            }
            if (video.Title.Contains("Material Design"))
            {
                description += Environment.NewLine + "MaterialDesignInXAML Project: https://github.com/MaterialDesignInXAML/MaterialDesignInXamlToolkit";
                tags.Add("material design");
            }

            description += Environment.NewLine + Environment.NewLine + $"Broadcasted live on Twitch -- Watch live at https://www.twitch.tv/kitokeboo";

            var videoUpload = new YouTubeVideo
            {
                Snippet = new VideoSnippet
                {
                    Title = video.Title,
                    Description = description,
                    Tags = tags.ToArray(),
                    DefaultLanguage = "English",
                    //TODO: Should probably query this rather than hard coded....
                    CategoryId = "28", // See https://developers.google.com/youtube/v3/docs/videoCategories/list,
                },
                Status = new VideoStatus
                {
                    PrivacyStatus = "private", // or "unlisted" "private" or "public"
                    //TODO: Just testing out the future publish setting, may not want to set this here.
                    //PublishAt = DateTime.UtcNow + TimeSpan.FromDays(15),
                },
                RecordingDetails = new()
                {
                    LocationDescription = "Spokane",
                    Location = new()
                    {
                        Latitude = 47.6587802,
                        Longitude = -117.4260465,
                        Altitude = 0
                    },
                    RecordingDate = DateTime.Parse(video.PublishedAt ?? video.CreatedAt),
                }
            };

            using var fileStream = new FileStream(videoPath, FileMode.Open);
            //Parts https://developers.google.com/youtube/v3/getting-started#part
            var videosInsertRequest = service.Videos.Insert(videoUpload, "snippet,status,recordingDetails", fileStream, "video/*");
            videosInsertRequest.ProgressChanged += ProgressChanged;
            videosInsertRequest.ResponseReceived += ResponseReceived;

            string videoId = "";
            await videosInsertRequest.UploadAsync();
            return videoId;

            void ProgressChanged(IUploadProgress progress)
            {
                switch (progress.Status)
                {
                    case UploadStatus.Uploading:
                        //Console.WriteLine("{0} bytes sent.", progress.BytesSent);
                        break;

                    case UploadStatus.Failed:
                        console.Out.WriteLine($"An error prevented the upload from completing.\n{progress.Exception}");
                        break;
                }
            }

            void ResponseReceived(YouTubeVideo video)
            {
                videoId = video.Id;
                console.Out.WriteLine($"Video id '{video.Id}' was successfully uploaded.");
            }
        }
    }
}
