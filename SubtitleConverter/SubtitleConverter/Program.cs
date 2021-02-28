using Google.Apis.YouTube.v3;
using Microsoft.Azure.Cosmos.Table;
using Microsoft.Extensions.Configuration;
using StreamingTools.Azure;
using StreamingTools.YouTube;
using System;
using System.CommandLine;
using System.CommandLine.IO;
using System.IO;
using System.Linq;
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
        static async Task Main(
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
                           x.YouTubeVideoId != "Unknown"))
            {
                if (!string.IsNullOrWhiteSpace(row.SubtitlesUrl)) continue;
                console.Out.WriteLine($"Converting markdown for YouTube video '{row.YouTubeVideoId}'");
                if (await youTubeService.GetSubtitles(row.YouTubeVideoId!, CancellationToken.None) is { } subtitles)
                {
                    console.Out.WriteLine("  Got subtitles");
                    string markdown = ConvertToMarkdown(row.YouTubeVideoId!, subtitles);
                    string fileName = await WriteToFile(outputDirectory, markdown, row.YouTubeVideoId!, row.TwitchPublishedAt);
                    console.Out.WriteLine($"  Wrote markdown to '{fileName}'");

                    row.SubtitlesUrl = $"https://github.com/Keboo/YouTubeSubtitles/blob/master/Subtitles/{fileName}";
                    TableOperation insertOperation = TableOperation.Merge(row);
                    TableResult _ = await streamVideoTables.ExecuteAsync(insertOperation);
                    console.Out.WriteLine($"  Updated table storage with url '{row.SubtitlesUrl}'");
                }
            }
        }

        private static string ConvertToMarkdown(string videoId, string srtCaptions)
        {
            string videoUrl = $"https://youtu.be/{videoId}";
            srtCaptions = Regex.Replace(srtCaptions, @"^(\d+)\s*$", "", RegexOptions.Multiline);
            srtCaptions = Regex.Replace(srtCaptions, @"(?<=^)((\d+):(\d+):(\d+)[\d:,]* --> [\d:,]+)\s*\r?\n([^\r\n]+)", $"[$5]({videoUrl}?t=$2h$3m$4s)\r\n", RegexOptions.Multiline);
            srtCaptions = Regex.Replace(srtCaptions, @"\n+", "\n\n", RegexOptions.Multiline);
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

        private record Video(string Id, string? Prefix, string Subtitles)
        {
        }
    }
}
