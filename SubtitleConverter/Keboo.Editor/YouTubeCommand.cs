using Microsoft.EntityFrameworkCore;
using StreamingTools.Data;
using StreamingTools.YouTube;
using System.CommandLine;

namespace Keboo.Editor;

public partial class YouTubeCommand : CliCommand
{
    private static HttpClient HttpClient { get; } = new();

    private CliOption<FileInfo> InputOption { get; } = new CliOption<FileInfo>("--input", "-i")
    {
        Description = "An input file",
        Required = true
    }.AcceptExistingOnly();

    public YouTubeCommand()
     : base("youtube")
    {
        var uploadCommand = new CliCommand("listing")
        {
            InputOption
        };
        Add(uploadCommand);

        var installDependenciesCommand = new CliCommand("--install-dependencies");
        Add(installDependenciesCommand);


        uploadCommand.SetAction(async (ctx, ct) =>
        {
            FileInfo input = ctx.GetValue(InputOption)!;

            Match match = TwitchId().Match(input.Name);
            if (!match.Success)
            {
                Console.WriteLine("Invalid file name format. Expected format: *_<TwitchVideoId>.trimmed.*");
                return;
            }
            string twitchVideoId = match.Groups["TwitchVideoId"].Value;

            using var dbContext = await GetDbContextAsync();
            var twitchVideo = await dbContext.Videos
                .FirstOrDefaultAsync(v => v.TwitchId == twitchVideoId, ct);

            if (twitchVideo is null)
            {
                Console.WriteLine($"No Twitch video found with ID {twitchVideoId}");
                return;
            }

            string title = twitchVideo.TwitchTitle ?? input.Name;
            string description = twitchVideo.TwitchDescription ?? string.Empty;
            DateTime recordingDate = twitchVideo.TwitchStartTime!.Value.DateTime;
            HashSet<string> playlists =
            [
                "C# Programming"
            ];
            HashSet<string> tags =
            [
                "programming"
            ];
            if (twitchVideo.TwitchTitle?.Contains("C#", StringComparison.OrdinalIgnoreCase) == true)
            {
                tags.Add("C#");
            }
            if (twitchVideo.TwitchTitle?.Contains("WPF", StringComparison.OrdinalIgnoreCase) == true)
            {
                tags.Add("C#");
                tags.Add("WPF");
            }
            if (twitchVideo.TwitchTitle?.Contains("XAML", StringComparison.OrdinalIgnoreCase) == true)
            {
                tags.Add("XAML");
            }
            if (twitchVideo.TwitchTitle?.Contains("Material Design", StringComparison.OrdinalIgnoreCase) == true)
            {
                description += Environment.NewLine + Environment.NewLine + "Material Design In XAML Project: https://github.com/MaterialDesignInXAML/MaterialDesignInXamlToolkit";
                tags.Add("material design");
                tags.Add("WPF");
                playlists.Add("Material Design in Xaml");
            }
            if (twitchVideo.TwitchTitle?.Contains("System.CommandLine", StringComparison.OrdinalIgnoreCase) == true)
            {
                tags.Add("C#");
                tags.Add("command line");
                tags.Add("System.CommandLine");
                playlists.Add("System.CommandLine");
                description += Environment.NewLine + Environment.NewLine + "System.CommandLine: https://github.com/dotnet/command-line-api";
            }
            if (twitchVideo.TwitchTitle?.Contains("terraform", StringComparison.OrdinalIgnoreCase) == true)
            {
                tags.Add("terraform");
                tags.Add("azure");
                tags.Add("devops");
                playlists.Add("Terraform");
                playlists.Add("DevOps");
                playlists.Add("Azure");
            }
            if (twitchVideo.TwitchTitle?.Contains("DevOps", StringComparison.OrdinalIgnoreCase) == true)
            {
                tags.Add("devops");
                playlists.Add("DevOps");
            }
            if (twitchVideo.TwitchTitle?.Contains("GitHub", StringComparison.OrdinalIgnoreCase) == true)
            {
                tags.Add("github");
            }
            if (twitchVideo.TwitchTitle?.Contains("GitHub Actions", StringComparison.OrdinalIgnoreCase) == true)
            {
                tags.Add("github actions");
            }
            if (twitchVideo.TwitchTitle?.Contains("K8s", StringComparison.OrdinalIgnoreCase) == true ||
                twitchVideo.TwitchTitle?.Contains("Kubernetes", StringComparison.OrdinalIgnoreCase) == true)
            {
                tags.Add("kubernetes");
            }
            if (twitchVideo.TwitchTitle?.Contains("helm", StringComparison.OrdinalIgnoreCase) == true)
            {
                tags.Add("helm");
                tags.Add("kubernetes");
            }
            if (twitchVideo.TwitchTitle?.Contains("Azure", StringComparison.OrdinalIgnoreCase) == true)
            {
                tags.Add("azure");
            }
            if (twitchVideo.TwitchTitle?.Contains("WinUI", StringComparison.OrdinalIgnoreCase) == true)
            {
                tags.Add("winui");
            }
            if (twitchVideo.TwitchTitle?.Contains("Velopack", StringComparison.OrdinalIgnoreCase) == true)
            {
                tags.Add("velopack");
                tags.Add("installer");

                playlists.Add("Velopack");

                description += """

                    Velopack: https://velopack.io
                    """;
            }
            if (twitchVideo.TwitchTitle?.Contains("GitKraken", StringComparison.OrdinalIgnoreCase) == true)
            {
                tags.Add("gitkraken");

                playlists.Add("GitKraken");
            }
            if (twitchVideo.TwitchTitle?.Contains("Avalonia", StringComparison.OrdinalIgnoreCase) == true)
            {
                tags.Add("avalonia");

                description += """

                    Avalonia UI: https://avaloniaui.net
                    """;
            }

            description += """

                GitKraken: https://www.gitkraken.com

                Broadcasted live on Twitch -- Watch live at https://twitch.keboo.dev
                """;

            Console.WriteLine($"""
                File:
                {input.FullName}

                Title:
                {title}

                Description:
                {description}

                Playlists: {string.Join(", ", playlists)}
                Tags: {string.Join(", ", tags)}
                Recording Date: {recordingDate:d}
                """);
        });

        installDependenciesCommand.SetAction(async (ctx, ct) =>
        {
            //const string playwrightScript = "pwsh playwright.ps1 install";
            Console.WriteLine("Downloading Playwright browsers");
            ProcessStartInfo startInfo = new();
            startInfo.FileName = "powershell";
            startInfo.ArgumentList.Add("-File");
            startInfo.ArgumentList.Add("playwright.ps1");
            startInfo.ArgumentList.Add("install");
            startInfo.UseShellExecute = true;

            using var p = Process.Start(startInfo);
            await p.WaitForExitAsync(ct);
            Console.WriteLine("Done");
        });
    }

    private static async Task<StreamingDbContext> GetDbContextAsync()
    {
        var dbContext = new StreamingDbContext();
        await dbContext.Database.MigrateAsync();
        return dbContext;
    }

    [GeneratedRegex("_(?<TwitchVideoId>[0-9]+).trimmed")]
    private static partial Regex TwitchId();
}
