using System.Text.Json.Serialization;

namespace StreamingTools.Twitch
{
    public record TwichAccessToken([property: JsonPropertyName("data")] TwitchAccessTokenData? Data)
    {

    }
}
