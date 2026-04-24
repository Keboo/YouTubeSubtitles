using System.Text;

namespace Tests.YouTube;

public class YouTubePlaylistCommandTests
{
    private static readonly SemaphoreSlim ConsoleLock = new(1, 1);

    [Fact]
    public async Task PlaylistCommand_WithInvalidDateRange_ReturnsErrorBeforeAuth()
    {
        var (exitCode, output) = await RunProgramAsync(
            "youtube", "playlist",
            "--name", "Test Playlist",
            "--from", "2024-02-01",
            "--to", "2024-01-31");

        Assert.Equal(1, exitCode);
        Assert.Contains("must be on or after the start date", output);
    }

    [Fact]
    public async Task PlaylistCommand_Help_ShowsExpectedOptions()
    {
        var (exitCode, output) = await RunProgramAsync(
            "youtube", "playlist", "--help");

        Assert.Equal(0, exitCode);
        Assert.Contains("--name", output);
        Assert.Contains("--from", output);
        Assert.Contains("--to", output);
    }

    private static async Task<(int ExitCode, string Output)> RunProgramAsync(params string[] args)
    {
        await ConsoleLock.WaitAsync();
        try
        {
            var builder = new StringBuilder();
            using var writer = new StringWriter(builder);

            TextWriter originalOut = Console.Out;
            try
            {
                Console.SetOut(writer);
                int exitCode = await Keboo.Editor.Program.Main(args);
                await writer.FlushAsync();
                return (exitCode, builder.ToString());
            }
            finally
            {
                Console.SetOut(originalOut);
            }
        }
        finally
        {
            ConsoleLock.Release();
        }
    }
}
