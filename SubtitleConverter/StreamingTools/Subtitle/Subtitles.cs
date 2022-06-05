using StreamingTools.Azure;
using StreamingTools.Git;

namespace StreamingTools.Subtitle;

public static class Subtitles
{
    public static string ConvertSrtToMarkdown(string youtubeVideoId, string srtCaptions)
    {
        string videoUrl = $"https://youtu.be/{youtubeVideoId}";
        srtCaptions = Regex.Replace(srtCaptions, @"^(\d+)\s*$", "", RegexOptions.Multiline);
        srtCaptions = Regex.Replace(srtCaptions, @"(?<=^)((\d+):(\d+):(\d+)[\d:,]* --> [\d:,]+)\s*\r?\n([^\r\n]+)", $"[$5]({videoUrl}?t=$2h$3m$4s)\r\n", RegexOptions.Multiline);
        srtCaptions = Regex.Replace(srtCaptions, @"\n+", "\n\n", RegexOptions.Multiline);
        srtCaptions = $"[YouTube Video]({videoUrl})\r\n\r\n" + srtCaptions;
        return srtCaptions;
    }

    public static async Task<Uri?> GetMarkdownUrl(VideoRow videoRow, CancellationToken token)
    {
        if (videoRow.YouTubeVideoId is null)
        {
            throw new ArgumentException("Video row does not have a YouTube video id", nameof(videoRow));
        }
        string fileName = GetMarkdownFileName(videoRow.YouTubeVideoId, videoRow.TwitchPublishedAt);
        string branchName = (await GitHelper.GetCurrentBranchName(token)) ?? "main";

        if (await GitHelper.GetRemoteUrl(token) is { } remoteUrl)
        {
            //TODO: Outut directory is currently hard coded to match workflow
            return new Uri(remoteUrl, $"blob/{branchName}/Subtitles/{fileName}");
        }
        return null;
    }

    public static string GetMarkdownFileName(string youtubeVideoId, DateTime date)
    {
        string fileName = SanitizeFileName($"{date:yyyy-MM-dd}-{youtubeVideoId}") + ".md";

        return fileName;

        static string SanitizeFileName(string fileName)
        {
            foreach (var invalidChar in Path.GetInvalidFileNameChars())
            {
                fileName = fileName.Replace(invalidChar.ToString(), "");
            }
            return fileName;
        }
    }
}
