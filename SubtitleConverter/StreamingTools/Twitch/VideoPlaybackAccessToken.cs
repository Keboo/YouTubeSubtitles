using System.Text.Json.Serialization;

namespace StreamingTools.Twitch
{
    public record VideoPlaybackAccessToken(
        [property: JsonPropertyName("value")] string? Value,
        [property: JsonPropertyName("signature")] string? Signature)
    { }
}
