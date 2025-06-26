using StreamingTools;
using System.CommandLine;

namespace Keboo.Editor;

public class Program
{
    private static CliOption<DirectoryInfo> TempDirectory { get; } = new CliOption<DirectoryInfo>("--working-directory", "-o")
    {
        Description = "The working directory",
        Required = true,
        DefaultValueFactory = _ => new DirectoryInfo(@"D:\Temp")
    };

    public static Task<int> Main(string[] args)
    {
        CliCommand processAll = new("process")
        {
            TempDirectory
        };
        processAll.SetAction(ProcessAll);

        CliRootCommand rootCommand =
        [
            processAll,
            new TwitchCommand(),
            new VideoCommand(),
            new YouTubeCommand()
        ];

        return new CliConfiguration(rootCommand).InvokeAsync(args);
    }

    private static async Task<int> ProcessAll(ParseResult ctx, CancellationToken token)
    {
        DirectoryInfo output = ctx.GetValue(TempDirectory)!;

        VideoData? video;
        do
        {
            output.Create();
            
            video = await TwitchCommand.DownloadNewVideo(Config.TwitchClientId, Config.TwitchClientSecret, Config.TwitchUserId, output);

            if (video is not null)
            {
                FileInfo outputFile = new(Path.ChangeExtension(video.DownloadedFile.FullName, ".trimmed.mp4"));
                if (await VideoCommand.Trim(video.DownloadedFile, outputFile))
                {
                    await YouTubeCommand.UploadVideoAsync(outputFile, video.VideoId, token);
                }
                output.Refresh();
                if (output.Exists)
                {
                    output.Delete(true);
                }
            }
        }
        while (video is not null);
        return 0;
    }
}
