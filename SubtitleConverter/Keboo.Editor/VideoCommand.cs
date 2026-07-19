using Microsoft.EntityFrameworkCore;
using StreamingTools;
using StreamingTools.Data;
using System.CommandLine;

namespace Keboo.Editor;

public class VideoCommand : Command
{
    private static Option<int> VideoIdOption { get; } = new("--video-id")
    {
        Aliases = { "-id" },
        Description = "The video id",
        Required = true
    };

    private static Option<string?> YouTubeIdOption { get; } = new("--youtube-id")
    {
        Aliases = { "-yt" },
        Description = "The YouTube id"
    };

    private static Option<string?> SubtitleUrlOption { get; } = new("--subtitle-url")
    {
        Aliases = { "-s" },
        Description = "The subtitle url"
    };

    private static Option<FileSystemInfo> InputOption { get; } = new Option<FileSystemInfo>("--input")
    {
        Aliases = { "-i" },
        Description = "An input file or directory",
        Required = true
    }.AcceptExistingOnly();

    private static Option<FileSystemInfo> OutputOption { get; } = new("--output")
    {
        Aliases = { "-o" },
        Description = "An output file or directory",
        Required = true
    };

    private static Option<bool> ForceOption { get; } = new("--force")
    {
        Aliases = { "-f" },
        Description = "Force the operation"
    };

    public VideoCommand()
        : base("video")
    {
        var videoTrimCommand = new Command("trim")
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

        var listVideosCommand = new Command("list-pending");
        Add(listVideosCommand);
        listVideosCommand.SetAction(ListPendingVideos);

        var updateVideo = new Command("update")
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

    public static async Task<bool> Trim(FileSystemInfo input, FileSystemInfo output)
    {
        if (Directory.Exists(input.FullName))
        {
            Directory.CreateDirectory(output.FullName);

            bool rv = true;
            //Both are directories process
            foreach (var inputFile in Directory.EnumerateFiles(input.FullName, "*.mp4"))
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
                rv &= await Ffmpeg.TrimSilenceAsync(new FileInfo(inputFile), new FileInfo(outputFile), log: Console.WriteLine);
            }
            return rv;
        }
        else if (File.Exists(input.FullName))
        {
            var outputFile = new FileInfo(output.FullName);
            if (outputFile.Exists)
            {
                Console.WriteLine($"Skipping {input.FullName} => {outputFile} already exists");
                return true;
            }
            outputFile.Directory?.Create();
            //Both are files
            return await Ffmpeg.TrimSilenceAsync(new FileInfo(input.FullName), outputFile, log: Console.WriteLine);
        }
        return false;
    }
}
