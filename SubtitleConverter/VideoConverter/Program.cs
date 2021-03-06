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
            string? youTubeUsername = null,
            string? youTubePassword = null,
            string? youTubeRecoveryEmail = null)
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

            console.Out.WriteLine("Retrieving videos from twitch");
            var videoResponse = await api.Helix.Videos.GetVideoAsync(userId: twitchUserId);

            foreach (TwitchVideo video in videoResponse.Videos)
            {
                // Check if video exists in storage
                VideoRow? row = streamVideoTables.CreateQuery<VideoRow>()
                    .Where(x => x.TwitchVideoId == video.Id)
                    .FirstOrDefault();
                if (!string.IsNullOrWhiteSpace(row?.YouTubeVideoId))
                {
                    console.Out.WriteLine($"Twitch video {video.Id} already has YouTube id '{row.YouTubeVideoId}'; skipping");
                    continue;
                }
                console.Out.WriteLine($"Downloading '{video.Title}' from {video.CreatedAt} - {video.Id} ");
                
                FileInfo? downloadedFilePath = await twitchClinet.DownloadVideoFileAsync(video.Id);
                if (downloadedFilePath is null)
                {
                    console.Out.WriteLine($"Failed to download video file");
                    return 1;
                }
                console.Out.WriteLine($"Downloaded video to '{downloadedFilePath}'");

                FileInfo? trimmedFilePath = await Ffmpeg.TrimLeadingSilence(downloadedFilePath);
                if (trimmedFilePath is null)
                {
                    console.Error.WriteLine($"Failed to trim silence from '{downloadedFilePath}'");
                    return 1;
                }
                console.Out.WriteLine($"Trimmed silence '{trimmedFilePath}'");

                var youtubeSection = config.GetSection("YouTube");
                BrowserCredential creds = new(
                    youTubeUsername ?? youtubeSection["Username"],
                    youTubePassword ?? youtubeSection["Password"],
                    youTubeRecoveryEmail ?? youtubeSection["RecoveryEmail"]);
                string youTubeId = await UploadVideoAsync(creds, trimmedFilePath, video);
                await DeleteFile(trimmedFilePath);

                if (string.IsNullOrWhiteSpace(youTubeId))
                {
                    console.Error.WriteLine($"Failed to upload '{trimmedFilePath}'");
                    return 1;
                }
                console.Out.WriteLine($"Uploaded to YouTube '{youTubeId}'");


                DateTime recordingDate = video.GetRecordingDate() ?? DateTime.UtcNow.Date;
                if (row is null)
                {
                    row = new VideoRow
                    {
                        PartitionKey = recordingDate.Year.ToString(),
                    };
                }

                row.TwitchVideoId = video.Id;
                row.TwitchPublishedAt = recordingDate;
                row.YouTubeVideoId = youTubeId;
                TableOperation insertOperation = TableOperation.InsertOrMerge(row);

                // Execute the operation.
                TableResult _ = await streamVideoTables.ExecuteAsync(insertOperation);

                break;
            }
            return 0;
        }

        private static async Task<string> UploadVideoAsync(
            BrowserCredential credential,
            FileInfo videoFile,
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
                tags.Add("devops");
                playlists.Add("Terraform");
                playlists.Add("DevOps");
                playlists.Add("Azure");
            }
            if (video.Title.Contains("DevOps"))
            {
                tags.Add("devops");
                playlists.Add("DevOps");
            }
            if (video.Title.Contains("GitHub"))
            {
                tags.Add("github");
            }
            if (video.Title.Contains("Azure"))
            {
                tags.Add("azure");
            }
            if (video.Title.Contains("WinUI"))
            {
                tags.Add("winui");
            }

            description += Environment.NewLine + Environment.NewLine + $"Broadcasted live on Twitch -- Watch live at https://twitch.keboo.dev";

            DateTime recordingDate = video.GetRecordingDate() ?? DateTime.UtcNow.Date;

            YouTubeBrowser browser = new(credential.Username, credential.Password, credential.RecoveryEmail);
            return await browser.UploadAsync(videoFile, video.Title, description, recordingDate, playlists, tags);
        }

        private static async Task DeleteFile(FileInfo file)
        {
            Exception? lastException = null;
            for (int i = 0; i < 30; i++)
            {
                try
                {
                    file.Delete();
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
