using StreamingTools.Data;

namespace StreamingTools.YouTube;

public static class Description
{
    public static string Build(Video video)
    {
        var (title, description, recordingDate, playlists, tags) = GetDetails(video);

        return $"""
                Id: {video.Id}
                TwitchId: {video.TwitchId}
                Twitch Description: {video.TwitchDescription}

                Title:
                {title}

                Description:
                {description}

                Playlists: {string.Join(", ", playlists)}
                Tags: {string.Join(", ", tags)}
                Recording Date: {recordingDate:d}
                """;
    }

    public static VideoDetails GetDetails(Video video)
    {
        string? title = video.TwitchTitle;
        string description = video.TwitchDescription ?? string.Empty;
        DateTime recordingDate = video.TwitchStartTime?.DateTime ?? DateTime.Now;
        HashSet<string> playlists =
        [
            "C# Programming"
        ];
        HashSet<string> tags =
        [
            "programming"
        ];
        if (video.TwitchTitle?.Contains("C#", StringComparison.OrdinalIgnoreCase) == true)
        {
            tags.Add("C#");
        }
        if (video.TwitchTitle?.Contains("WPF", StringComparison.OrdinalIgnoreCase) == true)
        {
            tags.Add("C#");
            tags.Add("WPF");
        }
        if (video.TwitchTitle?.Contains("XAML", StringComparison.OrdinalIgnoreCase) == true)
        {
            tags.Add("XAML");
        }
        if (video.TwitchTitle?.Contains("Material Design", StringComparison.OrdinalIgnoreCase) == true)
        {
            description += Environment.NewLine + Environment.NewLine + "Material Design In XAML Project: https://github.com/MaterialDesignInXAML/MaterialDesignInXamlToolkit";
            tags.Add("material design");
            tags.Add("WPF");
            playlists.Add("Material Design in Xaml");
        }
        if (video.TwitchTitle?.Contains("System.CommandLine", StringComparison.OrdinalIgnoreCase) == true)
        {
            tags.Add("C#");
            tags.Add("command line");
            tags.Add("System.CommandLine");
            playlists.Add("System.CommandLine");
            description += Environment.NewLine + Environment.NewLine + "System.CommandLine: https://github.com/dotnet/command-line-api";
        }
        if (video.TwitchTitle?.Contains("terraform", StringComparison.OrdinalIgnoreCase) == true)
        {
            tags.Add("terraform");
            tags.Add("azure");
            tags.Add("devops");
            playlists.Add("Terraform");
            playlists.Add("DevOps");
            playlists.Add("Azure");
        }
        if (video.TwitchTitle?.Contains("DevOps", StringComparison.OrdinalIgnoreCase) == true)
        {
            tags.Add("devops");
            playlists.Add("DevOps");
        }
        if (video.TwitchTitle?.Contains("GitHub", StringComparison.OrdinalIgnoreCase) == true)
        {
            tags.Add("github");
        }
        if (video.TwitchTitle?.Contains("GitHub Actions", StringComparison.OrdinalIgnoreCase) == true)
        {
            tags.Add("github actions");
        }
        if (video.TwitchTitle?.Contains("K8s", StringComparison.OrdinalIgnoreCase) == true ||
            video.TwitchTitle?.Contains("Kubernetes", StringComparison.OrdinalIgnoreCase) == true)
        {
            tags.Add("kubernetes");
        }
        if (video.TwitchTitle?.Contains("helm", StringComparison.OrdinalIgnoreCase) == true)
        {
            tags.Add("helm");
            tags.Add("kubernetes");
        }
        if (video.TwitchTitle?.Contains("Azure", StringComparison.OrdinalIgnoreCase) == true)
        {
            tags.Add("azure");
        }
        if (video.TwitchTitle?.Contains("WinUI", StringComparison.OrdinalIgnoreCase) == true)
        {
            tags.Add("winui");
        }
        if (video.TwitchTitle?.Contains("Velopack", StringComparison.OrdinalIgnoreCase) == true)
        {
            tags.Add("velopack");
            tags.Add("installer");

            playlists.Add("Velopack");

            description += """

                    Velopack: https://velopack.io
                    """;
        }
        if (video.TwitchTitle?.Contains("GitKraken", StringComparison.OrdinalIgnoreCase) == true)
        {
            tags.Add("gitkraken");

            playlists.Add("GitKraken");
        }
        if (video.TwitchTitle?.Contains("Avalonia", StringComparison.OrdinalIgnoreCase) == true)
        {
            tags.Add("avalonia");

            description += """

                    Avalonia UI: https://avaloniaui.net
                    """;
        }

        description += """

                GitKraken: https://www.gitkraken.com
                Velopack: https://velopack.io

                Broadcasted live on Twitch -- Watch live at https://twitch.keboo.dev
                """;

        // Add shared links from chat if available
        if (!string.IsNullOrWhiteSpace(video.SharedLinks))
        {
            description += Environment.NewLine + Environment.NewLine + "Links shared during stream:" + Environment.NewLine + video.SharedLinks;
        }

        return new VideoDetails(
            title ?? "",
            description,
            recordingDate,
            playlists,
            tags
        );
    }
}

public record class VideoDetails(string Title, string Description, DateTime RecordingDate, HashSet<string> Playlists, HashSet<string> Tags);
