using Microsoft.EntityFrameworkCore;
using StreamingTools.Data;
using StreamingTools.Twitch;
using System.CommandLine;
using TwitchLib.Api;
using TwitchLib.Api.Core;

using TwitchVideo = TwitchLib.Api.Helix.Models.Videos.GetVideos.Video;

namespace Keboo.Editor;

public class TwitchCommand : CliCommand
{
    private static CliOption<string> UserIdOption { get; } = new("--twitch-user-id")
    {
        DefaultValueFactory = _ => Environment.GetEnvironmentVariable("KebooTwitchUserId") ?? "",
        Required = true
    };

    private static CliOption<string> ClientIdOption { get; } = new("--twitch-client-id")
    {
        DefaultValueFactory = _ => Environment.GetEnvironmentVariable("KebooTwitchClientId") ?? "",
        Required = true
    };

    private static CliOption<string> ClientSecretOption { get; } = new("--twitch-client-secret")
    {
        DefaultValueFactory = _ => Environment.GetEnvironmentVariable("KebooTwitchClientSecret") ?? "",
        Required = true
    };

    private static CliOption<string> VideoIdOption { get; } = new("--twitch-video-id");
    private static CliOption<DirectoryInfo> OutputOption { get; } = new("--output")
    {
        DefaultValueFactory = _ => new DirectoryInfo(Path.Combine(Path.GetTempPath()))
    };
    public TwitchCommand()
        : base("twitch")
    {
        CliCommand twitchDownload = new("download")
        {
            UserIdOption,
            ClientIdOption,
            ClientSecretOption,
            VideoIdOption,
            OutputOption,
        };
        Add(twitchDownload);

        twitchDownload.SetAction(Download);
    }

    private static HttpClient HttpClient { get; } = new();

    public static Task Download(ParseResult ctx, CancellationToken token)
    {
        string? videoId = ctx.GetValue(VideoIdOption);
        if (!string.IsNullOrEmpty(videoId))
        {
            return DownloadSingleAsync(
                    ctx.GetValue(ClientIdOption)!,
                    ctx.GetValue(ClientSecretOption)!,
                    videoId,
                    ctx.GetValue(OutputOption)!
                );
        }
        else
        {
            return DownloadNewVideos(
                ctx.GetValue(ClientIdOption)!,
                ctx.GetValue(ClientSecretOption)!,
                ctx.GetValue(UserIdOption)!,
                ctx.GetValue(OutputOption)!
            );
        }
    }

    public static async Task DownloadNewVideos(string clientId,
        string clientSecret, string userId, DirectoryInfo outputDirectory)
    {
        TwitchAPI api = new(settings: new ApiSettings()
        {
            ClientId = clientId,
            Secret = clientSecret,
        });

        Console.WriteLine("Retrieving new videos from twitch");
        var videoResponse = await api.Helix.Videos.GetVideosAsync(userId: userId);

        if (videoResponse.Videos.Length == 0)
        {
            Console.WriteLine($"Could not find videos for user id {userId}");
            return;
        }

        using StreamingDbContext dbContext = await StreamingDbContext.CreateAsync(CancellationToken.None);

        foreach (TwitchVideo video in videoResponse.Videos)
        {
            var dbVideo = await dbContext.Videos.FirstOrDefaultAsync(x => x.TwitchId == video.Id);
            if (dbVideo is not null)
            {
                Console.WriteLine($"Video {video.Id} already exists in the database");
                continue;
            }

            FileInfo? downloadedFile = await DownloadVideoAsync(outputDirectory, video);
            if (downloadedFile is null)
            {
                continue;
            }

            dbVideo = GetDbVideo(video);
            
            // Download chat and extract shared links
            Console.WriteLine($"Downloading chat for video {video.Id}...");
            var chatDownloader = new TwitchChatDownloader(HttpClient);
            dbVideo.SharedLinks = await chatDownloader.GetSharedLinksFromChatAsync(video.Id, "kitokeboo");
            if (!string.IsNullOrWhiteSpace(dbVideo.SharedLinks))
            {
                Console.WriteLine($"Found {dbVideo.SharedLinks.Split(Environment.NewLine).Length} shared link(s)");
            }
            
            dbContext.Videos.Add(dbVideo);
            await dbContext.SaveChangesAsync();

            await WriteVideoDescriptionAsync(dbVideo, GetOutputFile(video, outputDirectory));
        }
    }

    public static async Task<VideoData?> DownloadNewVideo(string clientId,
        string clientSecret, string userId, DirectoryInfo outputDirectory)
    {
        TwitchAPI api = new(settings: new ApiSettings()
        {
            ClientId = clientId,
            Secret = clientSecret,
        });

        Console.WriteLine($"Retrieving new videos from twitch ({DateTime.Now})");
        var videoResponse = await api.Helix.Videos.GetVideosAsync(userId: userId);

        if (videoResponse.Videos.Length == 0)
        {
            Console.WriteLine($"Could not find videos for user id {userId}");
            return null;
        }

        using StreamingDbContext dbContext = await StreamingDbContext.CreateAsync(CancellationToken.None);

        foreach (TwitchVideo video in videoResponse.Videos)
        {
            var dbVideo = await dbContext.Videos.FirstOrDefaultAsync(x => x.TwitchId == video.Id);
            if (dbVideo is null)
            {
                dbVideo = GetDbVideo(video);
                
                // Download chat and extract shared links for new videos
                Console.WriteLine($"Downloading chat for video {video.Id}...");
                var chatDownloader = new TwitchChatDownloader(HttpClient);
                dbVideo.SharedLinks = await chatDownloader.GetSharedLinksFromChatAsync(video.Id, "kitokeboo");
                if (!string.IsNullOrWhiteSpace(dbVideo.SharedLinks))
                {
                    Console.WriteLine($"Found {dbVideo.SharedLinks.Split(Environment.NewLine).Length} shared link(s)");
                }
                
                dbContext.Videos.Add(dbVideo);
                await dbContext.SaveChangesAsync();
            }

            if (dbVideo.YouTubeId is not null)
            {
                Console.WriteLine($"Video {video.Id} already exists in the database with YouTube ID {dbVideo.YouTubeId} skipping download.");
                continue;
            }

            FileInfo? downloadedFile = await DownloadVideoAsync(outputDirectory, video);
            if (downloadedFile is null)
            {
                continue;
            }

            return new VideoData(dbVideo.Id, downloadedFile, null);
        }
        return null;
    }

    public static async Task<VideoData?> DownloadSingleAsync(string clientId,
        string clientSecret, string twitchVideoId, DirectoryInfo outputDirectory)
    {
        TwitchAPI api = new(settings: new ApiSettings()
        {
            ClientId = clientId,
            Secret = clientSecret,
        });

        Console.WriteLine($"Downloading video {twitchVideoId} from twitch ({DateTime.Now})");
        var videoResponse = await api.Helix.Videos.GetVideosAsync([twitchVideoId]);

        if (videoResponse.Videos.Length == 0)
        {
            Console.WriteLine($"Could not find video {twitchVideoId}");
            return null;
        }

        var twitchClient = new Twitch(HttpClient);

        using StreamingDbContext dbContext = await StreamingDbContext.CreateAsync(CancellationToken.None);

        foreach (TwitchVideo video in videoResponse.Videos)
        {
            FileInfo? downloadedFile = await DownloadVideoAsync(outputDirectory, video);
            if (downloadedFile is null)
            {
                continue;
            }

            DateTimeOffset? createdAt = video.GetCreatedAt();
            TimeSpan? duration = video.GetDuration();

            var dbVideo = await dbContext.Videos.FirstOrDefaultAsync(x => x.TwitchId == video.Id);
            if (dbVideo is null)
            {
                dbVideo = GetDbVideo(video);
                dbContext.Videos.Add(dbVideo);
            }
            else
            {
                dbVideo.TwitchStartTime = createdAt;
                dbVideo.TwitchDuration = duration;
                dbVideo.TwitchTitle = video.Title;
                dbVideo.TwitchDescription = video.Description;
                dbVideo.TwitchUrl = video.Url;
            }

            // Download chat and extract shared links
            Console.WriteLine($"Downloading chat for video {video.Id}...");
            var chatDownloader = new TwitchChatDownloader(HttpClient);
            dbVideo.SharedLinks = await chatDownloader.GetSharedLinksFromChatAsync(video.Id, "kitokeboo");
            if (!string.IsNullOrWhiteSpace(dbVideo.SharedLinks))
            {
                Console.WriteLine($"Found {dbVideo.SharedLinks.Split(Environment.NewLine).Length} shared link(s)");
            }

            await WriteVideoDescriptionAsync(dbVideo, GetOutputFile(video, outputDirectory));

            await dbContext.SaveChangesAsync();

            return new VideoData(dbVideo.Id, downloadedFile, null);
        }
        return null;
    }

    private static Video GetDbVideo(TwitchVideo video)
    {
        return new Video()
        {
            TwitchId = video.Id,
            TwitchStartTime = video.GetCreatedAt(),
            TwitchDuration = video.GetDuration(),
            TwitchTitle = video.Title,
            TwitchDescription = video.Description,
            TwitchUrl = video.Url
        };
    }

    private static async Task WriteVideoDescriptionAsync(Video video, FileInfo videoFile)
    {
        using StreamWriter writer = new($"{videoFile.FullName}.txt");
        string description = StreamingTools.YouTube.Description.Build(video);
        await writer.WriteLineAsync(description);
        Console.WriteLine($"Wrote video description to {videoFile.FullName}.txt");
    }

    private static async Task<FileInfo?> DownloadVideoAsync(DirectoryInfo outputDirectory, TwitchVideo video)
    {
        Console.WriteLine($"Downloading '{video.Title}' from {video.CreatedAt} - {video.Id} ({DateTime.Now})");

        var twitchClient = new Twitch(HttpClient);

        FileInfo outputFile = GetOutputFile(video, outputDirectory);

        if (outputFile.Exists)
        {
            Console.WriteLine($"Video file {outputFile.FullName} already exists, skipping download.");
            return outputFile;
        }

        if (!await twitchClient.DownloadVideoFileAsync(video.Id, outputFile))
        {
            Console.WriteLine($"Failed to download video file");
            return null;
        }

        Console.WriteLine($"Downloaded video file to {outputFile.FullName} ({DateTime.Now})");
        return outputFile;
    }

    private static FileInfo GetOutputFile(TwitchVideo video, DirectoryInfo outputDirectory)
    {
        DateTimeOffset? createdAt = video.GetCreatedAt();
        string fileName;
        if (createdAt is not null)
        {
            fileName = $"{createdAt:yyyy-MM-dd_HH-mm-ss}_{video.Id}.mp4";
        }
        else
        {
            fileName = $"{video.Id}.mp4";
        }
        fileName = string.Join("", fileName.Split(Path.GetInvalidFileNameChars()));
        return new FileInfo(Path.Combine(outputDirectory.FullName, fileName));
    }
}
