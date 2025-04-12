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

        CliCommand twitchDownload = new("download")
        {
            new CliOption<string>("--twitch-user-id")
            {
                DefaultValueFactory = _ => Environment.GetEnvironmentVariable("KebooTwitchUserId") ?? "",
                Required = true
            },
            new CliOption<string>("--twitch-client-id")
            {
                DefaultValueFactory = _ => Environment.GetEnvironmentVariable("KebooTwitchClientId") ?? "",
                Required = true
            },
            new CliOption<string>("--twitch-client-secret")
            {
                DefaultValueFactory = _ => Environment.GetEnvironmentVariable("KebooTwitchClientSecret") ?? "",
                Required = true
            },
            new CliOption<string>("--twitch-video-id"),
            new CliOption<DirectoryInfo>("--output")
            {
                DefaultValueFactory = _ => new DirectoryInfo(Path.Combine(Path.GetTempPath()))
            }
        };

        twitchDownload.SetAction(async (ctx, ct) =>
        {
            string? videoId = ctx.GetValue<string>("--twitch-video-id");

            if (!string.IsNullOrEmpty(videoId))
            {
                await Twitch.DownloadSingleAsync(
                        ctx.GetValue<string>("--twitch-client-id")!,
                        ctx.GetValue<string>("--twitch-client-secret")!,
                        videoId,
                        ctx.GetValue<DirectoryInfo>("--output")!
                    );
            }
            else
            {
                await Twitch.DownloadNewVideos(
                    ctx.GetValue<string>("--twitch-client-id")!,
                    ctx.GetValue<string>("--twitch-client-secret")!,
                    ctx.GetValue<string>("--twitch-user-id")!,
                    ctx.GetValue<DirectoryInfo>("--output")!
                );
            }
        });

        CliCommand twitchCommand = new("twitch")
        {
            twitchDownload
        };

        CliRootCommand rootCommand =
        [
            twitchCommand,
            videoCommand
        ];

        return new CliConfiguration(rootCommand).InvokeAsync(args);
    }
}
