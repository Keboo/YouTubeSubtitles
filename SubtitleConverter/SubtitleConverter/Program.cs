using System;
using System.CommandLine;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.YouTube.v3.Data;

namespace SubtitleConverter
{
    class Program
    {
        /// <summary>
        /// Convert subtitles to markdown
        /// </summary>
        /// <param name="videoId">The id of the YouTube video.</param>
        /// <param name="playlist">The playlist of videos to convert.</param>
        /// <param name="outputDirectory">The directory where markdown files should be created.</param>
        /// <param name="console"></param>
        /// <returns></returns>
        static async Task Main(string videoId = "", string playlist = "", string outputDirectory = ".", IConsole console = null)
        {
            if (console == null) throw new ArgumentNullException(nameof(console));

            if (string.IsNullOrEmpty(videoId) && string.IsNullOrEmpty(playlist))
            {
                console.Error.WriteLine("Must specify either a video or a playlist");
                return;
            }

            UserCredential credential;
            using (var stream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                     // This OAuth 2.0 access scope allows for full read/write access to the
                     // authenticated user's account.
                    new[] { YouTubeService.Scope.YoutubeForceSsl, YouTubeService.Scope.Youtube },
                    "user",
                    CancellationToken.None,
                    new FileDataStore("auth_cache.json")
                );
            }

            var service = new YouTubeService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
                ApplicationName = "SubtitleConverter"
            });

            if (!string.IsNullOrEmpty(playlist))
            {
                var playlistRequest = service.PlaylistItems.List("contentDetails");
                playlistRequest.PlaylistId = playlist;
                var playlistResponse = await playlistRequest.ExecuteAsync(CancellationToken.None);

                if (!playlistResponse.Items.Any())
                {
                    console.Error.WriteLine($"Did not find any items in playlist {playlist}");
                    return;
                }

                foreach (PlaylistItem item in playlistResponse.Items)
                {
                    await ConvertVideoCaptions(item.ContentDetails.VideoId, outputDirectory, service, console);
                }
            }
            else if (!string.IsNullOrEmpty(videoId))
            {
                await ConvertVideoCaptions(videoId, outputDirectory, service, console);
            }
            else
            {
                console.Error.WriteLine("No playlist or video specified");
            }
            
        }

        private static async Task ConvertVideoCaptions(string videoId, string outputDirectory, YouTubeService service, IConsole console)
        {
            console.Out.WriteLine($"Processing video {videoId}");
            var captionRequest = service.Captions.List("id", videoId);
            var response = await captionRequest.ExecuteAsync(CancellationToken.None);
            var captionId = response.Items.FirstOrDefault()?.Id;

            if (!string.IsNullOrEmpty(captionId))
            {
                CaptionsResource.DownloadRequest downloadRequest = service.Captions.Download(captionId);
                downloadRequest.Tfmt = CaptionsResource.DownloadRequest.TfmtEnum.Srt;
                string srtCaptions = await downloadRequest.ExecuteAsync();

                //https://youtu.be/SNdczp6FZ2o?t=3759
                string videoUrl = $"https://youtu.be/{videoId}";
                srtCaptions = Regex.Replace(srtCaptions, @"^(\d+)\s*$", "", RegexOptions.Multiline);
                srtCaptions = Regex.Replace(srtCaptions, @"(?<=^)((\d+):(\d+):(\d+)[\d:,]* --> [\d:,]+)(?=\s*$)", $"[$1]({videoUrl}?t=$2h$3m$4s)\r\n", RegexOptions.Multiline);
                srtCaptions = $"[YouTube Video]({videoUrl})\r\n\r\n" + srtCaptions;

                string fileName = videoId;
                foreach (var invalidChar in Path.GetInvalidFileNameChars())
                {
                    fileName = fileName.Replace(invalidChar.ToString(), "");
                }

                fileName += ".md";

                string path = Path.GetFullPath(Path.Combine(outputDirectory, fileName));
                File.WriteAllText(path, srtCaptions);
                console.Out.WriteLine($"Wrote markdown to: {path}");
            }
            else
            {
                console.Error.WriteLine($"Failed to find captions");
            }
        }
    }
}
