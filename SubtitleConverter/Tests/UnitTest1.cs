using PlaywrightSharp;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class PlaywrightTesting
    {
        [Fact]
        public async Task CanLocateCallPhone()
        {
            using var playwright = await Playwright.CreateAsync();

            await using var browser = await playwright.Chromium.LaunchAsync(headless: false);

            var page = await browser.NewPageAsync();

            await page.GoToAsync("file:///C:/Users/kitok/Downloads/SubtitleConverter/Data/3.htm");

            if (await page.QuerySelectorAsync(":text('Call your phone on file')") is { } callPhone &&
                await callPhone.IsVisibleAsync())
            {
                await callPhone.ClickAsync(delay:100, force:true);

                await Task.Delay(1000);
            }
        }
    }
}