using StreamingTools;
using System.CommandLine;

namespace Keboo.Editor;

public class VideoCommand : CliCommand
{
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
