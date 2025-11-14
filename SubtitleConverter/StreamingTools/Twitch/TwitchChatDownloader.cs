using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace StreamingTools.Twitch;

public class TwitchChatDownloader
{
    private readonly HttpClient _httpClient;
    private const string TwitchClientId = "kimne78kx3ncx6brgo4mv6wki5h1ko";

    public TwitchChatDownloader(HttpClient httpClient)
    {
        _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
    }

    /// <summary>
    /// Downloads chat messages for a Twitch VOD and extracts URLs from messages by a specific user.
    /// </summary>
    /// <param name="videoId">The Twitch video ID</param>
    /// <param name="username">The username to filter messages by (e.g., "kitokeboo")</param>
    /// <returns>A newline-delimited string of URLs found in the user's messages</returns>
    public async Task<string?> GetSharedLinksFromChatAsync(string videoId, string username)
    {
        var messages = await DownloadChatMessagesAsync(videoId);
        var userMessages = messages.Where(m => 
            string.Equals(m.Username, username, StringComparison.OrdinalIgnoreCase));
        
        var urls = new List<string>();
        foreach (var message in userMessages)
        {
            var extractedUrls = ExtractUrls(message.Message);
            urls.AddRange(extractedUrls);
        }

        return urls.Count > 0 ? string.Join(Environment.NewLine, urls.Distinct()) : null;
    }

    private async Task<List<ChatMessage>> DownloadChatMessagesAsync(string videoId)
    {
        var allMessages = new List<ChatMessage>();
        string? cursor = null;

        do
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://api.twitch.tv/v5/videos/{videoId}/comments{(cursor != null ? $"?cursor={cursor}" : "")}")
            };
            request.Headers.Add("Client-ID", TwitchClientId);
            request.Headers.Add("Accept", "application/vnd.twitchtv.v5+json");

            var response = await _httpClient.SendAsync(request);
            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine($"Failed to download chat for video {videoId}: {response.StatusCode}");
                break;
            }

            var content = await response.Content.ReadAsStringAsync();
            var chatResponse = JsonSerializer.Deserialize<TwitchChatResponse>(content);

            if (chatResponse?.Comments != null)
            {
                foreach (var comment in chatResponse.Comments)
                {
                    allMessages.Add(new ChatMessage
                    {
                        Username = comment.Commenter?.DisplayName ?? comment.Commenter?.Name ?? "",
                        Message = comment.Message?.Body ?? ""
                    });
                }
            }

            cursor = chatResponse?.Next;

        } while (cursor != null);

        return allMessages;
    }

    private static List<string> ExtractUrls(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return [];

        // Regex to match URLs (http, https, and www patterns)
        var urlPattern = @"https?://[^\s]+|www\.[^\s]+";
        var matches = Regex.Matches(text, urlPattern, RegexOptions.IgnoreCase);

        var urls = new List<string>();
        foreach (Match match in matches)
        {
            var url = match.Value.TrimEnd('.', ',', '!', '?', ')', ']', '}');
            urls.Add(url);
        }

        return urls;
    }

    private class ChatMessage
    {
        public string Username { get; set; } = "";
        public string Message { get; set; } = "";
    }

    private class TwitchChatResponse
    {
        [JsonPropertyName("comments")]
        public List<TwitchComment>? Comments { get; set; }

        [JsonPropertyName("_next")]
        public string? Next { get; set; }
    }

    private class TwitchComment
    {
        [JsonPropertyName("commenter")]
        public TwitchCommenter? Commenter { get; set; }

        [JsonPropertyName("message")]
        public TwitchCommentMessage? Message { get; set; }
    }

    private class TwitchCommenter
    {
        [JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }

    private class TwitchCommentMessage
    {
        [JsonPropertyName("body")]
        public string? Body { get; set; }
    }
}
