using Microsoft.Azure.Cosmos.Table;

namespace StreamingTools.Azure;

public class VideoRow : TableEntity
{
    public string TwitchVideoId
    {
        get => RowKey;
        set => RowKey = value;
    }
    public DateTime TwitchPublishedAt { get; set; }
    public string? YouTubeVideoId { get; set; }
    public string? SubtitlesUrl { get; set; }
}
