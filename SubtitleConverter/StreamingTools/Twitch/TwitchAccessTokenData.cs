using System.Text.Json.Serialization;

namespace StreamingTools.Twitch
{
    public record TwitchAccessTokenData([property: JsonPropertyName("videoPlaybackAccessToken")] VideoPlaybackAccessToken? Token)
    {

    }
}
