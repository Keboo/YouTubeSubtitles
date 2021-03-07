using PInvoke;
using PlaywrightSharp;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading.Tasks;
using static PInvoke.User32;

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

        private delegate bool EnumWindowProc(IntPtr hwnd, IntPtr lParam);

        public async Task UploadAsync()
        {
            string filePath = @"D:\OneDrive\Videos\Jubilee Nutcracker 2019_1.mp4";
            //string filePath = @"D:\OneDrive\Pictures\Camera Roll\VID_20210220_134134.mp4";
            //var base64Encode = Base64Encode(filePath);
            //await base64Encode;
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
            //page.FileChooser += Page_FileChooser;
            
            await page.ClickAsync("#select-files-button");

            string title = await page.GetTitleAsync();
            await Task.Delay(3000);
            var chomeProcesses = Process.GetProcessesByName("chrome").Where(x => !string.IsNullOrWhiteSpace(x.MainWindowTitle)).ToList();

            var lParam = new IntPtr(0x0000_0000);
            foreach (var process in chomeProcesses)
            {
                var callback = new WNDENUMPROC((x, y) =>
                {
                    if (process.MainWindowHandle == User32.GetParent(x) &&
                        User32.GetWindowText(x) == "Open")
                    {
                        User32.SendMessage(x, User32.WindowMessage.WM_CHAR, new IntPtr('h'), lParam);
                        return false;
                    }
                    return true;
                });
                User32.EnumWindows(callback, IntPtr.Zero);

                //User32.SendMessage(process.MainWindowHandle, User32.WindowMessage.WM_CHAR, new IntPtr('K'), lParam);
                //
                //int ct = 0;
                //IntPtr prevChild = IntPtr.Zero;
                //IntPtr currChild = IntPtr.Zero;
                //while (true && ct < 10)
                //{
                //    currChild = PInvoke.User32.FindWindowEx(process.MainWindowHandle, prevChild, "#32770", null);
                //    if (currChild == IntPtr.Zero) break;
                //    //var info = new PInvoke.User32.WINDOWINFO();
                //    string childTitle = PInvoke.User32.GetWindowText(currChild);
                //    User32.SendMessage(currChild, User32.WindowMessage.WM_CHAR, new IntPtr('h'), lParam);
                //
                //    //if (PInvoke.User32.GetWindowInfo(currChild, ref info))
                //    //{
                //    //
                //    //}
                //    //result.Add(currChild);
                //    prevChild = currChild;
                //    ++ct;
                //}
            }

            await Task.Delay(300);
            await page.Keyboard.TypeAsync("test");
            //await tcs.Task;

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
                
                //await e.SetFilesAsync(new FilePayload
                //{
                //    Name = Path.GetFileName(filePath),
                //    MimeType = GetMimeType(filePath),
                //    //Buffer = await base64Encode
                //});
                tcs.TrySetResult(0);
            }
        }

        private static bool TestCallbase(IntPtr hwnd, IntPtr lParam)
        {
            return true;
        }

        private static async Task<string> Base64Encode(string filePath)
        {
            using FileStream inputFile = new(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, bufferSize: 1024 * 1024, useAsync: false);
            using CryptoStream base64Stream = new(inputFile, new ToBase64Transform(), CryptoStreamMode.Read);
            
            using var sr = new StreamReader(base64Stream, bufferSize: 1024 * 1024);
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
