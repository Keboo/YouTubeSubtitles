using StreamingTools.Azure;
using StreamingTools.Subtitle;

namespace Tests.Subtitle;

public class SubtitlesTests
{
    [Fact]
    public async Task GetMarkdownUrl_WithValidRow_GetFullyQualifiedUrl()
    {
        VideoRow row = new()
        {
            YouTubeVideoId = "nck3AW8R6eA",
            TwitchPublishedAt = new DateTime(2022, 4, 22)
        };
        Uri? uri = await Subtitles.GetMarkdownUrl(row, CancellationToken.None);
        Assert.NotNull(uri);
        Assert.Equal("https://github.com/Keboo/YouTubeSubtitles/blob/main/Subtitles/2022-04-22-nck3AW8R6eA.md", uri!.AbsoluteUri);
    }
}
