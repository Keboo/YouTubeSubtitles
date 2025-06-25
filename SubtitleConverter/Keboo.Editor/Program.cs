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
        await TwitchCommand.DownloadNewVideos(Config.TwitchClientId, Config.TwitchClientSecret, Config.TwitchUserId, output);
        await VideoCommand.Trim(output, output);
        await YouTubeCommand.UploadVideosAsync(output, token);

        return 0;
    }
}
