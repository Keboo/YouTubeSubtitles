using System.Net.Http.Headers;

namespace StreamingTools.Twitch;

public class Twitch
{
    private const string TwitchClientId = "kimne78kx3ncx6brgo4mv6wki5h1ko";

    private HttpClient HttpClient { get; }

    public Twitch(HttpClient httpClient)
    {
        HttpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
    }

    public async Task<FileInfo?> DownloadVideoFileAsync(string videoId)
    {
        VideoPlaybackAccessToken videoToken = await GetVideoPlaybackToken(HttpClient, videoId);

        string videoPlaylistUrl = await GetVideoPlaylistUrl(HttpClient, videoId, videoToken);

        return await DownloadVideoFile(videoId, videoPlaylistUrl);
    }

    private static async Task<FileInfo?> DownloadVideoFile(string videoId, string playlistUrl)
    {
        //Assumes ffmpeg is defined on the path
        DirectoryInfo directory = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), "VideoConverter"));
        FileInfo tempFile = new(Path.Combine(directory.FullName, $"{videoId}.mp4"));
        if (tempFile.Exists) return tempFile;
        var startInfo = new ProcessStartInfo
        {
            FileName = "ffmpeg",
            Arguments = $"-i {playlistUrl} -c copy -loglevel quiet -y \"{tempFile}\""
        };

        Console.WriteLine($"Running {startInfo.FileName} {startInfo.Arguments}");

        if (Process.Start(startInfo) is { } ffmpegProcess)
        {
            await ffmpegProcess.WaitForExitAsync(CancellationToken.None);
            return tempFile;
        }
        return null;
    }

    private static async Task<VideoPlaybackAccessToken> GetVideoPlaybackToken(HttpClient httpClient, string videoId)
    {
        var request = new HttpRequestMessage()
        {
            Content = new StringContent($$$"""
                {"operationName":"PlaybackAccessToken_Template","query":"query PlaybackAccessToken_Template($login: String!, $isLive: Boolean!, $vodID: ID!, $isVod: Boolean!, $playerType: String!) {  streamPlaybackAccessToken(channelName: $login, params: {platform: \"web\", playerBackend: \"mediaplayer\", playerType: $playerType}) @include(if: $isLive) {    value    signature    __typename  }  videoPlaybackAccessToken(id: $vodID, params: {platform: \"web\", playerBackend: \"mediaplayer\", playerType: $playerType}) @include(if: $isVod) {    value    signature    __typename  }}","variables":{"isLive":false,"login":"","isVod":true,"vodID":"{{{videoId}}}","playerType":"site"}}
                """),
            Method = HttpMethod.Post,
            RequestUri = new Uri("https://gql.twitch.tv/gql")
        };
        request.Headers.Add("Client-ID", TwitchClientId);
        HttpResponseMessage response = await httpClient.SendAsync(request);
        response.EnsureSuccessStatusCode();
        string responseContent = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<TwichAccessToken>(responseContent)?.Data?.Token ?? throw new InvalidOperationException("Failed to deserialize access token");
    }

    private static async Task<string> GetVideoPlaylistUrl(HttpClient httpClient, string videoId, VideoPlaybackAccessToken accessToken)
    {
        var request = new HttpRequestMessage()
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri($"https://usher.ttvnw.net/vod/{videoId}.m3u8?allow_source=true&player_backend=mediaplayer&playlist_include_framerate=true&reassignments_supported=true&sig={accessToken.Signature}&supported_codecs=avc1&token={Uri.UnescapeDataString(accessToken.Value)}&transcode_mode=cbr_v2&cdm=wv&player_version=1.18.0")
        };
        request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-mpegURL"));
        request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.apple.mpegurl"));
        request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("text/plain"));
        request.Headers.Add("Client-ID", TwitchClientId);
        HttpResponseMessage response = await httpClient.SendAsync(request);
        response.EnsureSuccessStatusCode();
        var lines = (await response.Content.ReadAsStringAsync()).Split('\n');
        for (int i = 0; i < lines.Length; i++)
        {
            if (lines[i].Contains("#EXT-X-MEDIA") && i < lines.Length - 2)
            {
                return lines[i + 2];
            }
        }
        return "";
    }
}
