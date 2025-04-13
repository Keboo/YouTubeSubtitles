using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using StreamingTools.Data;
using StreamingTools.Twitch;
using System.CommandLine;
using TwitchLib.Api;
using TwitchLib.Api.Core;

using TwitchVideo = TwitchLib.Api.Helix.Models.Videos.GetVideos.Video;

namespace Keboo.Editor;

public class TwitchCommand : CliCommand
{
    private CliOption<string> UserIdOption { get; } = new("--twitch-user-id")
    {
        DefaultValueFactory = _ => Environment.GetEnvironmentVariable("KebooTwitchUserId") ?? "",
        Required = true
    };

    private CliOption<string> ClientIdOption { get; } = new("--twitch-client-id")
    {
        DefaultValueFactory = _ => Environment.GetEnvironmentVariable("KebooTwitchClientId") ?? "",
        Required = true
    };

    private CliOption<string> ClientSecretOption { get; } = new("--twitch-client-secret")
    {
        DefaultValueFactory = _ => Environment.GetEnvironmentVariable("KebooTwitchClientSecret") ?? "",
        Required = true
    };

    private CliOption<string> VideoIdOption { get; } = new("--twitch-video-id");
    private CliOption<DirectoryInfo> OutputOption { get; } = new("--output")
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

        twitchDownload.SetAction(async (ctx, ct) =>
        {
            string? videoId = ctx.GetValue(VideoIdOption);

            if (!string.IsNullOrEmpty(videoId))
            {
                await DownloadSingleAsync(
                        ctx.GetValue(ClientIdOption)!,
                        ctx.GetValue(ClientSecretOption)!,
                        videoId,
                        ctx.GetValue(OutputOption)!
                    );
            }
            else
            {
                await DownloadNewVideos(
                    ctx.GetValue(ClientIdOption)!,
                    ctx.GetValue(ClientSecretOption)!,
                    ctx.GetValue(UserIdOption)!,
                    ctx.GetValue(OutputOption)!
                );
            }
        });
    }

    private static HttpClient HttpClient { get; } = new();

    private static async Task DownloadNewVideos(string clientId,
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

        using StreamingDbContext dbContext = await GetDbContextAsync();

        foreach (TwitchVideo video in videoResponse.Videos)
        {
            var dbVideo = await dbContext.Videos.FirstOrDefaultAsync(x => x.TwitchId == video.Id);
            if (dbVideo is not null)
            {
                Console.WriteLine($"Video {video.Id} already exists in the database");
                continue;
            }

            if (!await DownloadVideoAsync(outputDirectory, video))
            {
                continue;
            }

            dbContext.Videos.Add(GetDbVideo(video));
            await dbContext.SaveChangesAsync();
        }
    }

    private static async Task DownloadSingleAsync(string clientId,
        string clientSecret, string videoId, DirectoryInfo outputDirectory)
    {
        TwitchAPI api = new(settings: new ApiSettings()
        {
            ClientId = clientId,
            Secret = clientSecret,
        });

        Console.WriteLine("Retrieving videos from twitch");
        var videoResponse = await api.Helix.Videos.GetVideosAsync([videoId]);

        if (videoResponse.Videos.Length == 0)
        {
            Console.WriteLine($"Could not find video {videoId}");
            return;
        }

        var twitchClient = new StreamingTools.Twitch.Twitch(HttpClient);

        using StreamingDbContext dbContext = await GetDbContextAsync();

        foreach (TwitchVideo video in videoResponse.Videos)
        {
            if (!await DownloadVideoAsync(outputDirectory, video))
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
            await dbContext.SaveChangesAsync();
        }
    }

    private static async Task<StreamingDbContext> GetDbContextAsync()
    {
        var dbContext = new StreamingDbContext();
        await dbContext.Database.MigrateAsync();
        return dbContext;
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

    private static async Task<bool> DownloadVideoAsync(DirectoryInfo outputDirectory, TwitchVideo video)
    {
        Console.WriteLine($"Downloading '{video.Title}' from {video.CreatedAt} - {video.Id} ");

        var twitchClient = new StreamingTools.Twitch.Twitch(HttpClient);

        FileInfo outputFile = GetOutputFile(video, outputDirectory);

        if (!await twitchClient.DownloadVideoFileAsync(video.Id, outputFile))
        {
            Console.WriteLine($"Failed to download video file");
            return false;
        }

        Console.WriteLine($"Downloaded video file to {outputFile.FullName}");
        return true;
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
