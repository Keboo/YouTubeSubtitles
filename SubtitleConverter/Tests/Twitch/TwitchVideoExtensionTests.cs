using StreamingTools.Twitch;
using TwitchVideo = TwitchLib.Api.Helix.Models.Videos.GetVideos.Video;

namespace Tests.Twitch;

public class TwitchVideoExtensionTests
{
    [Fact]
    public void CanParseCreatedAt()
    {
        var now = DateTimeOffset.UtcNow;
        
        TestableVideo video = new(createAt: now.ToString("O"));
        DateTimeOffset? createdAt = video.GetCreatedAt();
        Assert.Equal(now, createdAt);
    }

    [Fact]
    public void CanParseEmptyDuration()
    {
        TestableVideo video = new(duration: string.Empty);
        TimeSpan? duration = video.GetDuration();
        Assert.Null(duration);
    }

    [Fact]
    public void CanParseDuration()
    {
        TestableVideo video = new(duration: "3h8m44s");

        TimeSpan? duration = video.GetDuration();

        Assert.Equal(new TimeSpan(3, 8, 44), duration);
    }

    private class TestableVideo : TwitchVideo
    {
        public TestableVideo(string? duration = null, string? createAt = null)
        {
            Duration = duration;
            CreatedAt = createAt;
        }
    }
}
