using Microsoft.Azure.Cosmos.Table;
using System;

namespace VideoConverter
{
    public class VideoRow : TableEntity
    {
        public string TwitchVideoId 
        {
            get => RowKey;
            set => RowKey = value;
        }
        public DateTime TwitchPublishedAt { get; set; }
        public string? YouTubeVideoId { get; set; }
    }
}
