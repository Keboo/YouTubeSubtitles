using Microsoft.Azure.Cosmos.Table;
using System;

namespace VideoConverter
{
    public class VideoRow : TableEntity
    {
        public string TwitchVideoId { get; set; }
        public DateTime TwitchPublishedAt { get; set; }
        public string YoutubeVideoId { get; set; }
    }
}
