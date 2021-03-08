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

            var storageAccount = StorageAccount.Get(azureStorageAccountKey, config);
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
                VideoRow? row = streamVideoTables.CreateQuery<VideoRow>()
                    .Where(x => x.PartitionKey == nameof(VideoConverter) && x.TwitchVideoId == video.Id)
                    .FirstOrDefault();
                if (!string.IsNullOrWhiteSpace(row?.YouTubeVideoId))
                {
                    console.Out.WriteLine($"Twitch video {video.Id} already has YouTube id '{row.YouTubeVideoId}'; skipping");
                    continue;
                }
                console.Out.WriteLine($"Processing Twitch video {video.Id}");

                string downloadedFilePath = @"C:\Users\kitok\AppData\Local\Temp\tmpA6A.mp4";
                //string downloadedFilePath = await twitchClinet.DownloadVideoFileAsync(video.Id);
                console.Out.WriteLine($"Downloaded video to '{downloadedFilePath}'");

                string trimmedFilePath = await Ffmpeg.TrimLeadingSilence(downloadedFilePath);
                await DeleteFile(downloadedFilePath);
                if (string.IsNullOrWhiteSpace(trimmedFilePath))
                {
                    console.Error.WriteLine($"Failed to trim silence from '{downloadedFilePath}'");
                    return 1;
                }
                console.Out.WriteLine($"Trimmed silence '{trimmedFilePath}'");

                string youTubeId = await UploadVideoAsync(config, trimmedFilePath, video);
                await DeleteFile(trimmedFilePath);
                if (string.IsNullOrWhiteSpace(youTubeId))
                {
                    console.Error.WriteLine($"Failed to upload '{trimmedFilePath}'");
                    return 1;
                }
                console.Out.WriteLine($"Uploaded to YouTube '{youTubeId}'");

                row!.TwitchVideoId = video.Id;
                row.TwitchPublishedAt = DateTime.Parse(video.PublishedAt ?? video.CreatedAt);
                row.YouTubeVideoId = youTubeId;
                TableOperation insertOperation = TableOperation.InsertOrMerge(row);

                // Execute the operation.
                TableResult _ = await streamVideoTables.ExecuteAsync(insertOperation);

                break;
            }
            return 0;
        }

        private static async Task<string> UploadVideoAsync(
            IConfiguration config,
            string videoPath,
            TwitchVideo video)
        {
            string description = video.Description;

            HashSet<string> playlists = new()
            {
                "C# Programming"
            };
            HashSet<string> tags = new()
            {
                "programming"
            };
            if (video.Title.Contains("C#"))
            {
                tags.Add("C#");
            }
            if (video.Title.Contains("WPF"))
            {
                tags.Add("C#");
                tags.Add("WPF");
            }
            if (video.Title.Contains("XAML"))
            {
                tags.Add("XAML");
            }
            if (video.Title.Contains("Material Design"))
            {
                description += Environment.NewLine + Environment.NewLine + "Material Design In XAML Project: https://github.com/MaterialDesignInXAML/MaterialDesignInXamlToolkit";
                tags.Add("material design");
                playlists.Add("Material Design in Xaml");
            }
            if (video.Title.Contains("System.CommandLine"))
            {
                tags.Add("C#");
                tags.Add("command line");
                tags.Add("System.CommandLine");
                playlists.Add("System.CommandLine");
                description += Environment.NewLine + Environment.NewLine + "System.CommandLine: https://github.com/dotnet/command-line-api";
            }
            if (video.Title.Contains("terraform"))
            {
                tags.Add("terraform");
                tags.Add("azure");
                playlists.Add("Terraform");
                playlists.Add("DevOps");
                playlists.Add("Azure");
            }

            description += Environment.NewLine + Environment.NewLine + $"Broadcasted live on Twitch -- Watch live at https://twitch.keboo.dev";

            var youtubeSection = config.GetSection("YouTube");

            YouTubeBrowser browser = new(youtubeSection["Username"], youtubeSection["Password"], youtubeSection["RecoveryEmail"]);
            await browser.UploadAsync(videoPath, video.Title, description, playlists, tags);
            return "";
        }

        private static async Task DeleteFile(string file)
        {
            Exception? lastException = null;
            for (int i = 0; i < 30; i++)
            {
                try
                {
                    File.Delete(file);
                    return;
                }
                catch (Exception e)
                {
                    lastException = e;
                    await Task.Delay(TimeSpan.FromSeconds(1));
                }
            }
            throw lastException!;
        }
    }
}
