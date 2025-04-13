using StreamingTools;
using System.CommandLine;

namespace Keboo.Editor;

public class Program
{
    public static Task<int> Main(string[] args)
    {
        CliCommand videoTrimCommand = new("trim")
        {
            new CliOption<FileSystemInfo>("--input", "-i")
            {
                Description = "An input file or directory",
                Required = true
            }.AcceptExistingOnly(),
            new CliOption<FileSystemInfo>("--output", "-o")
            {
                Description = "An output file or directory",
                Required = true
            }
        };

        videoTrimCommand.SetAction(async (ctx, ct) =>
        {
            FileSystemInfo input = ctx.GetValue<FileSystemInfo>("--input")!;
            FileSystemInfo output = ctx.GetValue<FileSystemInfo>("--output")!;

            if (input.Attributes.HasFlag(FileAttributes.Directory) &&
                output.Attributes.HasFlag(FileAttributes.Directory))
            {
                //Both are directories process
                foreach(var inputFile in Directory.GetFiles(input.FullName, "*.mp4"))
                {
                    var outputFile = Path.ChangeExtension(inputFile, ".trimmed.mp4");
                    await Ffmpeg.TrimSilenceAsync(new FileInfo(input.FullName), new FileInfo(output.FullName));
                }
            }
            else if (!input.Attributes.HasFlag(FileAttributes.Directory) &&
                !output.Attributes.HasFlag(FileAttributes.Directory))
            {
                //Both are files
                await Ffmpeg.TrimSilenceAsync(new FileInfo(input.FullName), new FileInfo(output.FullName));
            }
        });

        CliCommand videoCommand = new("video")
        {
            videoTrimCommand
        };

        CliRootCommand rootCommand =
        [
            new TwitchCommand(),
            new VideoCommand(),
        ];

        return new CliConfiguration(rootCommand).InvokeAsync(args);
    }
}
