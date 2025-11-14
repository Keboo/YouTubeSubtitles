using Xunit;
using StreamingTools.Data;
using StreamingTools.YouTube;

namespace Tests.YouTube;

public class DescriptionTests
{
    [Fact]
    public void Build_WithSharedLinks_IncludesLinksInDescription()
    {
        // Arrange
        var video = new Video
        {
            Id = 1,
            TwitchId = "12345",
            TwitchTitle = "Test Stream",
            TwitchDescription = "A test stream",
            TwitchStartTime = DateTimeOffset.UtcNow,
            SharedLinks = "https://github.com/Keboo/YouTubeSubtitles\nhttps://example.com"
        };

        // Act
        string description = Description.Build(video);

        // Assert
        Assert.Contains("Links shared during stream:", description);
        Assert.Contains("https://github.com/Keboo/YouTubeSubtitles", description);
        Assert.Contains("https://example.com", description);
    }

    [Fact]
    public void Build_WithoutSharedLinks_DoesNotIncludeLinksSection()
    {
        // Arrange
        var video = new Video
        {
            Id = 1,
            TwitchId = "12345",
            TwitchTitle = "Test Stream",
            TwitchDescription = "A test stream",
            TwitchStartTime = DateTimeOffset.UtcNow,
            SharedLinks = null
        };

        // Act
        string description = Description.Build(video);

        // Assert
        Assert.DoesNotContain("Links shared during stream:", description);
    }

    [Fact]
    public void Build_WithEmptySharedLinks_DoesNotIncludeLinksSection()
    {
        // Arrange
        var video = new Video
        {
            Id = 1,
            TwitchId = "12345",
            TwitchTitle = "Test Stream",
            TwitchDescription = "A test stream",
            TwitchStartTime = DateTimeOffset.UtcNow,
            SharedLinks = ""
        };

        // Act
        string description = Description.Build(video);

        // Assert
        Assert.DoesNotContain("Links shared during stream:", description);
    }

    [Fact]
    public void Build_WithWhitespaceSharedLinks_DoesNotIncludeLinksSection()
    {
        // Arrange
        var video = new Video
        {
            Id = 1,
            TwitchId = "12345",
            TwitchTitle = "Test Stream",
            TwitchDescription = "A test stream",
            TwitchStartTime = DateTimeOffset.UtcNow,
            SharedLinks = "   "
        };

        // Act
        string description = Description.Build(video);

        // Assert
        Assert.DoesNotContain("Links shared during stream:", description);
    }

    [Fact]
    public void GetDetails_ReturnsCorrectStructure()
    {
        // Arrange
        var video = new Video
        {
            Id = 1,
            TwitchId = "12345",
            TwitchTitle = "C# Programming Stream",
            TwitchDescription = "Testing C# features",
            TwitchStartTime = DateTimeOffset.Parse("2024-01-15"),
            SharedLinks = "https://docs.microsoft.com/dotnet"
        };

        // Act
        var details = Description.GetDetails(video);

        // Assert
        Assert.Equal("C# Programming Stream", details.Title);
        Assert.Contains("https://docs.microsoft.com/dotnet", details.Description);
        Assert.Contains("Links shared during stream:", details.Description);
        Assert.Contains("C#", details.Tags);
        Assert.Contains("programming", details.Tags);
    }
}
