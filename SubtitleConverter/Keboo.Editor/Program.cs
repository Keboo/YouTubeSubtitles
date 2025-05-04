using StreamingTools;
using System.CommandLine;

namespace Keboo.Editor;

public class Program
{
    public static Task<int> Main(string[] args)
    {
        CliCommand processAll = new("process");
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
        DirectoryInfo output = new(@"D:\Temp");
        await TwitchCommand.DownloadNewVideos(Config.TwitchClientId, Config.TwitchClientSecret, Config.TwitchUserId, output);
        await VideoCommand.Trim(output, output);
        return 0;
    }
}
