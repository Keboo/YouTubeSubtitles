using Microsoft.Playwright;

namespace Tests;

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
    }
}
