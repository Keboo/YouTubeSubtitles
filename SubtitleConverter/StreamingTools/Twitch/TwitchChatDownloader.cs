using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace StreamingTools.Twitch;

public class TwitchChatDownloader
{
    private readonly HttpClient _httpClient;
    private const string TwitchClientId = "kimne78kx3ncx6brgo4mv6wki5h1ko";
    private const string CommentsQueryHash = "b70a3591ff0f4e0313d126c6a1502d79a1c02baebb288227c582044aa76adf6a";

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
        if (string.IsNullOrWhiteSpace(videoId))
            throw new ArgumentException("Video ID cannot be null or empty", nameof(videoId));
        if (string.IsNullOrWhiteSpace(username))
            throw new ArgumentException("Username cannot be null or empty", nameof(username));

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
            var variables = cursor == null
                ? new Dictionary<string, object> { ["videoID"] = videoId, ["contentOffsetSeconds"] = 0 }
                : new Dictionary<string, object> { ["videoID"] = videoId, ["cursor"] = cursor };
            var body = new Dictionary<string, object>
            {
                ["operationName"] = "VideoCommentsByOffsetOrCursor",
                ["variables"] = variables,
                ["extensions"] = new Dictionary<string, object>
                {
                    ["persistedQuery"] = new Dictionary<string, object>
                    {
                        ["version"] = 1,
                        ["sha256Hash"] = CommentsQueryHash
                    }
                }
            };

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://gql.twitch.tv/gql"),
                Content = new StringContent(JsonSerializer.Serialize(body), System.Text.Encoding.UTF8, "application/json")
            };
            request.Headers.Add("Client-ID", TwitchClientId);

            var response = await _httpClient.SendAsync(request);
            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine($"Failed to download chat for video {videoId}: {response.StatusCode}");
                break;
            }

            var content = await response.Content.ReadAsStringAsync();
            var comments = JsonSerializer.Deserialize<TwitchGqlResponse>(content)?.Data?.Video?.Comments;
            if (comments?.Edges == null || comments.Edges.Count == 0)
                break;

            string? nextCursor = null;
            foreach (var edge in comments.Edges)
            {
                nextCursor = edge.Cursor ?? nextCursor;
                var node = edge.Node;
                if (node == null) continue;
                allMessages.Add(new ChatMessage
                {
                    Username = node.Commenter?.Login ?? node.Commenter?.DisplayName ?? "",
                    Message = string.Concat(node.Message?.Fragments?.Select(f => f.Text) ?? [])
                });
            }

            cursor = comments.PageInfo?.HasNextPage == true ? nextCursor : null;

        } while (cursor != null);

        return allMessages;
    }

    private static List<string> ExtractUrls(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return [];

        // Regex to match URLs (http, https, and www patterns)
        // Using a timeout to prevent ReDoS attacks
        var urlPattern = @"https?://[^\s]+|www\.[^\s]+";
        var matches = Regex.Matches(text, urlPattern, RegexOptions.IgnoreCase, TimeSpan.FromSeconds(1));

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

    private class TwitchGqlResponse
    {
        [JsonPropertyName("data")]
        public GqlData? Data { get; set; }
    }

    private class GqlData
    {
        [JsonPropertyName("video")]
        public GqlVideo? Video { get; set; }
    }

    private class GqlVideo
    {
        [JsonPropertyName("comments")]
        public GqlComments? Comments { get; set; }
    }

    private class GqlComments
    {
        [JsonPropertyName("edges")]
        public List<GqlEdge>? Edges { get; set; }

        [JsonPropertyName("pageInfo")]
        public GqlPageInfo? PageInfo { get; set; }
    }

    private class GqlPageInfo
    {
        [JsonPropertyName("hasNextPage")]
        public bool HasNextPage { get; set; }
    }

    private class GqlEdge
    {
        [JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        [JsonPropertyName("node")]
        public GqlNode? Node { get; set; }
    }

    private class GqlNode
    {
        [JsonPropertyName("commenter")]
        public GqlCommenter? Commenter { get; set; }

        [JsonPropertyName("message")]
        public GqlMessage? Message { get; set; }
    }

    private class GqlCommenter
    {
        [JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        [JsonPropertyName("login")]
        public string? Login { get; set; }
    }

    private class GqlMessage
    {
        [JsonPropertyName("fragments")]
        public List<GqlFragment>? Fragments { get; set; }
    }

    private class GqlFragment
    {
        [JsonPropertyName("text")]
        public string? Text { get; set; }
    }
}
