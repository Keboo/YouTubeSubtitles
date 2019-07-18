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
        /// <param name="cacheDirectory">The directory subtitle files will be cached.</param>
        /// <param name="console"></param>
        /// <returns></returns>
        static async Task Main(string videoId = "", string playlist = "", 
            string outputDirectory = ".",
            string cacheDirectory = ".\\cache",
            IConsole console = null)
        {
            if (console == null) throw new ArgumentNullException(nameof(console));

            if (string.IsNullOrEmpty(videoId) && string.IsNullOrEmpty(playlist))
            {
                console.Error.WriteLine("Must specify either a video or a playlist");
                return;
            }

            DirectoryInfo cache = new DirectoryInfo(cacheDirectory);
            cache.Create();

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
                string nextPageToken = null;
                do
                {
                    var playlistRequest = service.PlaylistItems.List("contentDetails");
                    playlistRequest.PlaylistId = playlist;
                    playlistRequest.PageToken = nextPageToken;

                    var playlistResponse = await playlistRequest.ExecuteAsync(CancellationToken.None);
                    nextPageToken = playlistResponse.NextPageToken;

                    if (!playlistResponse.Items.Any())
                    {
                        console.Error.WriteLine($"Did not find any items in playlist {playlist}");
                        return;
                    }

                    foreach (PlaylistItem item in playlistResponse.Items)
                    {
                        await ConvertVideoCaptions(item.ContentDetails.VideoId, outputDirectory, service, console, cache);
                    }
                } while (!string.IsNullOrEmpty(nextPageToken));
            }
            else if (!string.IsNullOrEmpty(videoId))
            {
                await ConvertVideoCaptions(videoId, outputDirectory, service, console, cache);
            }
            else
            {
                console.Error.WriteLine("No playlist or video specified");
            }
            
        }

        private static async Task ConvertVideoCaptions(string videoId, string outputDirectory, YouTubeService service, IConsole console, DirectoryInfo cacheDirectory)
        {
            console.Out.WriteLine($"Processing video {videoId}");

            Video video = await GetSubtitles(videoId, service, cacheDirectory);
            if (video != null)
            {
                string srtCaptions = video.Subtitles;

                string videoUrl = $"https://youtu.be/{videoId}";
                srtCaptions = Regex.Replace(srtCaptions, @"^(\d+)\s*$", "", RegexOptions.Multiline);
                srtCaptions = Regex.Replace(srtCaptions, @"(?<=^)((\d+):(\d+):(\d+)[\d:,]* --> [\d:,]+)\s*\r?\n([^\r\n]+)", $"[$5]({videoUrl}?t=$2h$3m$4s)\r\n", RegexOptions.Multiline);
                srtCaptions = $"[YouTube Video]({videoUrl})\r\n\r\n" + srtCaptions;

                string fileName = videoId;
                if (video.Prefix is string prefix)
                {
                    fileName = $"{prefix}-{fileName}";
                }

                fileName = SanitizeFileName(fileName);
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
                console.Error.WriteLine("Failed to find captions");
            }
        }

        private static string SanitizeFileName(string fileName)
        {
            foreach (var invalidChar in Path.GetInvalidFileNameChars())
            {
                fileName = fileName.Replace(invalidChar.ToString(), "");
            }
            return fileName;
        }

        private static async Task<Video> GetSubtitles(string videoId, YouTubeService service, DirectoryInfo cacheDirectory)
        {
            string fileName = SanitizeFileName(videoId);
            string path = Path.Combine(cacheDirectory.FullName, fileName);

            if (File.Exists(path))
            {
                using (var streamReader = new StreamReader(path))
                {
                    string prefix = await streamReader.ReadLineAsync();
                    string subtitles = await streamReader.ReadToEndAsync();
                    return new Video(prefix, subtitles);
                }
            }

            var captionRequest = service.Captions.List("id", videoId);
            var response = await captionRequest.ExecuteAsync(CancellationToken.None);
            var captionItem = response.Items.FirstOrDefault();
            var captionId = captionItem?.Id;

            if (!string.IsNullOrEmpty(captionId))
            {
                var videoDetailsRequest = service.Videos.List("snippet,recordingDetails");
                videoDetailsRequest.Id = videoId;
                var videoDetailsResponse = await videoDetailsRequest.ExecuteAsync();

                CaptionsResource.DownloadRequest downloadRequest = service.Captions.Download(captionId);
                downloadRequest.Tfmt = CaptionsResource.DownloadRequest.TfmtEnum.Srt;
                string srtCaptions = await downloadRequest.ExecuteAsync();

                const string DATE_FORMAT = "yyyy-MM-dd";
                string prefix =
                    (videoDetailsResponse.Items.FirstOrDefault() is Google.Apis.YouTube.v3.Data.Video videoDetails)
                        ? (videoDetails.RecordingDetails?.RecordingDate?.ToString(DATE_FORMAT) ??
                           videoDetails.Snippet?.PublishedAt?.ToString(DATE_FORMAT)) ?? ""
                        : "";
                using (var streamWriter = new StreamWriter(path))
                {
                    await streamWriter.WriteLineAsync(prefix);
                    await streamWriter.WriteAsync(srtCaptions);
                }
                return new Video(prefix, srtCaptions);
            }

            return null;
        }

        private class Video
        {
            public Video(string prefix, string subtitles)
            {
                Prefix = prefix;
                Subtitles = subtitles;
            }

            public string Prefix { get; }
            public string Subtitles { get; }
        }
    }
}
