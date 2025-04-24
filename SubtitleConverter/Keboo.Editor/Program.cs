using System.CommandLine;

namespace Keboo.Editor;

public class Program
{
    public static Task<int> Main(string[] args)
    {
        CliRootCommand rootCommand =
        [
            new TwitchCommand(),
            new VideoCommand(),
            new YouTubeCommand()
        ];

        return new CliConfiguration(rootCommand).InvokeAsync(args);
    }
}
