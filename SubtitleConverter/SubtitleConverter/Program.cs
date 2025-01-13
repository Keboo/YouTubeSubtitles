using Google.Apis.YouTube.v3;
using Microsoft.Azure.Cosmos.Table;
using Microsoft.Extensions.Configuration;
using StreamingTools.Azure;
using StreamingTools.Subtitle;
using StreamingTools.YouTube;
using System.CommandLine;

namespace SubtitleConverter;

class Program
{
    static Task Main(string[] args)
    {
        CliOption<string> outputDirectory = new("--output-directory")
        {
            DefaultValueFactory = _ => ".",
        };
        CliOption<string> storageAccountKey = new("--azure-storage-account-key")
        {
            Required = true,
            Arity = ArgumentArity.ExactlyOne
        };
        CliOption<string?> youTubeClientId = new("--you-tube-client-id")
        {
            Required = true,
            Arity = ArgumentArity.ExactlyOne
        };
        CliOption<string?> youTubeClientSecret = new("--you-tube-client-secret")
        {
            Required = true,
            Arity = ArgumentArity.ExactlyOne
        };
        CliOption<string?> youTubeVideoId = new("--you-tube-video-id")
        {
            Arity = ArgumentArity.ZeroOrOne
        };

        CliRootCommand rootCommand = new()
        {
            outputDirectory,
            storageAccountKey,
            youTubeClientId,
            youTubeClientSecret,
            youTubeVideoId
        };
        rootCommand.SetAction((ctx, ct) => MainInvoke(
            ctx.GetValue(outputDirectory)!,
            ctx.GetValue(storageAccountKey)!,
            ctx.GetValue(youTubeClientId)!,
            ctx.GetValue(youTubeClientSecret)!,
            ctx.GetValue(youTubeVideoId),
            ctx.Configuration.Output
        ));
        return new CliConfiguration(rootCommand).InvokeAsync(args);
    }

    /// <summary>
    /// Convert subtitles to markdown
    /// </summary>
    /// <param name="outputDirectory">The directory where markdown files should be created.</param>
    /// <param name="azureStorageAccountKey"></param>
    /// <param name="youTubeClientId"></param>
    /// <param name="youTubeClientSecret"></param>
    /// <param name="youTubeVideoId"></param>
    /// <param name="console"></param>
    /// <returns></returns>
    static async Task MainInvoke(
        string outputDirectory,
        string azureStorageAccountKey,
        string youTubeClientId,
        string youTubeClientSecret,
        string? youTubeVideoId,
        TextWriter console)
    {
        var configBuilder = new ConfigurationBuilder();
        configBuilder.AddEnvironmentVariables();
        configBuilder.AddUserSecrets(typeof(Program).Assembly);
        var config = configBuilder.Build();

        CloudStorageAccount storageAccount = StorageAccount.Get(azureStorageAccountKey, config);
        var tableClient = storageAccount.CreateCloudTableClient();
        var streamVideoTable = tableClient.GetTableReference("streamvideos");
        var youtubeSettingsTable = tableClient.GetTableReference("youtubesettings");

        YouTubeService youTubeService = await YouTubeFactory.GetServiceAsync(
            new CloudTableDataStore(youtubeSettingsTable),
            config,
            youTubeClientId,
            youTubeClientSecret,
            YouTubeService.Scope.YoutubeForceSsl);

        CancellationToken token = CancellationToken.None;
        if (string.IsNullOrWhiteSpace(youTubeVideoId))
        {
            foreach (VideoRow row in streamVideoTable.CreateQuery<VideoRow>()
                        .Where(x => x.YouTubeVideoId != "" && x.YouTubeVideoId != "Unknown"))
            {
                if (!string.IsNullOrWhiteSpace(row.SubtitlesUrl)) continue;
                console.WriteLine($"Converting markdown for YouTube video '{row.YouTubeVideoId}'");

                await ProcessRow(youTubeService, row, outputDirectory, streamVideoTable, console, token);
            }
        }
        else
        {
            VideoRow? row = streamVideoTable.CreateQuery<VideoRow>()
                        .Where(x => x.YouTubeVideoId == youTubeVideoId)
                        .FirstOrDefault();
            if (row is null)
            {
                console.WriteLine($"Failed to find video with id {youTubeVideoId}");
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(row.SubtitlesUrl))
                {
                    console.WriteLine($"Overwriting existing subtitle file {row.SubtitlesUrl}");
                }

                console.WriteLine($"Converting markdown for YouTube video '{row.YouTubeVideoId}'");
                await ProcessRow(youTubeService, row, outputDirectory, streamVideoTable, console, token);
            }
        }
    }

    private static async Task ProcessRow(
        YouTubeService youTubeService, 
        VideoRow row, 
        string outputDirectory,
        CloudTable streamVideoTable,
        TextWriter console,
        CancellationToken token)
    {
        if (await youTubeService.GetSrtSubtitles(row.YouTubeVideoId!, token) is { } subtitles)
        {
            if (!string.IsNullOrWhiteSpace(subtitles))
            {
                console.WriteLine("  Got subtitles");
                string markdown = Subtitles.ConvertSrtToMarkdown(row.YouTubeVideoId!, subtitles);
                string fileName = await WriteToFile(outputDirectory, markdown, row.YouTubeVideoId!, row.TwitchPublishedAt);
                console.WriteLine($"  Wrote markdown to '{fileName}'");

                row.SubtitlesUrl = (await Subtitles.GetMarkdownUrl(row, token))?.AbsoluteUri;

                if (row.SubtitlesUrl is { } subtitlesUrl)
                {
                    string snippet = "snippet";
                    var videoQuery = youTubeService.Videos.List(snippet);
                    videoQuery.Id = row.YouTubeVideoId;
                    var videoResponse = await videoQuery.ExecuteAsync(token);
                    if (videoResponse.Items is { Count: > 0 } videos &&
                        videos[0] is { } video &&
                        video.Snippet?.Description is { } description &&
                        description.Contains(subtitlesUrl) != true)
                    {
                        console.WriteLine($"Updating video {video.Id} description");
                        description +=
                            Environment.NewLine +
                            Environment.NewLine +
                            $"Search video contents here: {subtitlesUrl}";

                        video.Snippet.Description = description;
                        await youTubeService.Videos.Update(video, snippet).ExecuteAsync(token);
                    }
                }
            }
            else
            {
                console.WriteLine($"  YouTube video '{row.YouTubeVideoId}' not found");

                row.SubtitlesUrl = "YouTube Video Removed";
            }
            TableOperation insertOperation = TableOperation.Merge(row);
            TableResult _ = await streamVideoTable.ExecuteAsync(insertOperation, token);
            console.WriteLine($"  Updated table storage url with '{row.SubtitlesUrl}'");
        }
    }

    private static async Task<string> WriteToFile(string outputDirectory, string markdownContent, string videoId, DateTime date)
    {
        string fileName = Subtitles.GetMarkdownFileName(videoId, date);
        var path = Path.Combine(Path.GetFullPath(outputDirectory), fileName);

        await File.WriteAllTextAsync(path, markdownContent);

        return fileName;
    }
}
