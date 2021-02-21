using Google.Apis.YouTube.v3;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DownloadSubtitle
{
    public static class DownloadSubtitle
    {
        private const string Prefix = "GoogleSubtitleConverter";

        [FunctionName("DownloadSubtitle")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            string videoId = req.Query["videoId"];
            if (string.IsNullOrWhiteSpace(videoId))
            {
                return new BadRequestObjectResult("videoId is required");
            }
            log.LogInformation($"Looking up subtitles for {videoId}");

            using (YouTubeService service = await YouTube.GetService(Prefix))
            {
                string captions = await GetSrtCaptions(videoId, service);

                if (string.IsNullOrWhiteSpace(captions))
                {
                    return new NotFoundResult();
                }
                return new OkObjectResult(captions);
            }
        }

        private static async Task<string> GetSrtCaptions(string videoId, YouTubeService service)
        {
            var captionRequest = service.Captions.List("id", videoId);
            var response = await captionRequest.ExecuteAsync(CancellationToken.None);
            var captionItem = response.Items.FirstOrDefault();
            var captionId = captionItem?.Id;

            if (!string.IsNullOrEmpty(captionId))
            {

                CaptionsResource.DownloadRequest downloadRequest = service.Captions.Download(captionId);
                downloadRequest.Tfmt = CaptionsResource.DownloadRequest.TfmtEnum.Srt;
                string srtCaptions = await downloadRequest.ExecuteAsync();
                return srtCaptions;
            }

            return null;
        }

    }
}
