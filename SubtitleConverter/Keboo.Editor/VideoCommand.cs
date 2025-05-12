using Microsoft.EntityFrameworkCore;
using StreamingTools;
using StreamingTools.Data;
using System.CommandLine;

namespace Keboo.Editor;

public class VideoCommand : CliCommand
{
    private static CliOption<int> VideoIdOption { get; } = new CliOption<int>("--video-id", "-id")
    {
        Description = "The video id",
        Required = true
    };

    private static CliOption<string?> YouTubeIdOption { get; } = new CliOption<string?>("--youtube-id", "-yt")
    {
        Description = "The YouTube id"
    };

    private static CliOption<string?> SubtitleUrlOption { get; } = new CliOption<string?>("--subtitle-url", "-s")
    {
        Description = "The subtitle url"
    };

    private static CliOption<FileSystemInfo> InputOption { get; } = new CliOption<FileSystemInfo>("--input", "-i")
    {
        Description = "An input file or directory",
        Required = true
    }.AcceptExistingOnly();

    private static CliOption<FileSystemInfo> OutputOption { get; } = new CliOption<FileSystemInfo>("--output", "-o")
    {
        Description = "An output file or directory",
        Required = true
    };

    private static CliOption<bool> ForceOption { get; } = new CliOption<bool>("--force", "-f")
    {
        Description = "Force the operation"
    };

    public VideoCommand()
        : base("video")
    {
        var videoTrimCommand = new CliCommand("trim")
        {
            InputOption,
            OutputOption
        };
        Add(videoTrimCommand);

        videoTrimCommand.SetAction(async (ctx, ct) =>
        {
            FileSystemInfo input = ctx.GetValue(InputOption)!;
            FileSystemInfo output = ctx.GetValue(OutputOption)!;
            await Trim(input, output);
        });

        var listVideosCommand = new CliCommand("list-pending");
        Add(listVideosCommand);
        listVideosCommand.SetAction(ListPendingVideos);

        var updateVideo = new CliCommand("update")
        {
            VideoIdOption,
            YouTubeIdOption,
            SubtitleUrlOption,
            ForceOption
        };
        Add(updateVideo);
        updateVideo.SetAction(UpdateVideoAsync);
    }

    private static async Task<int> UpdateVideoAsync(ParseResult ctx, CancellationToken token)
    {
        int videoId = ctx.GetValue(VideoIdOption);
        bool force = ctx.GetValue(ForceOption);
        using var dbContext = await StreamingDbContext.CreateAsync(token);

        Video video = await dbContext.Videos.SingleAsync(x => x.Id == videoId, token);

        if (ctx.GetValue(YouTubeIdOption) is { } youTubeId)
        {
            if (!string.IsNullOrWhiteSpace(video.YouTubeId) && !force)
            {
                Console.WriteLine($"YouTube Id is already set to {video.YouTubeId}. Use {ForceOption.Name} to overwrite.");
                return 1;
            }
            video.YouTubeId = youTubeId;
        }

        if (ctx.GetValue(SubtitleUrlOption) is { } subtitleUrl)
        {
            if (!string.IsNullOrWhiteSpace(video.SubtitlesUrl) && !force)
            {
                Console.WriteLine($"Subtitles URL is already set to {video.SubtitlesUrl}. Use {ForceOption.Name} to overwrite.");
                return 1;
            }
            video.SubtitlesUrl = subtitleUrl;
        }

        await dbContext.SaveChangesAsync(token);

        Console.WriteLine($"""
            Updated video
            ----------------
            Id: {video.Id}
            Title: {video.TwitchTitle}
            TwitchId: {video.TwitchId}
            YouTubeId: {video.YouTubeId}
            SubtitlesUrl: {video.SubtitlesUrl}
            ----------------
            """);

        return 0;
    }

    private static async Task<int> ListPendingVideos(ParseResult ctx, CancellationToken token)
    {
        using var dbContext = await StreamingDbContext.CreateAsync(token);
        await foreach (var video in dbContext.Videos
            .Where(x => x.SubtitlesUrl == null || x.YouTubeId == null || x.TwitchId == null)
            .OrderByDescending(x => x.TwitchStartTime).AsAsyncEnumerable())
        {
            Console.WriteLine($"Id: {video.Id}, {video.TwitchTitle}, {video.TwitchStartTime} TwitchId: {video.TwitchId}, YouTubeId: {video.YouTubeId}");

            if (string.IsNullOrWhiteSpace(video.TwitchId))
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"  Twitch Id is not set");
            }
            if (string.IsNullOrWhiteSpace(video.YouTubeId))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"  YouTube Id is not set");
            }
            if (string.IsNullOrWhiteSpace(video.SubtitlesUrl))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"  Subtitles URL is not set");
            }

            Console.ResetColor();
        }

        return 0;
    }

    public static async Task Trim(FileSystemInfo input, FileSystemInfo output)
    {
        if (input.Attributes.HasFlag(FileAttributes.Directory) &&
            output.Attributes.HasFlag(FileAttributes.Directory))
        {
            Directory.CreateDirectory(output.FullName);

            //Both are directories process
            foreach (var inputFile in Directory.GetFiles(input.FullName, "*.mp4"))
            {
                if (inputFile.EndsWith(".trimmed.mp4", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Skipping trimmed file {inputFile}");
                    continue;
                }
                var outputFile = Path.ChangeExtension(inputFile, ".trimmed.mp4");
                if (File.Exists(outputFile))
                {
                    Console.WriteLine($"Skipping {inputFile} => {outputFile} already exists");
                    continue;
                }
                await Ffmpeg.TrimSilenceAsync(new FileInfo(inputFile), new FileInfo(outputFile), log: Console.WriteLine);
            }
        }
        else if (!input.Attributes.HasFlag(FileAttributes.Directory) &&
                 !output.Attributes.HasFlag(FileAttributes.Directory))
        {
            var outputFile = new FileInfo(output.FullName);
            outputFile.Directory?.Create();
            //Both are files
            await Ffmpeg.TrimSilenceAsync(new FileInfo(input.FullName), outputFile, log: Console.WriteLine);
        }
    }
}
