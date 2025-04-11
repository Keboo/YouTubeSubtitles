namespace StreamingTools.Data;

public class Video : BaseEntity
{
    public string? TwitchId { get; set; }
    public DateTimeOffset? TwitchStartTime { get; set; }
    public TimeSpan? TwitchDuration { get; set; }
    public string? TwitchTitle { get; set; }
    public string? TwitchDescription { get; set; }
    public string? TwitchUrl { get; set; }


    public DateTimeOffset? YouTubePublishTime { get; set; }
    public string? YouTubeId { get; set; }


    public string? SubtitlesUrl { get; set; }
}
