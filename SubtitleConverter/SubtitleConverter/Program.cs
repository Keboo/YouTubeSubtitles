using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using Microsoft.Azure.Cosmos.Table;
using Microsoft.Azure.Cosmos.Table.Queryable;
using Microsoft.Azure.Documents.Linq;
using Microsoft.Azure.Documents.SystemFunctions;
using Microsoft.Extensions.Configuration;
using StreamingTools.Azure;
using StreamingTools.YouTube;
using System;
using System.CommandLine;
using System.CommandLine.IO;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace SubtitleConverter
{
    class Program
    {
        /// <summary>
        /// Convert subtitles to markdown
        /// </summary>
        /// <param name="outputDirectory">The directory where markdown files should be created.</param>
        /// <param name="azureStorageAccountKey"></param>
        /// <param name="youTubeClientId"></param>
        /// <param name="youTubeClientSecret"></param>
        /// <param name="console"></param>
        /// <returns></returns>
        static async Task<int> Main(
            string outputDirectory = ".",
            string? azureStorageAccountKey = null,
            string? youTubeClientId = null,
            string? youTubeClientSecret = null,
            IConsole? console = null)
        {
            if (console is null) throw new ArgumentNullException(nameof(console));

            var configBuilder = new ConfigurationBuilder();
            configBuilder.AddEnvironmentVariables();
            configBuilder.AddUserSecrets(typeof(Program).Assembly);
            var config = configBuilder.Build();

            CloudStorageAccount storageAccount = StorageAccount.Get(azureStorageAccountKey, config);
            var tableClient = storageAccount.CreateCloudTableClient();
            var streamVideoTables = tableClient.GetTableReference("streamvideos");
            var youtubeSettingsTable = tableClient.GetTableReference("youtubesettings");

            YouTubeService youTubeService = await YouTubeFactory.GetServiceAsync(
                new CloudTableDataStore(youtubeSettingsTable),
                config,
                youTubeClientId,
                youTubeClientSecret,
                YouTubeService.Scope.Youtube, YouTubeService.Scope.YoutubeForceSsl);

            foreach (VideoRow row in streamVideoTables.CreateQuery<VideoRow>()
                    .Where(x => x.PartitionKey == "VideoConverter" &&
                           x.YouTubeVideoId != "" &&
                           x.YouTubeVideoId != "Unknown")
                    .Select(x => new VideoRow()
                    {
                        PartitionKey = x.PartitionKey,
                        RowKey = x.RowKey,
                        YouTubeVideoId = x.YouTubeVideoId,
                        TwitchPublishedAt = x.TwitchPublishedAt,
                        SubtitlesUrl = x.SubtitlesUrl
                    }))
            {
                if (!string.IsNullOrWhiteSpace(row.SubtitlesUrl)) continue;
                //TODO: Checks
                if (await youTubeService.GetSubtitles(row.YouTubeVideoId!, CancellationToken.None) is { } subtitles)
                {
                    string markdown = ConvertToMarkdown(row.YouTubeVideoId!, subtitles);
                    string fileName = await WriteToFile(outputDirectory, markdown, row.YouTubeVideoId!, row.TwitchPublishedAt);

                    row.SubtitlesUrl = $"https://github.com/Keboo/YouTubeSubtitles/blob/master/Subtitles/{fileName}";
                    TableOperation insertOperation = TableOperation.Merge(row);
                    TableResult _ = await streamVideoTables.ExecuteAsync(insertOperation);
                }
            }

            //if (string.IsNullOrEmpty(videoId) && string.IsNullOrEmpty(playlist))
            //{
            //    console.Error.WriteLine("Must specify either a video or a playlist");
            //    return 1;
            //}

            //if (!string.IsNullOrEmpty(subtitleUri) && !string.IsNullOrEmpty(videoId))
            //{
            //    string subtitles = await HttpClient.GetStringAsync(subtitleUri);
            //    var video = new Video(videoId, null, subtitles);
            //    ConvertVideoCaptions(video, outputDirectory, console);
            //    return 0;
            //}


            //DirectoryInfo cache = new(cacheDirectory);
            //cache.Create();
            //
            //if (!string.IsNullOrEmpty(playlist))
            //{
            //    string? nextPageToken = null;
            //    do
            //    {
            //        var playlistRequest = youTubeService.PlaylistItems.List("contentDetails");
            //        playlistRequest.PlaylistId = playlist;
            //        playlistRequest.PageToken = nextPageToken;
            //
            //        var playlistResponse = await playlistRequest.ExecuteAsync(CancellationToken.None);
            //        nextPageToken = playlistResponse.NextPageToken;
            //
            //        if (!playlistResponse.Items.Any())
            //        {
            //            console.Error.WriteLine($"Did not find any items in playlist {playlist}");
            //            return 1;
            //        }
            //
            //        foreach (PlaylistItem item in playlistResponse.Items)
            //        {
            //            await ConvertVideoCaptions(item.ContentDetails.VideoId, outputDirectory, youTubeService, console, cache);
            //        }
            //    } while (!string.IsNullOrEmpty(nextPageToken));
            //}
            //else if (!string.IsNullOrEmpty(videoId))
            //{
            //    await ConvertVideoCaptions(videoId, outputDirectory, youTubeService, console, cache);
            //}
            //else
            //{
            //    console.Error.WriteLine("No playlist or video specified");
            //    return 1;
            //}
            return 0;
        }

        private static string ConvertToMarkdown(string videoId, string srtCaptions)
        {
            string videoUrl = $"https://youtu.be/{videoId}";
            srtCaptions = Regex.Replace(srtCaptions, @"^(\d+)\s*$", "", RegexOptions.Multiline);
            srtCaptions = Regex.Replace(srtCaptions, @"(?<=^)((\d+):(\d+):(\d+)[\d:,]* --> [\d:,]+)\s*\r?\n([^\r\n]+)", $"[$5]({videoUrl}?t=$2h$3m$4s)\r\n", RegexOptions.Multiline);

            srtCaptions = $"[YouTube Video]({videoUrl})\r\n\r\n" + srtCaptions;
            return srtCaptions;
        }

        private static async Task<string> WriteToFile(string outputDirectory, string markdownContent, string videoId, DateTime date)
        {
            string fileName = SanitizeFileName($"{date:yyyy-MM-dd}-{videoId}") + ".md";
            var path = Path.Combine(Path.GetFullPath(outputDirectory), fileName);

            await File.WriteAllTextAsync(path, markdownContent);

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

        //private static async Task ConvertVideoCaptions(string videoId, string outputDirectory, YouTubeService service,
        //    IConsole console, DirectoryInfo cacheDirectory)
        //{
        //    console.Out.WriteLine($"Processing video {videoId}");
        //
        //    Video? video = await GetSubtitles(videoId, service, cacheDirectory);
        //    if (video != null)
        //    {
        //        ConvertVideoCaptions(video, outputDirectory, console);
        //    }
        //    else
        //    {
        //        console.Error.WriteLine("Failed to find captions");
        //    }
        //}

        //private static void ConvertVideoCaptions(Video video, string outputDirectory, IConsole console)
        //{
        //    string srtCaptions = video.Subtitles;
        //
        //    string videoUrl = $"https://youtu.be/{video.Id}";
        //    srtCaptions = Regex.Replace(srtCaptions, @"^(\d+)\s*$", "", RegexOptions.Multiline);
        //    srtCaptions = Regex.Replace(srtCaptions, @"(?<=^)((\d+):(\d+):(\d+)[\d:,]* --> [\d:,]+)\s*\r?\n([^\r\n]+)", $"[$5]({videoUrl}?t=$2h$3m$4s)\r\n", RegexOptions.Multiline);
        //    srtCaptions = $"[YouTube Video]({videoUrl})\r\n\r\n" + srtCaptions;
        //
        //    string fileName = video.Id;
        //    if (video.Prefix is string prefix)
        //    {
        //        fileName = $"{prefix}-{fileName}";
        //    }
        //
        //    fileName = SanitizeFileName(fileName);
        //    foreach (var invalidChar in Path.GetInvalidFileNameChars())
        //    {
        //        fileName = fileName.Replace(invalidChar.ToString(), "");
        //    }
        //
        //    fileName += ".md";
        //
        //    Directory.CreateDirectory(outputDirectory);
        //    string path = Path.GetFullPath(Path.Combine(outputDirectory, fileName));
        //    File.WriteAllText(path, srtCaptions);
        //    console.Out.WriteLine($"Wrote markdown to: {path}");
        //}
        //


        //private static async Task<Video?> GetSubtitles(string videoId, YouTubeService service, DirectoryInfo cacheDirectory)
        //{
        //    string fileName = SanitizeFileName(videoId);
        //    string path = Path.Combine(cacheDirectory.FullName, fileName);
        //
        //    if (File.Exists(path))
        //    {
        //        using var streamReader = new StreamReader(path);
        //        string? prefix = await streamReader.ReadLineAsync();
        //        string subtitles = await streamReader.ReadToEndAsync();
        //        return new Video(videoId, prefix, subtitles);
        //    }
        //
        //    var captionRequest = service.Captions.List("id", videoId);
        //    var response = await captionRequest.ExecuteAsync(CancellationToken.None);
        //    var captionItem = response.Items.FirstOrDefault();
        //    var captionId = captionItem?.Id;
        //
        //    if (!string.IsNullOrEmpty(captionId))
        //    {
        //        var videoDetailsRequest = service.Videos.List("snippet,recordingDetails");
        //        videoDetailsRequest.Id = videoId;
        //        var videoDetailsResponse = await videoDetailsRequest.ExecuteAsync();
        //
        //        CaptionsResource.DownloadRequest downloadRequest = service.Captions.Download(captionId);
        //        downloadRequest.Tfmt = CaptionsResource.DownloadRequest.TfmtEnum.Srt;
        //        string srtCaptions = await downloadRequest.ExecuteAsync();
        //
        //        const string DATE_FORMAT = "yyyy-MM-dd";
        //        string prefix =
        //            (videoDetailsResponse.Items.FirstOrDefault() is Google.Apis.YouTube.v3.Data.Video videoDetails)
        //                ? (videoDetails.RecordingDetails?.RecordingDate?.ToString(DATE_FORMAT) ??
        //                   videoDetails.Snippet?.PublishedAt?.ToString(DATE_FORMAT)) ?? ""
        //                : "";
        //        using var streamWriter = new StreamWriter(path);
        //        await streamWriter.WriteLineAsync(prefix);
        //        await streamWriter.WriteAsync(srtCaptions);
        //
        //        return new Video(videoId, prefix, srtCaptions);
        //    }
        //
        //    return null;
        //}

        private record Video(string Id, string? Prefix, string Subtitles)
        {
        }
    }
}
