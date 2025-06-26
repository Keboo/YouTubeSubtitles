
using Microsoft.EntityFrameworkCore;
using StreamingTools.Data;
using StreamingTools.Git;
using StreamingTools.Subtitle;
using StreamingTools.YouTube;
using System.CommandLine;
using System.Diagnostics;
using VideoRecordingDetails = Google.Apis.YouTube.v3.Data.VideoRecordingDetails;
using VideoSnippet = Google.Apis.YouTube.v3.Data.VideoSnippet;
using VideoStatus = Google.Apis.YouTube.v3.Data.VideoStatus;
using YouTubeVideo = Google.Apis.YouTube.v3.Data.Video;

namespace Keboo.Editor;

public partial class YouTubeCommand : CliCommand
{
    private static CliOption<FileInfo> InputFileOption { get; } = new CliOption<FileInfo>("--input-file", "-f")
    {
        Description = "An input file"
    }.AcceptExistingOnly();

    private static CliOption<int> VideoIdOption { get; } = new CliOption<int>("--video-id", "-i")
    {
        Description = "The video id"
    };

    private static CliOption<string> TwitchVideoIdOption { get; } = new CliOption<string>("--twitch-id", "-t")
    {
        Description = "The twitch video id"
    };

    private static CliOption<DirectoryInfo> OutputDirectory { get; } = new CliOption<DirectoryInfo>("--output-directory", "-o")
    {
        Description = "The output directory",
        Required = true
    }.AcceptExistingOnly();

    private static CliOption<DirectoryInfo> VideoDirectory { get; } = new CliOption<DirectoryInfo>("--video-directory", "-v")
    {
        Description = "The directory containing video files",
        Required = true
    }.AcceptExistingOnly();

    public YouTubeCommand()
        : base("youtube")
    {
        var listingCommand = new CliCommand("listing")
        {
            InputFileOption,
            VideoIdOption,
            TwitchVideoIdOption
        };
        Add(listingCommand);
        listingCommand.SetAction(async (ctx, ct) =>
        {
            using var dbContext = await StreamingDbContext.CreateAsync(ct);
            var video = await GetVideoAsync(ctx, dbContext, ct);

            if (video is null)
            {
                Console.WriteLine($"No video found");
                return 1;
            }

            string description = StreamingTools.YouTube.Description.Build(video);

            Console.WriteLine(description);

            return 0;
        });

        var subtitlesCommand = new CliCommand("subtitles")
        {
            InputFileOption,
            VideoIdOption,
            TwitchVideoIdOption,
            OutputDirectory
        };
        Add(subtitlesCommand);
        subtitlesCommand.SetAction(GenerateSubtitles);

        var uploadCommand = new CliCommand("upload")
        {
            InputFileOption,
            VideoIdOption,
            TwitchVideoIdOption,
            VideoDirectory
        };
        Add(uploadCommand);
        uploadCommand.SetAction(UploadVideo);
    }

    private static async Task<int> UploadVideo(ParseResult ctx, CancellationToken token)
    {
        using var dbContext = await StreamingDbContext.CreateAsync(token);
        var video = await GetVideoAsync(ctx, dbContext, token);

        if (video is null)
        {
            Console.WriteLine($"No video found");
            return 1;
        }

        if (video.YouTubeId != null)
        {
            Console.WriteLine("Video already has a YouTube ID set");
            return 0;
        }

        DirectoryInfo videoDirectory = ctx.GetValue(VideoDirectory)!;
        FileInfo sourceFile = videoDirectory.EnumerateFiles($"*{video.TwitchId}.trimmed.mp4").FirstOrDefault() ??
            throw new Exception($"Could not find video file for video {video.Id} in output directory {videoDirectory.FullName}");

        if (await UploadAsync(video, sourceFile, token))
        {
            await dbContext.SaveChangesAsync(token);
            return 0;
        }
        return 1;
    }

    public static async Task UploadVideoAsync(FileInfo sourceFile, int videoId, CancellationToken token)
    {
        using var dbContext = await StreamingDbContext.CreateAsync(token);

        //Refresh from database and update to the new context
        var video = await dbContext.Videos.SingleAsync(x => x.Id == videoId, token);

        if (video.YouTubeId != null)
        {
            Console.WriteLine($"Video {video.Id} already has a YouTube ID set: {video.YouTubeId}");
            return;
        }
        if (sourceFile is null || !sourceFile.Exists)
        {
            Console.WriteLine($"Source file {sourceFile?.FullName} does not exist for video {video.Id}");
            return;
        }
        if (await UploadAsync(video, sourceFile, token))
        {
            await dbContext.SaveChangesAsync(token);
        }
    }

    public static async Task<bool> UploadAsync(Video video, FileInfo sourceFile, CancellationToken token)
    {
        Console.WriteLine($"Uploading video {video.Id} to YouTube ({sourceFile.FullName})");
        var service = await YouTubeFactory.GetServiceAsync();

        var details = StreamingTools.YouTube.Description.GetDetails(video);
        YouTubeVideo youTubeVideo = new()
        {
            Snippet = new VideoSnippet
            {
                Title = details.Title,
                Description = details.Description,
                Tags = [.. details.Tags],
                CategoryId = "28", // Science and Technology,
            },
            Status = new VideoStatus
            {
                PrivacyStatus = "unlisted",
                Embeddable = true,
                License = "youtube",
                MadeForKids = false,
                SelfDeclaredMadeForKids = false,
            },
            RecordingDetails = new VideoRecordingDetails
            {
                LocationDescription = "Spokane",
                RecordingDateRaw = details.RecordingDate.ToString("yyyy-MM-ddTHH:mm:ssZ"),
            }
        };
        using var fileStream = sourceFile.OpenRead();
        var insertRequest = service.Videos.Insert(youTubeVideo, new(["snippet", "status", "recording_details"]), fileStream, "video/*");
        bool success = false;
        insertRequest.ResponseReceived += (ytVideo) =>
        {
            Console.WriteLine($"YouTube video uploaded: {video.Id}");
            video.YouTubeId = ytVideo.Id;
            success = true;
        };
        var uploadResult = await insertRequest.UploadAsync(token);

        if (success)
        {
            Console.WriteLine($"Video {video.Id} uploaded successfully with YouTube ID: {video.YouTubeId}, adding to playlists");
            var playlistListRequest = service.Playlists.List("snippet");
            playlistListRequest.Mine = true;
            playlistListRequest.MaxResults = 100;
            var playlists = await playlistListRequest.ExecuteAsync(token);
            foreach (var playlistName in details.Playlists)
            {
                var playlist = playlists.Items.FirstOrDefault(x => x.Snippet.Title == playlistName);
                if (playlist != null)
                {
                    var playlistItem = new Google.Apis.YouTube.v3.Data.PlaylistItem
                    {
                        Snippet = new Google.Apis.YouTube.v3.Data.PlaylistItemSnippet
                        {
                            PlaylistId = playlist.Id,
                            ResourceId = new Google.Apis.YouTube.v3.Data.ResourceId
                            {
                                Kind = "youtube#video",
                                VideoId = video.YouTubeId
                            }
                        }
                    };

                    var playlistInsertRequest = service.PlaylistItems.Insert(playlistItem, "snippet");
                    await playlistInsertRequest.ExecuteAsync(token);
                }
            }
            Console.WriteLine($"Video {video.Id} added to playlists: {string.Join(", ", details.Playlists)}");
        }
        else
        {
            Console.WriteLine($"Failed to upload video {video.Id} to YouTube");
        }
        return success;
    }

    private static async Task<int> GenerateSubtitles(ParseResult ctx, CancellationToken token)
    {
        using var dbContext = await StreamingDbContext.CreateAsync(token);

        var service = await YouTubeFactory.GetServiceAsync();

        Video? video = await GetVideoAsync(ctx, dbContext, token);

        if (string.IsNullOrWhiteSpace(video?.YouTubeId))
        {
            Console.WriteLine("Could not find YouTube video id");
            return 1;
        }

        DateTime publishedAt = video.TwitchStartTime?.Date ?? DateTime.Today;
        Uri? markdownUri = await GetMarkdownUrl(video, publishedAt, token);
        if (markdownUri is null)
        {
            Console.WriteLine($"Could not get markdown url for video (ID: {video.Id})");
            return 1;
        }

        if (await service.GetSrtSubtitles(video.YouTubeId, token) is { Length: > 0 } subtitles)
        {
            Console.WriteLine("  Got subtitles");
            string markdown = Subtitles.ConvertSrtToMarkdown(video.YouTubeId, subtitles);
            DirectoryInfo outputDirectory = ctx.GetValue(OutputDirectory)!;
            string fileName = await WriteToFile(outputDirectory, markdown, video.YouTubeId, publishedAt, token);
            Console.WriteLine($"  Wrote markdown to '{fileName}'");
            video.SubtitlesUrl = markdownUri.AbsoluteUri;

            var videoQuery = service.Videos.List("snippet");
            videoQuery.Id = video.YouTubeId;
            var videoResponse = await videoQuery.ExecuteAsync(token);
            if (videoResponse.Items is { Count: > 0 } videos &&
                videos[0] is { } youTubeVideo &&
                youTubeVideo.Snippet?.Description is { } description &&
                description.Contains(video.SubtitlesUrl) != true)
            {
                Console.WriteLine($"Updating video {video.Id} description");
                description +=
                    Environment.NewLine +
                    Environment.NewLine +
                    $"Search video contents here: {video.SubtitlesUrl}";

                youTubeVideo.Snippet.Description = description;
                await service.Videos.Update(youTubeVideo, "snippet").ExecuteAsync(token);
            }
            Console.WriteLine($"  Set video ({video.Id}) subtitle URL to be '{video.SubtitlesUrl}'");
        }
        else
        {
            Console.WriteLine($"  YouTube video '{video.YouTubeId}' not found");
            video.SubtitlesUrl = "YouTube Video Removed";
            return 2;
        }
        await dbContext.SaveChangesAsync(token);

        return 0;

        static async Task<string> WriteToFile(DirectoryInfo outputDirectory, string markdownContent, string videoId, DateTime date, CancellationToken token)
        {
            string fileName = Subtitles.GetMarkdownFileName(videoId, date);
            var path = Path.Combine(outputDirectory.FullName, fileName);

            await File.WriteAllTextAsync(path, markdownContent, token);

            return fileName;
        }

        static async Task<Uri?> GetMarkdownUrl(Video video, DateTime publishedAt, CancellationToken token)
        {
            string fileName = Subtitles.GetMarkdownFileName(video.YouTubeId!, publishedAt);
            string branchName = (await GitHelper.GetCurrentBranchName(token)) ?? "main";

            if (await GitHelper.GetRemoteUrl(token) is { } remoteUrl)
            {
                //TODO: Output directory is currently hard coded to match workflow
                return new Uri(remoteUrl, $"blob/{branchName}/Subtitles/{fileName}");
            }
            return null;
        }
    }

    private static async Task<Video?> GetVideoAsync(ParseResult ctx, StreamingDbContext dbContext, CancellationToken token)
    {
        Video? rv = null;

        if (ctx.GetValue(VideoIdOption) is var videoId and > 0)
        {
            rv = await dbContext.Videos.AsTracking().FirstOrDefaultAsync(x => x.Id == videoId, token);
        }

        if (rv is null && ctx.GetValue(TwitchVideoIdOption) is string twitchVideoId)
        {
            rv = await dbContext.Videos.AsTracking().FirstOrDefaultAsync(x => x.TwitchId == twitchVideoId, token);
        }

        if (rv is null && ctx.GetValue(InputFileOption) is { } input)
        {
            Match match = TwitchId().Match(input.Name);
            if (!match.Success)
            {
                Console.WriteLine("Invalid file name format. Expected format: *_<TwitchVideoId>.trimmed.*");
            }
            else
            {
                twitchVideoId = match.Groups["TwitchVideoId"].Value;
                rv = await dbContext.Videos.AsTracking().FirstOrDefaultAsync(x => x.TwitchId == twitchVideoId, token);
            }
        }

        return rv;
    }

    [GeneratedRegex("_(?<TwitchVideoId>[0-9]+).trimmed")]
    private static partial Regex TwitchId();
}
