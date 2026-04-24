
using Google.Apis.YouTube.v3;
using Microsoft.EntityFrameworkCore;
using StreamingTools.Data;
using StreamingTools.Git;
using StreamingTools.Subtitle;
using StreamingTools.YouTube;
using System.CommandLine;
using System.Runtime.CompilerServices;
using PlaylistStatus = Google.Apis.YouTube.v3.Data.PlaylistStatus;
using PlaylistSnippet = Google.Apis.YouTube.v3.Data.PlaylistSnippet;
using VideoRecordingDetails = Google.Apis.YouTube.v3.Data.VideoRecordingDetails;
using VideoSnippet = Google.Apis.YouTube.v3.Data.VideoSnippet;
using VideoStatus = Google.Apis.YouTube.v3.Data.VideoStatus;
using YouTubeVideo = Google.Apis.YouTube.v3.Data.Video;
using YouTubePlaylist = Google.Apis.YouTube.v3.Data.Playlist;

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

    private static CliOption<bool> All { get; } = new CliOption<bool>("--all", "-a")
    {
        Description = "Indicates if all videos should be processed",
    };

    private static CliOption<string> PlaylistNameOption { get; } = new CliOption<string>("--name", "-n")
    {
        Description = "The playlist name",
        Required = true
    };

    private static CliOption<DateOnly> StartDateOption { get; } = new CliOption<DateOnly>("--start-date", "--from")
    {
        Description = "The first published date to include (yyyy-MM-dd)",
        Required = true
    };

    private static CliOption<DateOnly> EndDateOption { get; } = new CliOption<DateOnly>("--end-date", "--to")
    {
        Description = "The last published date to include (yyyy-MM-dd)",
        Required = true
    };

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
            All,
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

        var playlistCommand = new CliCommand("playlist")
        {
            PlaylistNameOption,
            StartDateOption,
            EndDateOption
        };
        Add(playlistCommand);
        playlistCommand.SetAction(CreatePlaylistFromPublishedDateRangeAsync);
    }

    private static async Task<int> CreatePlaylistFromPublishedDateRangeAsync(ParseResult ctx, CancellationToken token)
    {
        string playlistName = ctx.GetValue(PlaylistNameOption)!.Trim();
        if (string.IsNullOrWhiteSpace(playlistName))
        {
            Console.WriteLine("Playlist name cannot be empty.");
            return 1;
        }

        DateOnly startDate = ctx.GetValue(StartDateOption);
        DateOnly endDate = ctx.GetValue(EndDateOption);
        if (!YouTubePublishedDateRange.TryCreate(startDate, endDate, out var dateRange))
        {
            Console.WriteLine($"The end date '{endDate:yyyy-MM-dd}' must be on or after the start date '{startDate:yyyy-MM-dd}'.");
            return 1;
        }

        var service = await YouTubeFactory.GetServiceAsync();
        var (playlist, created) = await GetOrCreatePlaylistAsync(service, playlistName, token);
        string targetPlaylistName = playlist.Snippet?.Title ?? playlistName;

        Console.WriteLine(created
            ? $"Created unlisted playlist '{targetPlaylistName}'."
            : $"Using existing playlist '{targetPlaylistName}'.");

        HashSet<string> existingVideoIds = await GetPlaylistVideoIdsAsync(service, playlist.Id!, token);
        int matchedCount = 0;
        int addedCount = 0;
        int alreadyPresentCount = 0;

        await foreach (var video in GetChannelVideosPublishedInRangeAsync(service, dateRange, token))
        {
            matchedCount++;
            if (!existingVideoIds.Add(video.VideoId))
            {
                alreadyPresentCount++;
                Console.WriteLine($"Skipping '{video.Title}' ({video.PublishedAt:yyyy-MM-dd}) because it is already in '{targetPlaylistName}'.");
                continue;
            }

            await AddVideoToPlaylistAsync(service, playlist.Id!, video.VideoId, token);
            addedCount++;
            Console.WriteLine($"Added '{video.Title}' ({video.PublishedAt:yyyy-MM-dd}) to '{targetPlaylistName}'.");
        }

        if (matchedCount == 0)
        {
            Console.WriteLine($"No YouTube videos were published between {startDate:yyyy-MM-dd} and {endDate:yyyy-MM-dd}.");
            return 0;
        }

        Console.WriteLine(
            $"Processed {matchedCount} video(s) for '{targetPlaylistName}' from {startDate:yyyy-MM-dd} to {endDate:yyyy-MM-dd}: {addedCount} added, {alreadyPresentCount} already present.");
        return 0;
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

    public static async Task<bool?> UploadVideoAsync(FileInfo sourceFile, int videoId, CancellationToken token)
    {
        using var dbContext = await StreamingDbContext.CreateAsync(token);

        //Refresh from database and update to the new context
        var video = await dbContext.Videos.SingleAsync(x => x.Id == videoId, token);

        if (video.YouTubeId != null)
        {
            Console.WriteLine($"Video {video.Id} already has a YouTube ID set: {video.YouTubeId}");
            return null;
        }
        if (sourceFile is null || !sourceFile.Exists)
        {
            Console.WriteLine($"Source file {sourceFile?.FullName} does not exist for video {video.Id}");
            return false;
        }
        if (await UploadAsync(video, sourceFile, token))
        {
            await dbContext.SaveChangesAsync(token);
            return true;
        }
        return false;
    }

    public static async Task<bool> UploadAsync(Video video, FileInfo sourceFile, CancellationToken token)
    {
        Console.WriteLine($"Uploading video {video.Id} to YouTube ({sourceFile.FullName}) {DateTime.UtcNow}");
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
        Google.Apis.Upload.UploadStatus lastStatus = Google.Apis.Upload.UploadStatus.NotStarted;
        insertRequest.ProgressChanged += (Google.Apis.Upload.IUploadProgress obj) =>
        {
            if (obj.Status != lastStatus)
            {
                lastStatus = obj.Status;
                Console.WriteLine($"Upload status => {obj.Status} {DateTime.UtcNow}");
            }

            if (obj.Status == Google.Apis.Upload.UploadStatus.Failed)
            {
                Console.WriteLine($"Failed to upload: {obj.Exception}");
            }
        };
        var uploadResult = await insertRequest.UploadAsync(token);

        if (success)
        {
            Console.WriteLine($"Video {video.Id} uploaded successfully with YouTube ID: {video.YouTubeId}, adding to playlists");
            foreach (var playlistName in details.Playlists)
            {
                var playlist = await GetPlaylistByTitleAsync(service, playlistName, token);
                if (playlist != null)
                {
                    await AddVideoToPlaylistAsync(service, playlist.Id!, video.YouTubeId!, token);
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
        DirectoryInfo outputDirectory = ctx.GetValue(OutputDirectory)!;

        int result = 0;
        await foreach(var video in GetVideos(ctx, dbContext, token).WithCancellation(token))
        {
            if (string.IsNullOrWhiteSpace(video.YouTubeId))
            {
                Console.WriteLine($"Video {video.Id} does not have a YouTube Id");
                continue;
            }
            Console.WriteLine($"Generating subtitles for video {video.Id} (YouTube ID: {video.YouTubeId})");
            int videoResult = await GenerateSubtitlesForVideoAsync(video, service, dbContext, outputDirectory, token);
            result += videoResult;
            if (videoResult != 0)
            {
                Console.WriteLine($"Failed to generate subtitles for video {video.Id} (YouTube ID: {video.YouTubeId})");
            }
        }

        return result;

        static async Task<int> GenerateSubtitlesForVideoAsync(Video video, YouTubeService service, 
            StreamingDbContext dbContext, DirectoryInfo outputDirectory, CancellationToken token)
        {
            DateTime publishedAt = video.TwitchStartTime?.Date ?? DateTime.Today;
            Uri? markdownUri = await GetMarkdownUrl(video, publishedAt, token);
            if (markdownUri is null)
            {
                Console.WriteLine($"Could not get markdown url for video (ID: {video.Id})");
                return 1;
            }

            string youTubeId = video.YouTubeId!;

            if (await service.GetSrtSubtitles(youTubeId, token) is { Length: > 0 } subtitles)
            {
                Console.WriteLine("  Got subtitles");
                string markdown = Subtitles.ConvertSrtToMarkdown(youTubeId, subtitles);
                string fileName = await WriteToFile(outputDirectory, markdown, youTubeId, publishedAt, token);
                Console.WriteLine($"  Wrote markdown to '{fileName}'");
                video.SubtitlesUrl = markdownUri.AbsoluteUri;

                var videoQuery = service.Videos.List("snippet");
                videoQuery.Id = video.YouTubeId;
                var videoResponse = await videoQuery.ExecuteAsync(token);
                if (videoResponse.Items is { Count: > 0 } videos &&
                    videos[0] is { } youTubeVideo &&
                    youTubeVideo.Snippet?.Description is { } description &&
                    !description.Contains(video.SubtitlesUrl))
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
        }

        static async IAsyncEnumerable<Video> GetVideos(ParseResult ctx, StreamingDbContext dbContext,
            [EnumeratorCancellation]CancellationToken token = default)
        {
            if (ctx.GetValue(All) is true)
            {
                await foreach(var video in dbContext.Videos
                    .Where(x => x.YouTubeId != null && x.SubtitlesUrl == null && x.TwitchId != null)
                    .OrderByDescending(x => x.TwitchStartTime)
                    .AsAsyncEnumerable())
                {
                    yield return video;
                }
            }
            else if (await GetVideoAsync(ctx, dbContext, token) is { } video)
            {
                yield return video;
            }
        }

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

    private static async Task<YouTubePlaylist?> GetPlaylistByTitleAsync(YouTubeService service, string playlistName, CancellationToken token)
    {
        var playlistListRequest = service.Playlists.List("snippet,status");
        playlistListRequest.Mine = true;
        playlistListRequest.MaxResults = 50;

        do
        {
            var playlists = await playlistListRequest.ExecuteAsync(token);
            var playlist = playlists.Items.FirstOrDefault(x => string.Equals(x.Snippet?.Title, playlistName, StringComparison.Ordinal));
            if (playlist is not null)
            {
                return playlist;
            }

            playlistListRequest.PageToken = playlists.NextPageToken;
        }
        while (!string.IsNullOrWhiteSpace(playlistListRequest.PageToken));

        return null;
    }

    private static async Task<(YouTubePlaylist Playlist, bool Created)> GetOrCreatePlaylistAsync(YouTubeService service, string playlistName, CancellationToken token)
    {
        if (await GetPlaylistByTitleAsync(service, playlistName, token) is { } existingPlaylist)
        {
            return (existingPlaylist, false);
        }

        var newPlaylist = new YouTubePlaylist
        {
            Snippet = new PlaylistSnippet
            {
                Title = playlistName
            },
            Status = new PlaylistStatus
            {
                PrivacyStatus = "unlisted"
            }
        };

        var createdPlaylist = await service.Playlists.Insert(newPlaylist, "snippet,status").ExecuteAsync(token);
        return (createdPlaylist, true);
    }

    private static async Task<HashSet<string>> GetPlaylistVideoIdsAsync(YouTubeService service, string playlistId, CancellationToken token)
    {
        HashSet<string> videoIds = [];
        var playlistItemsRequest = service.PlaylistItems.List("snippet");
        playlistItemsRequest.PlaylistId = playlistId;
        playlistItemsRequest.MaxResults = 50;

        do
        {
            var playlistItems = await playlistItemsRequest.ExecuteAsync(token);
            foreach (var item in playlistItems.Items)
            {
                if (!string.IsNullOrWhiteSpace(item.Snippet?.ResourceId?.VideoId))
                {
                    videoIds.Add(item.Snippet.ResourceId.VideoId);
                }
            }

            playlistItemsRequest.PageToken = playlistItems.NextPageToken;
        }
        while (!string.IsNullOrWhiteSpace(playlistItemsRequest.PageToken));

        return videoIds;
    }

    private static async Task AddVideoToPlaylistAsync(YouTubeService service, string playlistId, string videoId, CancellationToken token)
    {
        var playlistItem = new Google.Apis.YouTube.v3.Data.PlaylistItem
        {
            Snippet = new Google.Apis.YouTube.v3.Data.PlaylistItemSnippet
            {
                PlaylistId = playlistId,
                ResourceId = new Google.Apis.YouTube.v3.Data.ResourceId
                {
                    Kind = "youtube#video",
                    VideoId = videoId
                }
            }
        };

        await service.PlaylistItems.Insert(playlistItem, "snippet").ExecuteAsync(token);
    }

    private static async IAsyncEnumerable<YouTubeChannelVideo> GetChannelVideosPublishedInRangeAsync(
        YouTubeService service,
        YouTubePublishedDateRange dateRange,
        [EnumeratorCancellation] CancellationToken token = default)
    {
        var listVideosRequest = service.Search.List("snippet");
        listVideosRequest.Order = SearchResource.ListRequest.OrderEnum.Date;
        listVideosRequest.ForMine = true;
        listVideosRequest.MaxResults = 50;
        listVideosRequest.Type = "video";
        listVideosRequest.PublishedAfterDateTimeOffset = dateRange.PublishedAfter;
        listVideosRequest.PublishedBeforeDateTimeOffset = dateRange.PublishedBefore;

        do
        {
            var response = await listVideosRequest.ExecuteAsync(token);
            foreach (var item in response.Items)
            {
                if (item.Id?.VideoId is not { Length: > 0 } videoId ||
                    item.Snippet?.PublishedAtDateTimeOffset is not { } publishedAt ||
                    !dateRange.Includes(publishedAt))
                {
                    continue;
                }

                yield return new YouTubeChannelVideo(videoId, item.Snippet.Title ?? videoId, publishedAt);
            }

            listVideosRequest.PageToken = response.NextPageToken;
        }
        while (!string.IsNullOrWhiteSpace(listVideosRequest.PageToken));
    }

    private sealed record YouTubeChannelVideo(string VideoId, string Title, DateTimeOffset PublishedAt);
}
