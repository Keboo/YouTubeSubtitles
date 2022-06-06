using Azure.Data.Tables;

namespace StreamingTools.Azure;

public class VideoRow
{
    private TableEntity TableEntity { get; }

    public VideoRow(TableEntity tableEntity)
    {
        TableEntity = tableEntity;
    }

    public string TwitchVideoId
    {
        get => TableEntity.RowKey;
        set => TableEntity.RowKey = value;
    }
    public DateTime TwitchPublishedAt 
    {
        get => (DateTime)TableEntity[nameof(TwitchPublishedAt)];
        set => TableEntity[nameof(TwitchPublishedAt)] = value;
    }
    public string? YouTubeVideoId
    {
        get => (string?)TableEntity[nameof(YouTubeVideoId)];
        set => TableEntity[nameof(YouTubeVideoId)] = value;
    }
    public string? SubtitlesUrl
    {
        get => (string?)TableEntity[nameof(SubtitlesUrl)];
        set => TableEntity[nameof(SubtitlesUrl)] = value;
    }
}
