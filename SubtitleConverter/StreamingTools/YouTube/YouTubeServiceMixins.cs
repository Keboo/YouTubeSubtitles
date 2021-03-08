using Google.Apis.YouTube.v3;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace StreamingTools.YouTube
{
    public static class YouTubeServiceMixins
    {
        public static async Task<string?> GetSubtitles(this YouTubeService service, string videoId, CancellationToken token)
        {
            var captionRequest = service.Captions.List("id", videoId);
            var response = await captionRequest.ExecuteAsync(token);
            var captionId = response.Items.FirstOrDefault()?.Id;

            if (!string.IsNullOrEmpty(captionId))
            {
                CaptionsResource.DownloadRequest downloadRequest = service.Captions.Download(captionId);
                downloadRequest.Tfmt = "srt";
                return await downloadRequest.ExecuteAsync(token);
            }

            return null;
        }

        public static async Task<string?> FindYouTubeId(this YouTubeService service, string title, )
    }
}
