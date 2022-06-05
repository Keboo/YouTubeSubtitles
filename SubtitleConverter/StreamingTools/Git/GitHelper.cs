namespace StreamingTools.Git;

public static class GitHelper
{
    public static async Task<Uri?> GetRemoteUrl(CancellationToken token)
    {
        ProcessStartInfo gitConfig = new()
        {
            FileName = "git",
            ArgumentList =
            {
                "config",
                "--get",
                "remote.origin.url"
            },
            RedirectStandardOutput = true
        };

        if (Process.Start(gitConfig) is { } process)
        {
            await process.WaitForExitAsync(token);
            string output = await process.StandardOutput.ReadToEndAsync();
            output = output.Trim();
            if (output.EndsWith(".git", StringComparison.InvariantCultureIgnoreCase))
            {
                output = output[..^4];
            }
            return new Uri(output + "/", UriKind.Absolute);
        }
        return null;
    }

    public static async Task<string?> GetCurrentBranchName(CancellationToken token)
    {
        ProcessStartInfo gitConfig = new()
        {
            FileName = "git",
            ArgumentList =
            {
                "branch",
                "--show-current"
            },
            RedirectStandardOutput = true
        };

        if (Process.Start(gitConfig) is { } process)
        {
            await process.WaitForExitAsync(token);
            string output = await process.StandardOutput.ReadToEndAsync();
            return output.Trim();
        }
        return null;
    }
}
