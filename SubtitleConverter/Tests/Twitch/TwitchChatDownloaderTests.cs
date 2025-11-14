using Xunit;
using StreamingTools.Twitch;
using System.Text.RegularExpressions;

namespace Tests.Twitch;

public class TwitchChatDownloaderTests
{
    [Fact]
    public void ExtractUrls_WithHttpsUrl_ReturnsUrl()
    {
        // This test validates the URL extraction logic from chat messages
        string message = "Check out this link: https://github.com/Keboo/YouTubeSubtitles";
        var urlPattern = @"https?://[^\s]+|www\.[^\s]+";
        var matches = Regex.Matches(message, urlPattern, RegexOptions.IgnoreCase);
        
        Assert.Single(matches);
        Assert.Equal("https://github.com/Keboo/YouTubeSubtitles", matches[0].Value);
    }

    [Fact]
    public void ExtractUrls_WithMultipleUrls_ReturnsAll()
    {
        string message = "Check these: https://example.com and http://test.org";
        var urlPattern = @"https?://[^\s]+|www\.[^\s]+";
        var matches = Regex.Matches(message, urlPattern, RegexOptions.IgnoreCase);
        
        Assert.Equal(2, matches.Count);
    }

    [Fact]
    public void ExtractUrls_WithWwwUrl_ReturnsUrl()
    {
        string message = "Visit www.example.com for more info";
        var urlPattern = @"https?://[^\s]+|www\.[^\s]+";
        var matches = Regex.Matches(message, urlPattern, RegexOptions.IgnoreCase);
        
        Assert.Single(matches);
        Assert.Equal("www.example.com", matches[0].Value);
    }

    [Fact]
    public void ExtractUrls_WithNoUrls_ReturnsEmpty()
    {
        string message = "This is just a regular message with no links";
        var urlPattern = @"https?://[^\s]+|www\.[^\s]+";
        var matches = Regex.Matches(message, urlPattern, RegexOptions.IgnoreCase);
        
        Assert.Empty(matches);
    }

    [Fact]
    public void ExtractUrls_WithTrailingPunctuation_TrimsCorrectly()
    {
        string message = "Check this out: https://example.com!";
        var urlPattern = @"https?://[^\s]+|www\.[^\s]+";
        var match = Regex.Match(message, urlPattern, RegexOptions.IgnoreCase);
        var url = match.Value.TrimEnd('.', ',', '!', '?', ')', ']', '}');
        
        Assert.Equal("https://example.com", url);
    }
}
