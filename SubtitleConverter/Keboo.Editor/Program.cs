using System.CommandLine;

namespace Keboo.Editor;

public class Program
{
    public static Task<int> Main(string[] args)
    {
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

        CliRootCommand rootCommand = new()
        {
            twitchCommand
        };

        return new CliConfiguration(rootCommand).InvokeAsync(args);
    }
}
