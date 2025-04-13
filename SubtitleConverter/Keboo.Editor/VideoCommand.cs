using StreamingTools;
using System.CommandLine;

namespace Keboo.Editor;

public class VideoCommand : CliCommand
{
    private CliOption<FileSystemInfo> InputOption { get; } = new CliOption<FileSystemInfo>("--input", "-i")
    {
        Description = "An input file or directory",
        Required = true
    }.AcceptExistingOnly();

    private CliOption<FileSystemInfo> OutputOption { get; } = new CliOption<FileSystemInfo>("--output", "-o")
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
            FileSystemInfo input = ctx.GetValue<FileSystemInfo>("--input")!;
            FileSystemInfo output = ctx.GetValue<FileSystemInfo>("--output")!;
            if (input.Attributes.HasFlag(FileAttributes.Directory) &&
                output.Attributes.HasFlag(FileAttributes.Directory))
            {
                Directory.CreateDirectory(output.FullName);

                //Both are directories process
                foreach (var inputFile in Directory.GetFiles(input.FullName, "*.mp4"))
                {
                    var outputFile = Path.ChangeExtension(inputFile, ".trimmed.mp4");
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
        });
    }
}
