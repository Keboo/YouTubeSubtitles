using System;

using TwitchVideo = TwitchLib.Api.Helix.Models.Videos.GetVideos.Video;

namespace StreamingTools.Twitch;

public static class TwitchVideoMixins
{
    public static DateTime? GetRecordingDate(this TwitchVideo video)
    {
        if (video is null)
        {
            throw new ArgumentNullException(nameof(video));
        }
        if (!string.IsNullOrWhiteSpace(video.CreatedAt) &&
            DateTime.TryParse(video.CreatedAt, out DateTime rv))
        {
            return rv;
        }
        if (!string.IsNullOrWhiteSpace(video.PublishedAt) &&
            DateTime.TryParse(video.PublishedAt, out rv))
        {
            return rv;
        }
        return null;
    }
}
