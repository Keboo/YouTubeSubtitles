using Microsoft.Playwright;
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
        YouTubeBrowser youTubeBrowser = new(Config.YouTubeUsername, Config.YouTubePassword, Config.YouTubeRecoveryEmail, Config.YouTubeTwoFactorCallbackUrl, HttpClient);
        FileInfo testFile = new("C:\\Users\\kitok\\Videos\\Output.mp4");
        await youTubeBrowser.UploadAsync(testFile, "Test", "Description", DateTime.Now, Array.Empty<string>(), Array.Empty<string>());
    }
}
