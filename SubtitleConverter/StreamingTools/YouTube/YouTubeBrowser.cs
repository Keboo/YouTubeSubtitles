using PlaywrightSharp;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace StreamingTools.YouTube
{
    public class YouTubeBrowser
    {
        public string Username { get; }
        public string Password { get; }

        public YouTubeBrowser(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public async Task UploadAsync()
        {
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync(headless: false);
            var page = await browser.NewPageAsync();
            await page.GoToAsync("https://studio.youtube.com/");
            //IElementHandle? signIn = await FirstWithText(page, "a > paper-button yt-formatted-string", "Sign In");
            //await signIn.ClickAsync();
            await page.TypeAsync("input[type=\"email\"]", Username);
            await page.ClickAsync("button span");
            //await Task.Delay(TimeSpan.FromSeconds(1));
            await page.WaitForSelectorAsync("input[type=\"password\"]");
            await page.TypeAsync("input[type=\"password\"]", Password);
            await page.ClickAsync("button span");
            await page.ClickAsync("#avatar-btn");
            IElementHandle? switchAccount = await FirstContainingText(page, "#endpoint", "Switch account");
            await switchAccount.ClickAsync();
            IElementHandle? kevinAccount = await FirstContainingText(page, "ytd-account-item-renderer", "Kevin Bost");
            await kevinAccount.ClickAsync();
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

            for(string progress = await page.GetTextContentAsync(@"span.progress-label");
                (progress ?? "").IndexOf("processing", StringComparison.OrdinalIgnoreCase) < 0;
                progress = await page.GetTextContentAsync(@"span.progress-label"))
            {
                await Task.Delay(100);
            }

            await page.ClickAsync("#done-button");

            //IElementHandle? upload = await FirstWithText(page, "#endpoint", "Upload video");
            //await upload.ClickAsync();

            await Task.Delay(TimeSpan.FromSeconds(10));

            async void Page_FileChooser(object? sender, FileChooserEventArgs e)
            {
                page.FileChooser -= Page_FileChooser;
                string filePath = @"C:\Users\kitok\OneDrive\Videos\Jubilee Nutcracker 2019_1.mp4";
                using (FileStream inputFile = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.None, bufferSize: 1024 * 1024, useAsync: true)) // When using `useAsync: true` you get better performance with buffers much larger than the default 4096 bytes.
                using (CryptoStream base64Stream = new CryptoStream(inputFile, new ToBase64Transform(), CryptoStreamMode.Read))
                using (var sr = new StreamReader(base64Stream))
                //using (MemoryStream outputFile = new FileStream(@"C:\VeryLargeBase64File.txt", FileMode.CreateNew, FileAccess.Write, FileShare.None, bufferSize: 1024 * 1024, useAsync: true))
                {
                    string base64Content = await sr.ReadToEndAsync();
                    await e.SetFilesAsync(new FilePayload
                    {
                        Name = Path.GetFileName(filePath),
                        Buffer = base64Content
                    });
                    //await e.SetFilesAsync(@"C:\Users\kitok\OneDrive\Pictures\Camera Roll\VID_20190126_115455.mp4");
                }
                tcs.TrySetResult(0);
            }
        }


        private static async Task<IElementHandle?> FirstContainingText(IPage page, 
            string selector, string text)
        {
            for (int i = 0; i < 30; i++)
            {
                foreach (var element in await page.QuerySelectorAllAsync(selector))
                {
                    string elementText = (await element.GetTextContentAsync())?.Trim() ?? "";
                    if (elementText.IndexOf(text, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        return element;
                    }
                }
            }
            await Task.Delay(100);
            return null;
        }
    }
}
