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
        public static async Task Main(
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
                bool alreadyProcessed = streamVideoTables.CreateQuery<VideoRow>()
                    .Where(x => x.TwitchVideoId == video.Id && x.YoutubeVideoId == null)
                    .FirstOrDefault() != null;
                if (alreadyProcessed) continue;
                                
                string downloadedFilePath = await twitchClinet.DownloadVideoFileAsync(video.Id);

                string trimmedFilePath = await Ffmpeg.TrimLeadingSilence(downloadedFilePath);
                File.Delete(downloadedFilePath);

                string youTubeId = await UploadVideoAsync(trimmedFilePath, video, youtubeSettingsTable, youTubeClientId, youTubeClientSecret);

                var videoRow = new VideoRow
                {
                    PartitionKey = nameof(VideoConverter),
                    TwitchVideoId = video.Id,
                    YoutubeVideoId = youTubeId
                };
                TableOperation insertOperation = TableOperation.InsertOrReplace(videoRow);

                // Execute the operation.
                TableResult _ = await streamVideoTables.ExecuteAsync(insertOperation);

                break;
            }
        }

        private static async Task<string> UploadVideoAsync(string videoPath, TwitchVideo video, CloudTable youtubeSettingsTable,
            string youTubeClientId, string youTubeClientSecret)
        {
            var service = await YouTubeFactory.GetServiceAsync(
                new CloudTableDataStore(youtubeSettingsTable, nameof(VideoConverter)), 
                youTubeClientId,
                youTubeClientSecret,
                YouTubeService.Scope.Youtube, YouTubeService.Scope.YoutubeUpload);
            
            var videoUpload = new YouTubeVideo
            {
                Snippet = new VideoSnippet
                {
                    Title = video.Title,
                    Description = video.Description,
                    //Tags = new string[] { "tag1", "tag2" },
                    CategoryId = "28", // See https://developers.google.com/youtube/v3/docs/videoCategories/list
                },
                Status = new VideoStatus
                {
                    PrivacyStatus = "unlisted" // or "private" or "public"
                }
            };

            using var fileStream = new FileStream(videoPath, FileMode.Open);
            var videosInsertRequest = service.Videos.Insert(videoUpload, "snippet,status", fileStream, "video/*");
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
                        Console.WriteLine("{0} bytes sent.", progress.BytesSent);
                        break;

                    case UploadStatus.Failed:
                        Console.WriteLine("An error prevented the upload from completing.\n{0}", progress.Exception);
                        break;
                }
            }

            void ResponseReceived(YouTubeVideo video)
            {
                videoId = video.Id;
                Console.WriteLine("Video id '{0}' was successfully uploaded.", video.Id);
            }
        }
    }
}
