using Microsoft.Playwright;
using Microsoft.VisualBasic.Logging;
using StreamingTools;
using StreamingTools.YouTube;

namespace Tests.YouTube;

public class YouTubeBrowserTests
{
    private static HttpClient HttpClient { get; } = new();

    [Fact]
    public async Task CanPerformLogin()
    {
        YouTubeBrowser youTubeBrowser = new(Config.YouTubeUsername, Config.YouTubePassword, Config.YouTubeRecoveryEmail, Config.YouTubeTwoFactorCallbackUrl, HttpClient);
        
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions() { Headless = false });

        var page = await browser.NewPageAsync();

        await page.GotoAsync("https://studio.youtube.com/");

        await youTubeBrowser.PerformLogin(page);
        await youTubeBrowser.HandleRecoveryPrompts(page);
    }

    [Fact]
    public async Task TestUpload()
    {
        FileInfo tempFile = new("temp-life.mp4");
        if (!tempFile.Exists)
            GenerateRandomVideo(tempFile);
        YouTubeBrowser youTubeBrowser = new(Config.YouTubeUsername, Config.YouTubePassword, Config.YouTubeRecoveryEmail, Config.YouTubeTwoFactorCallbackUrl, HttpClient);
        await youTubeBrowser.UploadAsync(tempFile, "Test", "Description", DateTime.Now, [], []);
    }

    private static void GenerateRandomVideo(FileInfo outputFile)
    {
        var startInfo = new ProcessStartInfo
        {
            FileName = "ffmpeg",
            Arguments = $"-f lavfi -i life=size=1280x720:rate=25:ratio=0.1 -y -t 10 -pix_fmt yuv420p \"{outputFile.FullName}\"",
            UseShellExecute = false
        };

        using var ffmpegProcess = new Process { StartInfo = startInfo };
        ffmpegProcess.Start();

        ffmpegProcess.WaitForExit();
    }
}
