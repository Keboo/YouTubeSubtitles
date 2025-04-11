using TwitchVideo = TwitchLib.Api.Helix.Models.Videos.GetVideos.Video;

namespace StreamingTools.Twitch;

public static class TwitchVideoExtensions
{
    public static DateTimeOffset? GetCreatedAt(this TwitchVideo video)
    {
        if (string.IsNullOrEmpty(video.CreatedAt))
            return null;
        if (DateTimeOffset.TryParse(video.CreatedAt, out DateTimeOffset createdAt))
        {
            return createdAt;
        }
        return null;
    }

    public static TimeSpan? GetDuration(this TwitchVideo video)
    {
        if (string.IsNullOrEmpty(video.Duration))
            return null;

        if (TimeSpan.TryParseExact(video.Duration, @"h\hm\ms\s", null, out TimeSpan duration))
        {
            return duration;
        }

        return null;
    }
}
