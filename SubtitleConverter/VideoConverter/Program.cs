using Microsoft.Azure.Cosmos.Table;
using Microsoft.Extensions.Configuration;
using StreamingTools;
using StreamingTools.Azure;
using StreamingTools.Twitch;
using StreamingTools.YouTube;
using System.CommandLine;
using TwitchLib.Api;
using TwitchLib.Api.Core;
using TwitchVideo = TwitchLib.Api.Helix.Models.Videos.GetVideos.Video;

namespace VideoConverter;

class Program
{
    static Task<int> Main(string[] args)
    {
        CliOption<string> twitchUserId = Option("--twitch-user-id");
        CliOption<string> twitchClientId = Option("--twitch-client-id");
        CliOption<string> twitchClientSecret = Option("--twitch-client-secret");
        CliOption<string?> twitchVideoId = new("--twitch-video-id")
        {
            Arity = ArgumentArity.ZeroOrOne
        };
        CliOption<string> storageAccountKey = Option("--azure-storage-account-key");
        CliOption<string> youTubeUsername = Option("--you-tube-username");
        CliOption<string> youTubePassword = Option("--you-tube-password");
        CliOption<string> youTubeRecoveryEmail = Option("--you-tube-recovery-email");
        CliOption<string> youTubeTwoFactorCallbackUrl = Option("--you-tube-two-factor-callback-url");

        CliRootCommand rootCommand = new()
        {
            twitchUserId,
            twitchClientId,
            twitchClientSecret,
            twitchVideoId,
            storageAccountKey,
            youTubeUsername,
            youTubePassword,
            youTubeRecoveryEmail,
            youTubeTwoFactorCallbackUrl
        };
        rootCommand.SetAction(async (ctx, ct) =>
        {
            await MainInvoke(
                    ctx.Configuration.Output,
                    ctx.GetValue(twitchUserId),
                    ctx.GetValue(twitchClientId),
                    ctx.GetValue(twitchClientSecret),
                    ctx.GetValue(twitchVideoId),
                    ctx.GetValue(storageAccountKey),
                    ctx.GetValue(youTubeUsername),
                    ctx.GetValue(youTubePassword),
                    ctx.GetValue(youTubeRecoveryEmail),
                    ctx.GetValue(youTubeTwoFactorCallbackUrl)
            );
        });
        return new CliConfiguration(rootCommand).InvokeAsync(args);

        static CliOption<string> Option(string alias)
            => new(alias)
            {
                Arity = ArgumentArity.ZeroOrOne
            };
    }

    public static async Task<int> MainInvoke(
        TextWriter console,
        string? twitchUserId,
        string? twitchClientId,
        string? twitchClientSecret,
        string? twitchVideoId,
        string? azureStorageAccountKey,
        string? youTubeUsername,
        string? youTubePassword,
        string? youTubeRecoveryEmail,
        string? youTubeTwoFactorCallbackUrl)
    {
        var configBuilder = new ConfigurationBuilder();
        configBuilder.AddEnvironmentVariables();
        configBuilder.AddUserSecrets(typeof(Program).Assembly);

        var config = configBuilder.Build();
        var section = config.GetSection(nameof(VideoConverter));

        twitchUserId ??= section["TwitchUserId"] ?? throw new InvalidOperationException("No Twitch user id specified");
        twitchClientId ??= section["TwitchClientId"] ?? throw new InvalidOperationException("No Twitch client id specified");
        twitchClientSecret ??= section["TwitchClientSecret"] ?? throw new InvalidOperationException("No Twitch client secret specified");
        azureStorageAccountKey ??= section["AzureStorageAccountKey"] ?? throw new InvalidOperationException("No Azure Storage Account key");

        var storageAccount = StorageAccount.Get(azureStorageAccountKey, config);
        var tableClient = storageAccount.CreateCloudTableClient();
        var streamVideoTables = tableClient.GetTableReference("streamvideos");
        var youTubeSettingsTable = tableClient.GetTableReference("youtubesettings");

        TwitchAPI api = new(settings: new ApiSettings()
        {
            ClientId = twitchClientId,
            Secret = twitchClientSecret,
        });

        var httpClient = new HttpClient();
        var twitchClient = new Twitch(httpClient);

        console.WriteLine("Retrieving videos from twitch");
        var videoResponse = await api.Helix.Videos.GetVideosAsync(userId: twitchUserId);

        foreach (TwitchVideo video in videoResponse.Videos)
        {
            // Check if video exists in storage
            VideoRow? row = streamVideoTables.CreateQuery<VideoRow>()
                .Where(x => x.TwitchVideoId == video.Id)
                .FirstOrDefault();
            if (string.IsNullOrEmpty(twitchVideoId))
            {
                if (!string.IsNullOrWhiteSpace(row?.YouTubeVideoId))
                {
                    console.WriteLine($"Twitch video {video.Id} already has YouTube id '{row.YouTubeVideoId}'; skipping");
                    continue;
                }
            }
            else if (video.Id != twitchVideoId)
            {
                console.WriteLine($"Twitch video {video.Id} does not match target id of '{twitchVideoId}'; skipping");
                continue;
            }
            console.WriteLine($"Downloading '{video.Title}' from {video.CreatedAt} - {video.Id} ");

            FileInfo? downloadedFilePath = await twitchClient.DownloadVideoFileAsync(video.Id);
            if (downloadedFilePath is null)
            {
                console.WriteLine($"Failed to download video file");
                return 1;
            }
            console.WriteLine($"Downloaded video to '{downloadedFilePath}'");

            FileInfo? trimmedFilePath = await Ffmpeg.TrimSilence(downloadedFilePath, log: x => console.WriteLine(x));
            if (trimmedFilePath is null)
            {
                console.WriteLine($"Failed to trim silence from '{downloadedFilePath}'");
                return 1;
            }
            console.WriteLine($"Trimmed silence '{trimmedFilePath}'");

            var youTubeSection = config.GetSection("YouTube");
            BrowserCredential creds = new(
                youTubeUsername ?? youTubeSection["Username"] ?? "",
                youTubePassword ?? youTubeSection["Password"] ?? "",
                youTubeRecoveryEmail ?? youTubeSection["RecoveryEmail"] ?? "",
                youTubeTwoFactorCallbackUrl ?? youTubeSection["TwoFactorCallbackUrl"] ?? "");
            string youTubeId = await UploadVideoAsync(creds, trimmedFilePath, video, httpClient);
            await DeleteFile(trimmedFilePath);

            if (string.IsNullOrWhiteSpace(youTubeId))
            {
                console.WriteLine($"Failed to upload '{trimmedFilePath}'");
                return 1;
            }
            console.WriteLine($"Uploaded to YouTube '{youTubeId}'");


            DateTime recordingDate = video.GetRecordingDate() ?? DateTime.UtcNow.Date;
            row ??= new VideoRow
            {
                PartitionKey = recordingDate.Year.ToString(),
            };

            row.TwitchVideoId = video.Id;
            row.TwitchPublishedAt = recordingDate;
            row.YouTubeVideoId = youTubeId;
            TableOperation insertOperation = TableOperation.InsertOrMerge(row);

            // Execute the operation.
            _ = await streamVideoTables.ExecuteAsync(insertOperation);

            break;
        }
        return 0;
    }

    private static async Task<string> UploadVideoAsync(
        BrowserCredential credential,
        FileInfo videoFile,
        TwitchVideo video,
        HttpClient httpClient)
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
            tags.Add("WPF");
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
        if (video.Title.Contains("GitHub Actions"))
        {
            tags.Add("github actions");
        }
        if (video.Title.Contains("K8s") || video.Title.Contains("Kubernetes"))
        {
            tags.Add("kubernetes");
        }
        if (video.Title.Contains("helm"))
        {
            tags.Add("helm");
            tags.Add("kubernetes");
        }
        if (video.Title.Contains("Azure"))
        {
            tags.Add("azure");
        }
        if (video.Title.Contains("WinUI"))
        {
            tags.Add("winui");
        }
        if (video.Title.Contains("Velopack"))
        {
            tags.Add("velopack");
            tags.Add("installer");
        }

        description += Environment.NewLine + Environment.NewLine + $"Broadcasted live on Twitch -- Watch live at https://twitch.keboo.dev";

        DateTime recordingDate = video.GetRecordingDate() ?? DateTime.UtcNow.Date;

        YouTubeBrowser browser = new(credential.Username, credential.Password, credential.RecoveryEmail, credential.TwoFactorCallbackUrl, httpClient);
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
