using Microsoft.Playwright;

namespace StreamingTools.YouTube;

public class YouTubeBrowser
{
    private int _Counter;
    private string? Username { get; }
    private string? Password { get; }
    private string? RecoveryEmail { get; }
    private string? TwoFactorCallbackUrl { get; }
    private HttpClient HttpClient { get; }

    public YouTubeBrowser(HttpClient httpClient)
    {
        HttpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
    }

    public YouTubeBrowser(string username, string password, string recoveryEmail, string twoFactorCallbackUrl, HttpClient httpClient)
        : this(httpClient)
    {
        Username = username ?? throw new ArgumentNullException(nameof(username));
        Password = password ?? throw new ArgumentNullException(nameof(password));
        RecoveryEmail = recoveryEmail ?? throw new ArgumentNullException(nameof(recoveryEmail));
        TwoFactorCallbackUrl = twoFactorCallbackUrl ?? throw new ArgumentNullException(nameof(twoFactorCallbackUrl));
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

        //await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions() { Headless = false });
        await using var browser = await playwright.Chromium.LaunchPersistentContextAsync("C:\\Users\\kitok\\AppData\\Local\\Microsoft\\Edge\\User Data\\Profile 2", new BrowserTypeLaunchPersistentContextOptions()
        {
            Channel = "msedge",
            Headless = false,
        });

        var page = await browser.NewPageAsync();
        try
        {
            await page.GotoAsync("https://studio.youtube.com/");

            if (Username is not null &&
                Password is not null &&
                RecoveryEmail is not null &&
                TwoFactorCallbackUrl is not null)
            {
                await PerformLogin(page);
                await HandleRecoveryPrompts(page);
            }
            else
            {
                Console.WriteLine("Waiting for manual login...");
                await page.WaitForSelectorAsync("#avatar-btn", new()
                {
                    Timeout = 5 * 60 * 1_000
                });
                Console.WriteLine("Login complete");

            }

            await page.ClickAsync("#avatar-btn");
            await page.ClickAsync(":text('Switch account')");
            await page.ClickAsync(":text('Kevin Bost')");
            Console.WriteLine("Switched account");

            await page.ClickAsync("ytcp-icon-button[aria-label*=\"Upload videos\"]");

            int fileAddedAttempt = 0;
            do
            {
                await CaptureStateAsync(page, $"Upload click{fileAddedAttempt}");
                await page.ClickAsync("#dialog :text('Select files')");
            } while (!await AddFileToOpenFileDialog(page, file) && ++fileAddedAttempt < 3);


            //Set video details
            Console.WriteLine("Setting video details");

            var titleRequired = await page.WaitForSelectorAsync(":text('Title (required)')");
            await Task.Delay(500);
            await page.FillAsync("#dialog #textbox[aria-label*=\"Add a title that describes your video\"]", title);
            await page.FillAsync("#dialog #textbox[aria-label*=\"Tell viewers about your video\"]", description);
            await page.ClickAsync("#dialog span.ytcp-text-dropdown-trigger:has-text('Select')");
            foreach (var playlist in playlists)
            {
                await page.ClickAsync($"#dialog ytcp-ve li.ytcp-checkbox-group:has-text('{playlist}')");
            }
            await page.ClickAsync("#dialog ytcp-button.done-button[label=\"Done\"]");

            //Add tags
            await page.ClickAsync("#dialog button[aria-label=\"Show advanced settings\"]");
            await page.FillAsync("#dialog input[aria-label=\"Tags\"]", string.Join(',', tags));

            await page.ClickAsync("#dialog #recorded-date");

            const string dataInputSelector = "#dialog tp-yt-paper-input[aria-label*=\"Enter date\"]";
            await page.PressAsync($"{dataInputSelector} >> input", "Control+a", new() { Timeout = 10_000 });

            await page.FillAsync(dataInputSelector + " input", $"{recordingDate:MM/dd/yyyy}");
            await page.PressAsync($"{dataInputSelector} >> input", "Escape");

            await page.ClickAsync("#dialog #location >> input");
            await page.FillAsync("#dialog #location >> input", "Spokane WA");
            await page.ClickAsync("#dialog tp-yt-paper-item:has-text('Spokane WA')");

            await Task.Delay(1_000);

            await ClickNextButton(page);

            //Set Monetization On
            Console.WriteLine("Setting Monetization");
            await page.ClickAsync("#dialog ytcp-video-monetization");
            await page.ClickAsync("#dialog tp-yt-paper-radio-button:has-text('On')");
            await page.ClickAsync("#dialog #save-button");
            await Task.Delay(500);

            await ClickNextButton(page);

            //Set self-assigned rating
            Console.WriteLine("Setting self-assigned rating");

            await page.ClickAsync("#dialog ytcp-checkbox-lit:has-text('None of the above')");
            await page.ClickAsync("#dialog ytcp-button:has-text('Submit rating')");
            await Task.Delay(500);


            //Make private
            //Click to the end
            while (await page.QuerySelectorAsync("#dialog #next-button") is { } nextButton &&
                await nextButton.IsVisibleAsync())
            {
                await nextButton.ClickAsync(new()
                {
                    Force = true
                });
            }
            Console.WriteLine("Make private");
            await page.ClickAsync("#dialog tp-yt-paper-radio-button[name=\"PRIVATE\"]");


            Console.WriteLine("Waiting for done button");
            await WaitFor(() => page.IsEnabledAsync("#dialog #done-button"));

            Console.WriteLine("Waiting for upload to complete");
            await WaitFor(async () =>
            {
                string statusText = await page.InnerTextAsync("#dialog span.ytcp-video-upload-progress");
                return !statusText.Contains("Uploading");
            }, TimeSpan.FromHours(2));

            string youtubeLink = await page.InnerTextAsync("#dialog span.ytcp-video-info");
            Console.WriteLine($"Got YouTube link {youtubeLink}");

            await page.ClickAsync("#dialog #done-button");

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

    private static Task ClickNextButton(IPage page)
        => ClickFirstAsync(page, "#dialog #next-button", "#dialog :text('Next')");

    private static async Task ClickFirstAsync(IPage page, params string[] selectors)
    {
        foreach (var selector in selectors)
        {
            IElementHandle? element = await page.QuerySelectorAsync(selector);
            if (await TryWaitFor(async () =>
            {
                element ??= await page.QuerySelectorAsync(selector);
                return element is not null && await element.IsVisibleAsync() && await element.IsEnabledAsync();
            }))
            {
                try
                {
                    await element!.ClickAsync();
                    return;
                }
                catch (PlaywrightException)
                { }
                catch (TimeoutException)
                { }
            }
        }
        throw new Exception($"Failed to click on any of the selectors {string.Join(", ", selectors)}");
    }

    private static async Task<bool> AddFileToOpenFileDialog(IPage page, FileInfo file)
    {
        string windowTitle = await page.TitleAsync();

        var browserProcess = Process.GetProcesses()
            .Where(x => x.MainWindowTitle.Contains(windowTitle)).ToList();
        await Task.Delay(2000);
        bool fileAdded = false;
        //foreach (var process in browserProcess)
        //{
        //    var callback = new User32.WNDENUMPROC((x, y) =>
        //    {
        //        if (process.MainWindowHandle == User32.GetParent(x) &&
        //            User32.GetWindowText(x) == "Open")
        //        {
        //            Keyboard.Type(file.FullName);
        //            Keyboard.Press(VirtualKeyShort.ENTER);
        //            fileAdded = true;
        //            return false;
        //        }
        //        return true;
        //    });
        //    User32.EnumWindows(callback, IntPtr.Zero);
        //}
        return fileAdded;
    }

    public async Task PerformLogin(IPage page)
    {
        Console.WriteLine("Performing login");
        await page.FillAsync("input[type=\"email\"]", Username!);
        await page.ClickAsync(":text('Next')");
        await page.WaitForSelectorAsync("input[type=\"password\"]");
        await page.FillAsync("input[type=\"password\"]", Password!);
        await page.ClickAsync(":text('Next')");
        await page.WaitForURLAsync("**/challenge/ipp?*");
    }

    public async Task HandleRecoveryPrompts(IPage page)
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
                    !string.Equals(RecoveryEmail, await email.InnerTextAsync()))
                {
                    Console.WriteLine($"  - Verifying email");
                    await CaptureStateAsync(page, "EnterRecoveryEmail");
                    await page.FillAsync("input[type=\"email\"]", RecoveryEmail!);
                    await page.ClickAsync(":text('Next')");
                    await CaptureStateAsync(page, "ExitRecoveryEmail");
                    emailVerified = true;
                }
                if (emailVerified == clickedConfirm &&
                    await page.QuerySelectorAsync(":text('Get a verification code at')") is { } textPhone)
                {
                    await CaptureStateAsync(page, "FoundPhoneStart");
                    await textPhone.ClickAsync(new() { Delay = 100 });
                    string? code = await Get2FACode();
                    if (code is not null)
                    {
                        await page.FillAsync("input[aria-label*=\"Enter the code\"]", code);
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
                        await page.FillAsync("input[aria-label*=\"Enter the code\"]", code);
                        await page.ClickAsync(":text('Next')");
                    }
                    await CaptureStateAsync(page, "Auto2FAEnd");
                }
                if (await page.QuerySelectorAsync(":text('Not now')") is { } notNow)
                {
                    await notNow.ClickAsync();
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
                        code = null;
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

        await File.WriteAllTextAsync(Path.Combine(directory, $"{count}{identifier}.htm"), await page.ContentAsync());
        byte[] imageBytes = await page.ScreenshotAsync();
        await File.WriteAllBytesAsync(Path.Combine(directory, $"{count}{identifier}.png"), imageBytes);
    }

    private async Task<string> Get2FACodeAsync()
        => await HttpClient.GetStringAsync(TwoFactorCallbackUrl);

    private static async Task<bool> TryWaitFor(Func<Task<bool>> condition, TimeSpan? timeout = null)
    {
        timeout ??= TimeSpan.FromSeconds(30);
        var sw = Stopwatch.StartNew();
        bool state;
        while (!(state = await condition()) && sw.Elapsed < timeout)
        { }
        return state;
    }

    private static async Task WaitFor(Func<Task<bool>> condition, TimeSpan? timeout = null)
    {
        if (!(await TryWaitFor(condition, timeout)))
        {
            throw new TimeoutException("Failed timeout while waiting for condition");
        }
    }
}
