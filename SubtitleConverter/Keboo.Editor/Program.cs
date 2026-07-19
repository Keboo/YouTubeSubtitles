using Microsoft.EntityFrameworkCore;
using StreamingTools;
using StreamingTools.Data;
using StreamingTools.YouTube;
using System.CommandLine;

namespace Keboo.Editor;

public class Program
{
    private static Option<DirectoryInfo> TempDirectory { get; } = new("--working-directory")
    {
        Aliases = { "-o" },
        Description = "The working directory",
        Required = true,
        DefaultValueFactory = _ => new DirectoryInfo(@"D:\Temp")
    };

    private static Option<int?> VideoId { get; } = new("--video-id")
    {
        Aliases = { "-i" },
        Description = "The video ID to reprocess"
    };

    private static Option<bool> Clean { get; } = new("--clean")
    {
        Aliases = { "-c" },
        Description = "Whether to for a clean state rather than leveraging cached data"
    };

    public static Task<int> Main(string[] args)
    {
        Command processAll = new("process")
        {
            TempDirectory, 
            VideoId,
            Clean
        };
        processAll.SetAction(ProcessAll);

        RootCommand rootCommand =
        [
            processAll,
            new TwitchCommand(),
            new VideoCommand(),
            new YouTubeCommand()
        ];

        return rootCommand.Parse(args).InvokeAsync();
    }

    private static async Task<int> ProcessAll(ParseResult ctx, CancellationToken token)
    {
        // Pre-emptively auth with youtube so I can walk away while this runs.
        _ = await YouTubeFactory.GetServiceAsync();

        Console.WriteLine($"Processing all videos... ({DateTime.Now})");

        DirectoryInfo output = ctx.GetValue(TempDirectory)!;
        int? videoId = ctx.GetValue(VideoId);
        bool clean = ctx.GetValue(Clean);

        if (clean && output.Exists)
        {
            output.Delete(true);
        }

        VideoData? video;
        do
        {
            output.Create();

            if (videoId is not null)
            {
                using StreamingDbContext dbContext = await StreamingDbContext.CreateAsync(token);
                var dbVideo = await dbContext.Videos.FirstOrDefaultAsync(x => x.Id == videoId.Value, token);
                if (dbVideo is null)
                {
                    Console.WriteLine($"Video with ID {videoId} not found.");
                    return 1;
                }
                string? twitchId = dbVideo.TwitchId;
                if (twitchId is null)
                {
                    Console.WriteLine($"Video with ID {videoId} has no Twitch ID.");
                    return 1;
                }

                video = await TwitchCommand.DownloadSingleAsync(Config.TwitchClientId, Config.TwitchClientSecret, twitchId, output);
            }
            else
            {
                video = await TwitchCommand.DownloadNewVideo(Config.TwitchClientId, Config.TwitchClientSecret, Config.TwitchUserId, output);
            }

            if (video is not null)
            {
                FileInfo outputFile = new(Path.ChangeExtension(video.DownloadedFile.FullName, ".trimmed.mp4"));
                if (!await VideoCommand.Trim(video.DownloadedFile, outputFile) || 
                    await YouTubeCommand.UploadVideoAsync(outputFile, video.VideoId, token) != true)
                {
                    return 1;
                }
                output.Refresh();
                if (output.Exists)
                {
                    try
                    {
                        output.Delete(true);
                    }
                    catch
                    {
                        Console.WriteLine($"Failed to delete temporary working directory '{output.FullName}'.");
                    }
                }
                Console.WriteLine($"Processed video: {video.VideoId} ({DateTime.Now})");
            }
        }
        while (video is not null && videoId is null);
        return 0;
    }
}
