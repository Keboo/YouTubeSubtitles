using Azure.Core;
using Google.Apis.YouTube.v3;
using Microsoft.Azure.Cosmos.Table;
using Microsoft.EntityFrameworkCore;
using StreamingTools.Data;
using StreamingTools.Git;
using StreamingTools.Subtitle;
using StreamingTools.YouTube;
using System;
using System.CommandLine;

namespace Keboo.Editor;

public partial class YouTubeCommand : CliCommand
{
    private static CliOption<FileInfo> InputFileOption { get; } = new CliOption<FileInfo>("--input-file", "-f")
    {
        Description = "An input file"
    }.AcceptExistingOnly();

    private static CliOption<int> VideoIdOption { get; } = new CliOption<int>("--id", "-i")
    {
        Description = "The video id"
    };

    private static CliOption<string> TwitchVideoIdOption { get; } = new CliOption<string>("--twitch-id", "-t")
    {
        Description = "The twitch video id"
    };

    private static CliOption<DirectoryInfo> OutputDirectory { get; } = new CliOption<DirectoryInfo>("--output-directory", "-o")
    {
        Description = "The output directory",
        Required = true
    }.AcceptExistingOnly();


    public YouTubeCommand()
     : base("youtube")
    {
        var listingCommand = new CliCommand("listing")
        {
            InputFileOption,
            VideoIdOption,
            TwitchVideoIdOption
        };
        Add(listingCommand);
        listingCommand.SetAction(async (ctx, ct) =>
        {
            using var dbContext = await GetDbContextAsync(ct);
            var twitchVideo = await GetVideoAsync(ctx, dbContext, ct);

            if (twitchVideo is null)
            {
                Console.WriteLine($"No Twitch video found");
                return 1;
            }

            string? title = twitchVideo.TwitchTitle;
            string description = twitchVideo.TwitchDescription ?? string.Empty;
            DateTime recordingDate = twitchVideo.TwitchStartTime!.Value.DateTime;
            HashSet<string> playlists =
            [
                "C# Programming"
            ];
            HashSet<string> tags =
            [
                "programming"
            ];
            if (twitchVideo.TwitchTitle?.Contains("C#", StringComparison.OrdinalIgnoreCase) == true)
            {
                tags.Add("C#");
            }
            if (twitchVideo.TwitchTitle?.Contains("WPF", StringComparison.OrdinalIgnoreCase) == true)
            {
                tags.Add("C#");
                tags.Add("WPF");
            }
            if (twitchVideo.TwitchTitle?.Contains("XAML", StringComparison.OrdinalIgnoreCase) == true)
            {
                tags.Add("XAML");
            }
            if (twitchVideo.TwitchTitle?.Contains("Material Design", StringComparison.OrdinalIgnoreCase) == true)
            {
                description += Environment.NewLine + Environment.NewLine + "Material Design In XAML Project: https://github.com/MaterialDesignInXAML/MaterialDesignInXamlToolkit";
                tags.Add("material design");
                tags.Add("WPF");
                playlists.Add("Material Design in Xaml");
            }
            if (twitchVideo.TwitchTitle?.Contains("System.CommandLine", StringComparison.OrdinalIgnoreCase) == true)
            {
                tags.Add("C#");
                tags.Add("command line");
                tags.Add("System.CommandLine");
                playlists.Add("System.CommandLine");
                description += Environment.NewLine + Environment.NewLine + "System.CommandLine: https://github.com/dotnet/command-line-api";
            }
            if (twitchVideo.TwitchTitle?.Contains("terraform", StringComparison.OrdinalIgnoreCase) == true)
            {
                tags.Add("terraform");
                tags.Add("azure");
                tags.Add("devops");
                playlists.Add("Terraform");
                playlists.Add("DevOps");
                playlists.Add("Azure");
            }
            if (twitchVideo.TwitchTitle?.Contains("DevOps", StringComparison.OrdinalIgnoreCase) == true)
            {
                tags.Add("devops");
                playlists.Add("DevOps");
            }
            if (twitchVideo.TwitchTitle?.Contains("GitHub", StringComparison.OrdinalIgnoreCase) == true)
            {
                tags.Add("github");
            }
            if (twitchVideo.TwitchTitle?.Contains("GitHub Actions", StringComparison.OrdinalIgnoreCase) == true)
            {
                tags.Add("github actions");
            }
            if (twitchVideo.TwitchTitle?.Contains("K8s", StringComparison.OrdinalIgnoreCase) == true ||
                twitchVideo.TwitchTitle?.Contains("Kubernetes", StringComparison.OrdinalIgnoreCase) == true)
            {
                tags.Add("kubernetes");
            }
            if (twitchVideo.TwitchTitle?.Contains("helm", StringComparison.OrdinalIgnoreCase) == true)
            {
                tags.Add("helm");
                tags.Add("kubernetes");
            }
            if (twitchVideo.TwitchTitle?.Contains("Azure", StringComparison.OrdinalIgnoreCase) == true)
            {
                tags.Add("azure");
            }
            if (twitchVideo.TwitchTitle?.Contains("WinUI", StringComparison.OrdinalIgnoreCase) == true)
            {
                tags.Add("winui");
            }
            if (twitchVideo.TwitchTitle?.Contains("Velopack", StringComparison.OrdinalIgnoreCase) == true)
            {
                tags.Add("velopack");
                tags.Add("installer");

                playlists.Add("Velopack");

                description += """

                    Velopack: https://velopack.io
                    """;
            }
            if (twitchVideo.TwitchTitle?.Contains("GitKraken", StringComparison.OrdinalIgnoreCase) == true)
            {
                tags.Add("gitkraken");

                playlists.Add("GitKraken");
            }
            if (twitchVideo.TwitchTitle?.Contains("Avalonia", StringComparison.OrdinalIgnoreCase) == true)
            {
                tags.Add("avalonia");

                description += """

                    Avalonia UI: https://avaloniaui.net
                    """;
            }

            description += """

                GitKraken: https://www.gitkraken.com

                Broadcasted live on Twitch -- Watch live at https://twitch.keboo.dev
                """;

            Console.WriteLine($"""
                Title:
                {title}

                Description:
                {description}

                Playlists: {string.Join(", ", playlists)}
                Tags: {string.Join(", ", tags)}
                Recording Date: {recordingDate:d}
                """);

            return 0;
        });

        var subtitlesCommand = new CliCommand("subtitles")
        {
            InputFileOption,
            VideoIdOption,
            TwitchVideoIdOption,
            OutputDirectory
        };
        Add(subtitlesCommand);
        subtitlesCommand.SetAction(GenerateSubtitles);
    }

    private static async Task<int> GenerateSubtitles(ParseResult ctx, CancellationToken token)
    {
        using var dbContext = await GetDbContextAsync(token);

        var service = await YouTubeFactory.GetServiceAsync();

        Video? video = await GetVideoAsync(ctx, dbContext, token);

        if (string.IsNullOrWhiteSpace(video?.YouTubeId))
        {
            Console.WriteLine("Could not find YouTube video id");
            return 1;
        }

        DateTime publishedAt = video.TwitchStartTime?.Date ?? DateTime.Today;
        Uri? markdownUri = await GetMarkdownUrl(video, publishedAt, token);
        if (markdownUri is null)
        {
            Console.WriteLine($"Could not get markdown url for video (ID: {video.Id})");
            return 1;
        }

        if (await service.GetSrtSubtitles(video.YouTubeId, token) is { Length: > 0 } subtitles)
        {
            Console.WriteLine("  Got subtitles");
            string markdown = Subtitles.ConvertSrtToMarkdown(video.YouTubeId, subtitles);
            DirectoryInfo outputDirectory = ctx.GetValue(OutputDirectory)!;
            string fileName = await WriteToFile(outputDirectory, markdown, video.YouTubeId, publishedAt, token);
            Console.WriteLine($"  Wrote markdown to '{fileName}'");
            video.SubtitlesUrl = markdownUri.AbsoluteUri;

            var videoQuery = service.Videos.List("snippet");
            videoQuery.Id = video.YouTubeId;
            var videoResponse = await videoQuery.ExecuteAsync(token);
            if (videoResponse.Items is { Count: > 0 } videos &&
                videos[0] is { } youTubeVideo &&
                youTubeVideo.Snippet?.Description is { } description &&
                description.Contains(video.SubtitlesUrl) != true)
            {
                Console.WriteLine($"Updating video {video.Id} description");
                description +=
                    Environment.NewLine +
                    Environment.NewLine +
                    $"Search video contents here: {video.SubtitlesUrl}";

                youTubeVideo.Snippet.Description = description;
                await service.Videos.Update(youTubeVideo, "snippet").ExecuteAsync(token);
            }
            Console.WriteLine($"  Set video ({video.Id}) subtitle URL to be '{video.SubtitlesUrl}'");
        }
        else
        {
            Console.WriteLine($"  YouTube video '{video.YouTubeId}' not found");
            video.SubtitlesUrl = "YouTube Video Removed";
            return 2;
        }
        await dbContext.SaveChangesAsync(token);

        return 0;

        static async Task<string> WriteToFile(DirectoryInfo outputDirectory, string markdownContent, string videoId, DateTime date, CancellationToken token)
        {
            string fileName = Subtitles.GetMarkdownFileName(videoId, date);
            var path = Path.Combine(outputDirectory.FullName, fileName);

            await File.WriteAllTextAsync(path, markdownContent, token);

            return fileName;
        }

        static async Task<Uri?> GetMarkdownUrl(Video video, DateTime publishedAt, CancellationToken token)
        {
            string fileName = Subtitles.GetMarkdownFileName(video.YouTubeId!, publishedAt);
            string branchName = (await GitHelper.GetCurrentBranchName(token)) ?? "main";

            if (await GitHelper.GetRemoteUrl(token) is { } remoteUrl)
            {
                //TODO: Output directory is currently hard coded to match workflow
                return new Uri(remoteUrl, $"blob/{branchName}/Subtitles/{fileName}");
            }
            return null;
        }
    }

    private static async Task<StreamingDbContext> GetDbContextAsync(CancellationToken token)
    {
        var dbContext = new StreamingDbContext();
        await dbContext.Database.MigrateAsync(token);
        return dbContext;
    }

    private static async Task<Video?> GetVideoAsync(ParseResult ctx, StreamingDbContext dbContext, CancellationToken token)
    {
        Video? rv = null;

        if (ctx.GetValue(VideoIdOption) is var videoId and > 0)
        {
            rv = await dbContext.Videos.AsTracking().FirstOrDefaultAsync(x => x.Id == videoId, token);
        }

        if (rv is null && ctx.GetValue(TwitchVideoIdOption) is string twitchVideoId)
        {
            rv = await dbContext.Videos.AsTracking().FirstOrDefaultAsync(x => x.TwitchId == twitchVideoId, token);
        }

        if (rv is null && ctx.GetValue(InputFileOption) is { } input)
        {
            Match match = TwitchId().Match(input.Name);
            if (!match.Success)
            {
                Console.WriteLine("Invalid file name format. Expected format: *_<TwitchVideoId>.trimmed.*");
            }
            else
            {
                twitchVideoId = match.Groups["TwitchVideoId"].Value;
                rv = await dbContext.Videos.AsTracking().FirstOrDefaultAsync(x => x.TwitchId == twitchVideoId, token);
            }
        }

        return rv;
    }

    [GeneratedRegex("_(?<TwitchVideoId>[0-9]+).trimmed")]
    private static partial Regex TwitchId();
}
