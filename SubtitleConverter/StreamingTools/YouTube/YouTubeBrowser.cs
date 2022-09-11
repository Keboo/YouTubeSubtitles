﻿using FlaUI.Core.Input;
using FlaUI.Core.WindowsAPI;
using PlaywrightSharp;
using User32 = PInvoke.User32;

namespace StreamingTools.YouTube;

public class YouTubeBrowser
{
    private int _Counter;
    private string Username { get; }
    private string Password { get; }
    private string RecoveryEmail { get; }
    private string TwoFactorCallbackUrl { get; }
    private HttpClient HttpClient { get; }

    public YouTubeBrowser(string username, string password, string recoveryEmail, string twoFactorCallbackUrl, HttpClient httpClient)
    {
        Username = username ?? throw new ArgumentNullException(nameof(username));
        Password = password ?? throw new ArgumentNullException(nameof(password));
        RecoveryEmail = recoveryEmail ?? throw new ArgumentNullException(nameof(recoveryEmail));
        TwoFactorCallbackUrl = twoFactorCallbackUrl ?? throw new ArgumentNullException(nameof(twoFactorCallbackUrl));
        HttpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
    }

    public async Task<string> UploadAsync(
        FileInfo file,
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

            Console.WriteLine("Performing login");
            await page.TypeAsync("input[type=\"email\"]", Username);
            await page.ClickAsync(":text('Next')");
            await page.WaitForSelectorAsync("input[type=\"password\"]");
            await page.TypeAsync("input[type=\"password\"]", Password);
            var navTask = page.WaitForNavigationAsync();
            await page.ClickAsync(":text('Next')");

            await navTask;

            await HandleRecoveryPrompts(page);

            await page.ClickAsync("#avatar-btn");
            await page.ClickAsync(":text('Switch account')");
            await page.ClickAsync(":text('Kevin Bost')");
            Console.WriteLine("Switched account");

            await page.ClickAsync("ytcp-icon-button[aria-label*=\"Upload videos\"]");
            
            await page.ClickAsync("#select-files-button");

            await AddFileToOpenFileDialog(page, file);

            //Set video details
            Console.WriteLine("Setting video details");

            var titleRequired = await page.WaitForSelectorAsync(":text('Title (required)')");
            await Task.Delay(500);
            await page.TypeAsync("#textbox[aria-label*=\"Add a title that describes your video\"]", title);
            await page.TypeAsync("#textbox[aria-label*=\"Tell viewers about your video\"]", description);
            await page.ClickAsync("span.ytcp-text-dropdown-trigger:has-text('Select')");
            foreach (var playlist in playlists)
            {
                await page.ClickAsync($"ytcp-ve li.ytcp-checkbox-group:has-text('{playlist}')");
            }
            await page.ClickAsync("ytcp-button.done-button[label=\"Done\"]");
            await page.ClickAsync("div.ytcp-button:has-text('Show more')");
            await page.TypeAsync("input[aria-label=\"Tags\"]", string.Join(',', tags));

            await page.ClickAsync("#recorded-date");

            const string dataInputSelector = "tp-yt-paper-input[aria-label*=\"Enter date\"]";
            await page.PressAsync($"{dataInputSelector} >> input", "Control+a", timeout: 10_000);

            await page.TypeAsync(dataInputSelector, $"{recordingDate:MM/dd/yyyy}");
            await page.PressAsync($"{dataInputSelector} >> input", "Escape");

            await page.ClickAsync("#location >> input");
            await page.TypeAsync("#location >> input", "Spokane WA");
            await page.ClickAsync("tp-yt-paper-item:has-text('Spokane WA')");

            await Task.Delay(500);
            await page.ClickAsync("#next-button");
            

            //Set Monetization On
            Console.WriteLine("Setting Monetization");
            await page.ClickAsync("ytcp-video-monetization");
            await page.ClickAsync("tp-yt-paper-radio-button:has-text('On')");
            await page.ClickAsync("#save-button");
            await Task.Delay(500);
            await page.ClickAsync("#next-button");

            //Set self-assigned rating
            Console.WriteLine("Setting self-assigned rating");

            await page.ClickAsync("ytcp-checkbox-lit:has-text('None of the above')");
            await page.ClickAsync("ytcp-button:has-text('Submit rating')");
            await Task.Delay(500);

            while (await page.QuerySelectorAsync("#next-button") is { } nextButton &&
                await nextButton.IsVisibleAsync())
            {
                await nextButton.ClickAsync();
            }
            
            //Make private
            Console.WriteLine("Make private");
            await page.ClickAsync("tp-yt-paper-radio-button[name=\"PRIVATE\"]");


            Console.WriteLine("Waiting for done button");
            await WaitFor(() => page.IsEnabledAsync("#done-button"));
            
            Console.WriteLine("Waiting for upload to complete");
            await WaitFor(async () =>
            {
                string statusText = await page.GetInnerTextAsync("span.ytcp-video-upload-progress");
                return !statusText.Contains("Uploading");
            }, TimeSpan.FromHours(2));

            string youtubeLink = await page.GetInnerTextAsync("span.ytcp-video-info");
            Console.WriteLine($"Got YouTube link {youtubeLink}");

            await page.ClickAsync("#done-button");

            if (!string.IsNullOrWhiteSpace(youtubeLink) && Uri.TryCreate(youtubeLink, UriKind.Absolute, out Uri? url))
            {
                return url.Segments.Last();
            }

            return "";
        }
        catch (Exception)
        {
            await CaptureStateAsync(page, "Exception");
            throw;
        }
    }

    private static async Task AddFileToOpenFileDialog(IPage page, FileInfo file)
    {
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
                    Keyboard.Type(file.FullName);
                    Keyboard.Press(VirtualKeyShort.ENTER);
                    return false;
                }
                return true;
            });
            User32.EnumWindows(callback, IntPtr.Zero);
        }
    }

    private async Task HandleRecoveryPrompts(IPage page)
    {
        //Check for recovery prompts
        bool clickedConfirm = false;
        bool emailVerified = false;
        
        string previousCode = await Get2FACodeAsync();

        for (int i = 0; i < 300; i++)
        {
            Console.WriteLine($"  - Attempt {i}, Confirmed? {clickedConfirm}, Email Verified? {emailVerified}");
            try
            {
                if (await page.QuerySelectorAsync("#avatar-btn") is { } avatarButton)
                {
                    await CaptureStateAsync(page, "Done");
                    break;
                }
                if (!emailVerified && !clickedConfirm &&
                    await page.QuerySelectorAsync(":text('Confirm your recovery email')") is { } confirmEmailLink)
                {
                    await confirmEmailLink.ClickAsync();
                    clickedConfirm = true;
                }
                if (!emailVerified && clickedConfirm &&
                    await page.QuerySelectorAsync("input[type=\"email\"]") is { } email &&
                    !string.Equals(RecoveryEmail, await email.GetInnerTextAsync()))
                {
                    Console.WriteLine($"  - Verifying email");
                    await CaptureStateAsync(page, "EnterRecoveryEmail");
                    await page.TypeAsync("input[type=\"email\"]", RecoveryEmail);
                    await page.ClickAsync(":text('Next')");
                    await CaptureStateAsync(page, "ExitRecoveryEmail");
                    emailVerified = true;
                }
                if (emailVerified == clickedConfirm &&
                    await page.QuerySelectorAsync(":text('Get a verification code at')") is { } textPhone)
                {
                    await CaptureStateAsync(page, "FoundPhoneStart");
                    await textPhone.ClickAsync(delay: 100);
                    string? code = await Get2FACode();
                    if (code is not null)
                    {
                        await page.TypeAsync(":text('Enter the code')", code);
                        await page.ClickAsync(":text('Next')");
                    }
                    await CaptureStateAsync(page, "FoundPhoneEnd");
                }
                if (await page.QuerySelectorAsync(":text('A text message with a 6-digit verification code was just sent to')") is not null)
                {
                    await CaptureStateAsync(page, "Auto2FAStart");
                    
                    string? code = await Get2FACode();
                    if (code is not null)
                    {
                        await page.TypeAsync(":text('Enter the code')", code);
                        await page.ClickAsync(":text('Next')");
                    }
                    await CaptureStateAsync(page, "Auto2FAEnd");
                    
                }
            }
            catch (Exception)
            {
                await CaptureStateAsync(page, "RecoveryPromptsException");
            }
            await Task.Delay(TimeSpan.FromSeconds(1));

            async Task<string?> Get2FACode()
            {
                Console.WriteLine("  - Waiting for 2FA code");
                string? code = null;
                //Allow for some time (15 min) to actually make the call
                for (int attempt = 0; code is null || attempt < 15 * 60; attempt++)
                {
                    code = await Get2FACodeAsync();
                    if (string.Equals(code, previousCode))
                    {
                        Console.WriteLine("  - 2FA not recieved... waiting....");
                        await Task.Delay(TimeSpan.FromSeconds(1));
                        continue;
                    }
                    break;
                }
                Console.WriteLine(code is not null ? "  - Got 2FA code" : "  - 2FA code not recieved");
                return code;
            }
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

    private async Task<string> Get2FACodeAsync()
        => await HttpClient.GetStringAsync(TwoFactorCallbackUrl);

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
