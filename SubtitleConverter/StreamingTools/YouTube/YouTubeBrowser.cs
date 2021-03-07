using PlaywrightSharp;
using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace StreamingTools.YouTube
{
    public class YouTubeBrowser
    {
        private string Username { get; }
        private string Password { get; }
        private string RecoveryEmail { get; }

        public YouTubeBrowser(string username, string password, string recoveryEmail)
        {
            Username = username;
            Password = password;
            RecoveryEmail = recoveryEmail;
        }

        public async Task UploadAsync()
        {
            string filePath = @"D:\OneDrive\Videos\Jubilee Nutcracker 2019_1.mp4";
            //string filePath = @"D:\OneDrive\Pictures\Camera Roll\VID_20210220_134134.mp4";

            var base64Encode = Base64Encode(filePath);
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync(headless: false);
            var page = await browser.NewPageAsync();
            await page.GoToAsync("https://studio.youtube.com/");
            //IElementHandle? signIn = await FirstWithText(page, "a > paper-button yt-formatted-string", "Sign In");
            //await signIn.ClickAsync();
            await page.TypeAsync("input[type=\"email\"]", Username);
            await page.ClickAsync(":text('Next')");
            //await Task.Delay(TimeSpan.FromSeconds(1));
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
                    await page.TypeAsync("input[type=\"email\"]", RecoveryEmail);
                    await page.ClickAsync(":text('Next')");
                }
                await Task.Delay(100);
            }


            await page.ClickAsync("#avatar-btn");
            await page.ClickAsync(":text('Switch account')");
            await page.ClickAsync(":text('Kevin Bost')");
            await page.ClickAsync("ytcp-icon-button[aria-label=\"Upload videos\"]");

            var tcs = new TaskCompletionSource<int>();
            page.FileChooser += Page_FileChooser;
            await page.ClickAsync("#select-files-button");
            await tcs.Task;

            //TODO: Set metadata

            await page.ClickAsync("#next-button");

            //TODO: Set cards
            await page.ClickAsync("#next-button");

            //Make private
            await page.ClickAsync("paper-radio-button[name=\"PRIVATE\"]");

            //for (string progress = await page.GetTextContentAsync(@"span.progress-label");
            //    (progress ?? "").Contains("processing", StringComparison.OrdinalIgnoreCase);
            //    progress = await page.GetTextContentAsync(@"span.progress-label"))
            //{
            //    await Task.Delay(100);
            //}

            await WaitFor(() => page.IsEnabledAsync("#done-button"));
            await page.ClickAsync("#done-button");

            //IElementHandle? upload = await FirstWithText(page, "#endpoint", "Upload video");
            //await upload.ClickAsync();

            await Task.Delay(TimeSpan.FromSeconds(10));

            async void Page_FileChooser(object? sender, FileChooserEventArgs e)
            {
                page.FileChooser -= Page_FileChooser;
                
                await e.SetFilesAsync(new FilePayload
                {
                    Name = Path.GetFileName(filePath),
                    MimeType = GetMimeType(filePath),
                    Buffer = await base64Encode
                });
                tcs.TrySetResult(0);
            }
        }

        private static async Task<string> Base64Encode(string filePath)
        {
            using FileStream inputFile = new(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, bufferSize: 1024 * 1024, useAsync: true);
            using CryptoStream base64Stream = new(inputFile, new ToBase64Transform(), CryptoStreamMode.Read);
            using var sr = new StreamReader(base64Stream);
            return await sr.ReadToEndAsync();
        }

        private static async Task WaitFor(Func<Task<bool>> condition)
        {
            var sw = Stopwatch.StartNew();
            bool state;
            while (!(state = await condition()) && sw.Elapsed < TimeSpan.FromSeconds(30))
            { }
            if (!state) throw new Exception("Failed timeout while waiting for condition");
        }

        private static string GetMimeType(string filePath)
        {
            return typeof(PlaywrightSharp.Helpers.StringExtensions)
                .GetMethod("MimeType", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static)?
                .Invoke(null, new object?[] { filePath }) as string ?? "";
        }
    }
}
