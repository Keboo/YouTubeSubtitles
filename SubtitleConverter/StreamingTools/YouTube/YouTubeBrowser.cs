﻿using FlaUI.Core.Input;
using FlaUI.Core.WindowsAPI;
using PlaywrightSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using User32 = PInvoke.User32;

namespace StreamingTools.YouTube
{
    public class YouTubeBrowser
    {
        private int _Counter;
        private string Username { get; }
        private string Password { get; }
        private string RecoveryEmail { get; }

        public YouTubeBrowser(string username, string password, string recoveryEmail)
        {
            Username = username ?? throw new ArgumentNullException(nameof(username));
            Password = password ?? throw new ArgumentNullException(nameof(password));
            RecoveryEmail = recoveryEmail ?? throw new ArgumentNullException(nameof(recoveryEmail));
        }

        public async Task<string> UploadAsync(
            string filePath,
            string title,
            string description,
            DateTime recordingDate,
            IReadOnlyCollection<string> playlists,
            IReadOnlyCollection<string> tags)
        {
            using var playwright = await Playwright.CreateAsync();

            await using var browser = await playwright.Chromium.LaunchAsync(headless: false);

            var page = await browser.NewPageAsync();
            try
            {
                await page.GoToAsync("https://studio.youtube.com/");

                await page.TypeAsync("input[type=\"email\"]", Username);
                await page.ClickAsync(":text('Next')");
                await page.WaitForSelectorAsync("input[type=\"password\"]");
                await page.TypeAsync("input[type=\"password\"]", Password);
                var navTask = page.WaitForNavigationAsync();
                await page.ClickAsync(":text('Next')");

                await navTask;
                //Check for recovery prompts
                for (int i = 0; i < 300; i++)
                {
                    if (await page.QuerySelectorAsync("#avatar-btn") is not null) break;

                    if (await page.QuerySelectorAsync(":text('Confirm your recovery email')") is { } confirmEmailLink)
                    {
                        await confirmEmailLink.ClickAsync();
                    }
                    if (await page.QuerySelectorAsync("input[type=\"email\"]") is { } email &&
                        !string.Equals(RecoveryEmail, await email.GetInnerTextAsync()))
                    {
                        await page.TypeAsync("input[type=\"email\"]", RecoveryEmail);
                        await page.ClickAsync(":text('Next')");
                        break;
                    }
                    await Task.Delay(100);
                }

                await page.ClickAsync("#avatar-btn");
                await page.ClickAsync(":text('Switch account')");
                await page.ClickAsync(":text('Kevin Bost')");
                await page.ClickAsync("ytcp-icon-button[aria-label=\"Upload videos\"]");

                await page.ClickAsync("#select-files-button");

                string windowTitle = await page.GetTitleAsync();

                var browserProcess = Process.GetProcesses()
                    .Where(x => x.MainWindowTitle.Contains(windowTitle)).ToList();
                await Task.Delay(2000);
                foreach (var process in browserProcess)
                {
                    var callback = new User32.WNDENUMPROC((x, y) =>
                    {
                        if (process.MainWindowHandle == User32.GetParent(x) &&
                            User32.GetWindowText(x) == "Open")
                        {
                            Keyboard.Type(filePath);
                            Keyboard.Press(VirtualKeyShort.ENTER);
                            return false;
                        }
                        return true;
                    });
                    User32.EnumWindows(callback, IntPtr.Zero);
                }

                var titleRequired = await page.WaitForSelectorAsync(":text('Title (required)')");
                await Task.Delay(500);
                await page.TypeAsync("#textbox[aria-label=\"Add a title that describes your video\"]", title);
                await page.TypeAsync("#textbox[aria-label=\"Tell viewers about your video\"]", description);
                await page.ClickAsync("span.ytcp-text-dropdown-trigger:has-text('Select')");
                foreach (var playlist in playlists)
                {
                    await page.ClickAsync($"ytcp-ve li.ytcp-checkbox-group:has-text('{playlist}')");
                }
                await page.ClickAsync("ytcp-button.done-button[label=\"Done\"]");
                await page.ClickAsync("div.ytcp-button:has-text('More options')");
                await page.TypeAsync("input[aria-label=\"Tags\"]", string.Join(',', tags));

                await page.ClickAsync("ytcp-text-dropdown-trigger[label=\"Recording date\"]");
                await page.PressAsync("paper-input[aria-label=\"Enter date\"] >> input", "Control+a");


                await page.TypeAsync("paper-input[aria-label=\"Enter date\"]", $"{recordingDate:MM/dd/yyyy}");
                await page.PressAsync("paper-input[aria-label=\"Enter date\"] >> input", "Escape");

                await page.ClickAsync("#location >> input");
                await page.TypeAsync("#location >> input", "Spokane WA");
                await page.ClickAsync("paper-item:has-text('Spokane WA')");

                await page.ClickAsync("#next-button");

                //Set cards can't be done until after the video is done processing
                await page.ClickAsync("#next-button");

                //Make private
                await page.ClickAsync("paper-radio-button[name=\"PRIVATE\"]");

                await WaitFor(() => page.IsEnabledAsync("#done-button"));
                //Wait for upload complete
                await WaitFor(async () =>
                {
                    string statusText = await page.GetInnerTextAsync("span.ytcp-video-upload-progress");
                    return !statusText.Contains("Uploading");
                }, TimeSpan.FromHours(2));

                string youtubeLink = await page.GetInnerTextAsync("span.ytcp-video-info");

                await page.ClickAsync("#done-button");

                if (!string.IsNullOrWhiteSpace(youtubeLink) && Uri.TryCreate(youtubeLink, UriKind.Absolute, out Uri? url))
                {
                    return url.Segments.Last();
                }

                return "";
            }
            catch (Exception)
            {
                await CaptureStateAsync(page);
                throw;
            }
        }

        private async Task CaptureStateAsync(IPage page, string identifier = "")
        {
            int count = Interlocked.Increment(ref _Counter);
            string directory = Path.GetFullPath("./Data");
            Directory.CreateDirectory(directory);

            await File.WriteAllTextAsync(Path.Combine(directory, $"{count}{identifier}.htm"), await page.GetContentAsync());
            await page.ScreenshotAsync(Path.Combine(directory, $"{count}{identifier}.png"));
        }

        private static async Task WaitFor(Func<Task<bool>> condition, TimeSpan? timeout = null)
        {
            timeout ??= TimeSpan.FromSeconds(30);
            var sw = Stopwatch.StartNew();
            bool state;
            while (!(state = await condition()) && sw.Elapsed < timeout)
            { }
            if (!state) throw new Exception("Failed timeout while waiting for condition");
        }
    }
}
