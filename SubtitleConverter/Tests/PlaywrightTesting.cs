using Microsoft.Extensions.Configuration;
using Microsoft.Playwright;
using StreamingTools;

namespace Tests;

public static class Config
{
    private static IConfiguration Configuration { get; }

    static Config()
    {
        var configBuilder = new ConfigurationBuilder();
        configBuilder.AddEnvironmentVariables();
        configBuilder.AddUserSecrets(typeof(Config).Assembly);

        Configuration = configBuilder.Build();
    }

    public static string YouTubeUsername => Configuration["YouTube:Username"] ?? throw new InvalidOperationException("YouTubeUsername is not configured");
    public static string YouTubePassword => Configuration["YouTube:Password"] ?? throw new InvalidOperationException("YouTubePassword is not configured");
}

public class PlaywrightTesting
{
    [Fact]
    public async Task CanLocateCallPhone()
    {
        using var playwright = await Playwright.CreateAsync();

        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions() { Headless = false });

        var page = await browser.NewPageAsync();

        await page.GotoAsync("file:///C:/Users/kitok/Downloads/SubtitleConverter/Data/3.htm");

        if (await page.QuerySelectorAsync(":text('Call your phone on file')") is { } callPhone &&
            await callPhone.IsVisibleAsync())
        {
            await callPhone.ClickAsync(new() { Delay = 100, Force = true });

            await Task.Delay(1000);
        }
    }

    [Fact]
    public async Task CanTrimSilence()
    {
        FileInfo file = new(@"C:\Users\kitok\Downloads\test.mp4");
        await Ffmpeg.TrimSilence(file);
    }

    [Fact]
    public async Task CanYouTubeLogin()
    {
        using var playwright = await Playwright.CreateAsync();

        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions() { Headless = false });

        var page = await browser.NewPageAsync();

        await page.GotoAsync("https://studio.youtube.com/");

        Console.WriteLine("Performing login");
        await page.FillAsync("input[type=\"email\"]", Config.YouTubeUsername);
        await page.ClickAsync(":text('Next')");
        await page.WaitForSelectorAsync("input[type=\"password\"]");
        await page.FillAsync("input[type=\"password\"]", Config.YouTubePassword);
        await page.ClickAsync(":text('Next')");
        await page.WaitForURLAsync("**/challenge/ipp?*");
        { }
    }
}
