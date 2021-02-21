using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Google.Apis.YouTube.v3;
using System.Linq;
using System.Collections.Generic;

namespace DownloadSubtitle
{
    public static class GetVideoTags
    {
        private const string Prefix = "GoogleSubtitleConverter";

        [FunctionName("GetVideoTags")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            string videoId = req.Query["videoId"];
            if (string.IsNullOrWhiteSpace(videoId))
            {
                return new BadRequestObjectResult("videoId is required");
            }
            log.LogInformation($"Looking up tags for {videoId}");

            using (YouTubeService service = await YouTube.GetService(Prefix))
            {
                var videoDetailsRequest = service.Videos.List("snippet");
                videoDetailsRequest.Id = videoId;
                var videoDetailsResponse = await videoDetailsRequest.ExecuteAsync();

                if (videoDetailsResponse.Items.FirstOrDefault() is Google.Apis.YouTube.v3.Data.Video videoDetails)
                {
                    string tags = "";
                    if (videoDetails.Snippet.Tags is IList<string> videoTags)
                    {
                        tags = string.Join(" ", videoTags.Select(x => $"#{CleanupTag(x)}"));
                    }
                    return new OkObjectResult(tags);
                }
                return new NotFoundResult();
            }
        }

        private static string CleanupTag(string tag)
        {
            return tag.Replace(" ", "").Replace("#", "Sharp");
        }
    }
}
