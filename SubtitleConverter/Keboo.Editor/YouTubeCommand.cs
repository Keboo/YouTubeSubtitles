using Microsoft.EntityFrameworkCore;
using StreamingTools.Data;
using StreamingTools.Git;
using StreamingTools.Subtitle;
using StreamingTools.YouTube;
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

            string description = StreamingTools.YouTube.Description.Build(twitchVideo);

            Console.WriteLine(description);

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
