using Google.Apis.YouTube.v3;
using System.ComponentModel;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using StreamingTools.Copilot;
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

public partial class YouTubeCommand : Command
{
    private const string TodoDescriptionMarker = "###TODO_DESCRIPTIOON###";
    private static readonly string[] CommonVideoTags =
    [
        "programming",
        "C#",
        "dotnet",
        "WPF",
        "XAML",
        "Avalonia",
        "System.CommandLine",
        "GitHub",
        "GitKraken",
        "Velopack",
        "DevOps",
        "Azure",
        "Terraform",
        "Kubernetes",
        "Helm"
    ];

    private static Option<FileInfo> InputFileOption { get; } = new Option<FileInfo>("--input-file")
    {
        Aliases = { "-f" },
        Description = "An input file"
    }.AcceptExistingOnly();

    private static Option<int> VideoIdOption { get; } = new("--video-id")
    {
        Aliases = { "-i" },
        Description = "The video id"
    };

    private static Option<string> TwitchVideoIdOption { get; } = new("--twitch-id")
    {
        Aliases = { "-t" },
        Description = "The twitch video id"
    };

    private static Option<string?> YouTubeVideoIdOption { get; } = new("--youtube-id")
    {
        Aliases = { "-y" },
        Description = "The YouTube video id"
    };

    private static Option<DirectoryInfo> OutputDirectory { get; } = new Option<DirectoryInfo>("--output-directory")
    {
        Aliases = { "-o" },
        Description = "The output directory",
        Required = true
    }.AcceptExistingOnly();

    private static Option<DirectoryInfo> VideoDirectory { get; } = new Option<DirectoryInfo>("--video-directory")
    {
        Aliases = { "-v" },
        Description = "The directory containing video files",
        Required = true
    }.AcceptExistingOnly();

    private static Option<DirectoryInfo> TranscriptDirectory { get; } = new Option<DirectoryInfo>("--transcript-directory")
    {
        Aliases = { "-d" },
        Description = "The directory containing downloaded transcript markdown files",
        Required = true
    }.AcceptExistingOnly();

    private static Option<string> DescriptionModelOption { get; } = new("--model")
    {
        Description = "Copilot model to use for description generation",
        DefaultValueFactory = _ => "auto"
    };

    private static Option<bool> All { get; } = new("--all")
    {
        Aliases = { "-a" },
        Description = "Indicates if all videos should be processed",
    };

    private static Option<string> PlaylistNameOption { get; } = new("--name")
    {
        Aliases = { "-n" },
        Description = "The playlist name",
        Required = true
    };

    private static Option<DateOnly> StartDateOption { get; } = new("--start-date")
    {
        Aliases = { "--from" },
        Description = "The first published date to include (yyyy-MM-dd)",
        Required = true
    };

    private static Option<DateOnly> EndDateOption { get; } = new("--end-date")
    {
        Aliases = { "--to" },
        Description = "The last published date to include (yyyy-MM-dd)",
        Required = true
    };

    public YouTubeCommand()
        : base("youtube")
    {
        var listingCommand = new Command("listing")
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

        var subtitlesCommand = new Command("subtitles")
        {
            InputFileOption,
            VideoIdOption,
            TwitchVideoIdOption,
            All,
            OutputDirectory
        };
        Add(subtitlesCommand);
        subtitlesCommand.SetAction(GenerateSubtitles);

        var descriptionCommand = new Command("description")
        {
            InputFileOption,
            VideoIdOption,
            TwitchVideoIdOption,
            YouTubeVideoIdOption,
            TranscriptDirectory,
            DescriptionModelOption
        };
        Add(descriptionCommand);
        descriptionCommand.SetAction(GenerateDescriptionFromTranscriptAsync);

        var uploadCommand = new Command("upload")
        {
            InputFileOption,
            VideoIdOption,
            TwitchVideoIdOption,
            VideoDirectory
        };
        Add(uploadCommand);
        uploadCommand.SetAction(UploadVideo);

        var playlistCommand = new Command("playlist")
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
        string uploadDescription = details.Description;
        if (!uploadDescription.Contains(TodoDescriptionMarker, StringComparison.Ordinal))
        {
            uploadDescription =
                $"{TodoDescriptionMarker}{Environment.NewLine}{Environment.NewLine}{uploadDescription}";
        }

        YouTubeVideo youTubeVideo = new()
        {
            Snippet = new VideoSnippet
            {
                Title = details.Title,
                Description = uploadDescription,
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
        insertRequest.ProgressChanged += obj =>
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

        if (ctx.GetValue(All) is true)
        {
            await SyncYouTubeVideosToDatabase(service, dbContext, token);
        }

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
            DateTime publishedAt = video.TwitchStartTime?.Date ?? video.YouTubePublishTime?.Date ?? DateTime.Today;
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
                    .Where(x => x.YouTubeId != null && x.SubtitlesUrl == null)
                    .OrderByDescending(x => x.TwitchStartTime ?? x.YouTubePublishTime)
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

    private static async Task<int> GenerateDescriptionFromTranscriptAsync(ParseResult ctx, CancellationToken token)
    {
        DirectoryInfo transcriptDirectory = ctx.GetValue(TranscriptDirectory)!;
        string model = ctx.GetValue(DescriptionModelOption) ?? "auto";
        if (string.IsNullOrWhiteSpace(model))
        {
            model = "auto";
        }

        var service = await YouTubeFactory.GetServiceAsync();
        List<YouTubeVideo> targetVideos = await GetTargetVideosForDescriptionAsync(ctx, service, token);
        if (targetVideos.Count == 0)
        {
            Console.WriteLine($"No videos found that require description generation (marker: {TodoDescriptionMarker}).");
            return 0;
        }

        int updated = 0;
        int failed = 0;

        foreach (YouTubeVideo youTubeVideo in targetVideos)
        {
            if (youTubeVideo.Id is not { Length: > 0 } youTubeId)
            {
                failed++;
                continue;
            }

            DateTime[] preferredDates = youTubeVideo.Snippet?.PublishedAtDateTimeOffset is { } publishedAt
                ? [publishedAt.Date]
                : [];

            if (TryFindTranscriptFile(youTubeId, transcriptDirectory, preferredDates) is not { } transcriptFile)
            {
                Console.WriteLine(
                    $"Could not find transcript markdown for YouTube video '{youTubeId}' in '{transcriptDirectory.FullName}'. " +
                    "Run 'youtube subtitles' first.");
                failed++;
                continue;
            }

            CopilotPromptResult result;
            try
            {
                string prompt = BuildTranscriptDescriptionPrompt(youTubeVideo);
                result = await CopilotCli.ExecutePromptWithAttachmentAsync(prompt, transcriptFile, model, token);
            }
            catch (Win32Exception ex)
            {
                Console.Error.WriteLine($"Failed to start Copilot CLI: {ex.Message}");
                return 1;
            }
            catch (InvalidOperationException ex)
            {
                Console.Error.WriteLine($"Failed to run Copilot CLI: {ex.Message}");
                return 1;
            }

            if (!result.Success)
            {
                Console.Error.WriteLine($"Copilot CLI failed to generate metadata for video '{youTubeId}'.");
                if (!string.IsNullOrWhiteSpace(result.StandardError))
                {
                    Console.Error.WriteLine(result.StandardError.Trim());
                }
                failed++;
                continue;
            }

            if (!TryParseGeneratedVideoUpdate(result.MessageContent, out var videoUpdate, out string parseError))
            {
                Console.Error.WriteLine($"Failed to parse generated metadata for video '{youTubeId}': {parseError}");
                failed++;
                continue;
            }

            ApplyGeneratedVideoUpdate(youTubeVideo, videoUpdate);
            await service.Videos.Update(youTubeVideo, "snippet").ExecuteAsync(token);

            updated++;
            Console.WriteLine($"Updated YouTube video '{youTubeId}' title, description, and tags.");
        }

        Console.WriteLine($"Description generation complete: {updated} updated, {failed} failed.");
        return failed;
    }

    private static async Task<List<YouTubeVideo>> GetTargetVideosForDescriptionAsync(ParseResult ctx, YouTubeService service, CancellationToken token)
    {
        if (ctx.GetValue(YouTubeVideoIdOption) is { Length: > 0 } explicitYouTubeId)
        {
            if (await GetYouTubeVideoAsync(service, explicitYouTubeId, token) is { } video)
            {
                return [video];
            }

            Console.WriteLine($"No YouTube video found for id '{explicitYouTubeId}'.");
            return [];
        }

        bool hasDbSelector =
            ctx.GetValue(VideoIdOption) > 0 ||
            !string.IsNullOrWhiteSpace(ctx.GetValue(TwitchVideoIdOption)) ||
            ctx.GetValue(InputFileOption) is not null;

        if (hasDbSelector)
        {
            using var dbContext = await StreamingDbContext.CreateAsync(token);
            var dbVideo = await GetVideoAsync(ctx, dbContext, token);
            if (dbVideo is null)
            {
                Console.WriteLine("No video found");
                return [];
            }

            if (string.IsNullOrWhiteSpace(dbVideo.YouTubeId))
            {
                Console.WriteLine($"Video {dbVideo.Id} does not have a YouTube Id");
                return [];
            }

            if (await GetYouTubeVideoAsync(service, dbVideo.YouTubeId, token) is { } youTubeVideo)
            {
                return [youTubeVideo];
            }

            Console.WriteLine($"No YouTube video found for id '{dbVideo.YouTubeId}'.");
            return [];
        }

        return await GetDraftVideosWithTodoMarkerAsync(service, token);
    }

    private static async Task<YouTubeVideo?> GetYouTubeVideoAsync(YouTubeService service, string youTubeId, CancellationToken token)
    {
        var request = service.Videos.List("id,snippet,status");
        request.Id = youTubeId;

        var response = await request.ExecuteAsync(token);
        return response.Items.FirstOrDefault();
    }

    private static async Task<List<YouTubeVideo>> GetDraftVideosWithTodoMarkerAsync(YouTubeService service, CancellationToken token)
    {
        var channelsRequest = service.Channels.List("contentDetails");
        channelsRequest.Mine = true;
        var channelsResponse = await channelsRequest.ExecuteAsync(token);

        string? uploadsPlaylistId = channelsResponse.Items.FirstOrDefault()?.ContentDetails?.RelatedPlaylists?.Uploads;
        if (string.IsNullOrWhiteSpace(uploadsPlaylistId))
        {
            return [];
        }

        HashSet<string> videoIds = [];
        var playlistItemsRequest = service.PlaylistItems.List("contentDetails");
        playlistItemsRequest.PlaylistId = uploadsPlaylistId;
        playlistItemsRequest.MaxResults = 50;

        do
        {
            var playlistItemsResponse = await playlistItemsRequest.ExecuteAsync(token);
            foreach (var item in playlistItemsResponse.Items)
            {
                if (!string.IsNullOrWhiteSpace(item.ContentDetails?.VideoId))
                {
                    videoIds.Add(item.ContentDetails.VideoId);
                }
            }

            playlistItemsRequest.PageToken = playlistItemsResponse.NextPageToken;
        }
        while (!string.IsNullOrWhiteSpace(playlistItemsRequest.PageToken));

        List<YouTubeVideo> draftVideos = [];
        foreach (string[] batch in videoIds.Chunk(50))
        {
            var videosRequest = service.Videos.List("id,snippet,status");
            videosRequest.Id = string.Join(",", batch);
            var videosResponse = await videosRequest.ExecuteAsync(token);

            foreach (var video in videosResponse.Items)
            {
                if (video.Status?.PrivacyStatus?.Equals("private", StringComparison.OrdinalIgnoreCase) == true &&
                    video.Snippet?.Description?.Contains(TodoDescriptionMarker, StringComparison.Ordinal) == true)
                {
                    draftVideos.Add(video);
                }
            }
        }

        return [.. draftVideos.OrderByDescending(x => x.Snippet?.PublishedAtDateTimeOffset ?? DateTimeOffset.MinValue)];
    }

    private static FileInfo? TryFindTranscriptFile(string youTubeId, DirectoryInfo transcriptDirectory, params DateTime[] preferredDates)
    {
        if (string.IsNullOrWhiteSpace(youTubeId))
        {
            return null;
        }

        HashSet<string> candidates = [];
        foreach (DateTime preferredDate in preferredDates)
        {
            candidates.Add(Subtitles.GetMarkdownFileName(youTubeId, preferredDate.Date));
        }

        if (candidates.Count == 0)
        {
            candidates.Add(Subtitles.GetMarkdownFileName(youTubeId, DateTime.Today));
        }

        foreach (string candidate in candidates)
        {
            string path = Path.Combine(transcriptDirectory.FullName, candidate);
            if (File.Exists(path))
            {
                return new FileInfo(path);
            }
        }

        return transcriptDirectory
            .EnumerateFiles($"*-{youTubeId}.md", SearchOption.TopDirectoryOnly)
            .OrderByDescending(x => x.LastWriteTimeUtc)
            .FirstOrDefault()
            ?? transcriptDirectory
                .EnumerateFiles($"{youTubeId}.md", SearchOption.TopDirectoryOnly)
                .OrderByDescending(x => x.LastWriteTimeUtc)
                .FirstOrDefault();
    }

    private static string BuildTranscriptDescriptionPrompt(YouTubeVideo video)
    {
        string title = string.IsNullOrWhiteSpace(video.Snippet?.Title) ? "Untitled" : video.Snippet.Title;
        string description = video.Snippet?.Description ?? string.Empty;
        string currentTags = video.Snippet?.Tags is { Count: > 0 } tags
            ? string.Join(", ", tags)
            : "(none)";
        string allowedTags = string.Join(", ", CommonVideoTags);

        return $$"""
            Generate YouTube metadata from the attached transcript markdown file.

            Return ONLY a valid JSON object with this exact shape:
            {"title":"...","description":"...","tags":["tag1","tag2"]}

            Requirements:
            - Use the transcript as the source of truth.
            - Produce a polished title, description, and tag list.
            - Preserve key context from the current title/description when appropriate.
            - The description MUST NOT contain the token {{TodoDescriptionMarker}}.
            - Do not invent links, sponsors, timestamps, or facts not present in the transcript.
            - Tags must be selected from the allowed tags list only.
            - Return 8-15 tags.

            Video context:
            - YouTube ID: {{video.Id}}
            - Current title: {{title}}
            - Current description:
            {{description}}
            - Current tags: {{currentTags}}
            - Allowed tags: {{allowedTags}}
            """;
    }

    private static bool TryParseGeneratedVideoUpdate(string? messageContent, out GeneratedVideoUpdate update, out string error)
    {
        update = default;
        error = string.Empty;

        if (string.IsNullOrWhiteSpace(messageContent))
        {
            error = "Copilot returned empty content.";
            return false;
        }

        string rawJson = UnwrapCodeFence(messageContent);

        JsonDocument jsonDocument;
        try
        {
            jsonDocument = JsonDocument.Parse(rawJson);
        }
        catch (JsonException ex)
        {
            error = $"Invalid JSON returned by Copilot: {ex.Message}";
            return false;
        }

        using (jsonDocument)
        {
            JsonElement root = jsonDocument.RootElement;
            if (root.ValueKind != JsonValueKind.Object)
            {
                error = "Copilot JSON result was not an object.";
                return false;
            }

            string? generatedTitle = root.TryGetProperty("title", out JsonElement titleElement) ? titleElement.GetString() : null;
            string? generatedDescription = root.TryGetProperty("description", out JsonElement descriptionElement) ? descriptionElement.GetString() : null;

            if (string.IsNullOrWhiteSpace(generatedTitle))
            {
                error = "Generated title was empty.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(generatedDescription))
            {
                error = "Generated description was empty.";
                return false;
            }

            List<string> generatedTags = [];
            if (root.TryGetProperty("tags", out JsonElement tagsElement) &&
                tagsElement.ValueKind == JsonValueKind.Array)
            {
                foreach (JsonElement element in tagsElement.EnumerateArray())
                {
                    if (element.ValueKind == JsonValueKind.String &&
                        element.GetString() is { } tag &&
                        !string.IsNullOrWhiteSpace(tag))
                    {
                        generatedTags.Add(tag.Trim());
                    }
                }
            }

            var normalizedAllowedTags = CommonVideoTags.ToDictionary(
                x => x,
                x => x,
                StringComparer.OrdinalIgnoreCase);

            List<string> filteredTags = [];
            foreach (string tag in generatedTags)
            {
                if (normalizedAllowedTags.TryGetValue(tag, out string? normalizedTag) &&
                    !filteredTags.Contains(normalizedTag, StringComparer.OrdinalIgnoreCase))
                {
                    filteredTags.Add(normalizedTag);
                }
            }

            if (filteredTags.Count == 0)
            {
                filteredTags = [.. CommonVideoTags.Take(10)];
            }

            string cleanedDescription = generatedDescription
                .Replace(TodoDescriptionMarker, string.Empty, StringComparison.Ordinal)
                .Trim();

            update = new GeneratedVideoUpdate(generatedTitle.Trim(), cleanedDescription, filteredTags);
            return true;
        }
    }

    private static string UnwrapCodeFence(string value)
    {
        string trimmed = value.Trim();
        if (!trimmed.StartsWith("```", StringComparison.Ordinal))
        {
            return trimmed;
        }

        int firstNewline = trimmed.IndexOf('\n');
        if (firstNewline < 0)
        {
            return trimmed;
        }

        int lastFence = trimmed.LastIndexOf("```", StringComparison.Ordinal);
        if (lastFence <= firstNewline)
        {
            return trimmed;
        }

        return trimmed[(firstNewline + 1)..lastFence].Trim();
    }

    private static void ApplyGeneratedVideoUpdate(YouTubeVideo video, GeneratedVideoUpdate update)
    {
        video.Snippet ??= new VideoSnippet();
        video.Snippet.Title = update.Title;
        video.Snippet.Description = update.Description;
        video.Snippet.Tags = [.. update.Tags];
    }

    private static async Task SyncYouTubeVideosToDatabase(YouTubeService service, StreamingDbContext dbContext, CancellationToken token)
    {
        DateOnly endDate = DateOnly.FromDateTime(DateTime.UtcNow);
        DateOnly startDate = endDate.AddMonths(-4);

        if (!YouTubePublishedDateRange.TryCreate(startDate, endDate, out var dateRange))
        {
            return;
        }

        Console.WriteLine($"Syncing YouTube videos from {startDate:yyyy-MM-dd} to {endDate:yyyy-MM-dd}...");

        int scanned = 0;
        int inserted = 0;
        int skipped = 0;

        await foreach (var ytVideo in GetChannelVideosPublishedInRangeAsync(service, dateRange, token))
        {
            scanned++;
            bool exists = await dbContext.Videos.AnyAsync(x => x.YouTubeId == ytVideo.VideoId, token);
            if (exists)
            {
                skipped++;
                continue;
            }

            var video = new Video
            {
                YouTubeId = ytVideo.VideoId,
                YouTubePublishTime = ytVideo.PublishedAt,
                TwitchTitle = ytVideo.Title, // Store YouTube title in TwitchTitle for now
            };
            dbContext.Videos.Add(video);
            await dbContext.SaveChangesAsync(token);
            inserted++;
            Console.WriteLine($"  Added YouTube video '{ytVideo.Title}' ({ytVideo.VideoId}) published {ytVideo.PublishedAt:yyyy-MM-dd}");
        }

        Console.WriteLine($"YouTube sync complete: {scanned} scanned, {inserted} added, {skipped} already in database.");
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
        // Get the authenticated user's channel ID - required when using date filters
        var channelsRequest = service.Channels.List("id");
        channelsRequest.Mine = true;
        var channelsResponse = await channelsRequest.ExecuteAsync(token);
        string? channelId = channelsResponse.Items?.FirstOrDefault()?.Id;

        if (string.IsNullOrEmpty(channelId))
        {
            Console.WriteLine("Could not retrieve authenticated user's channel ID.");
            yield break;
        }

        var listVideosRequest = service.Search.List("snippet");
        listVideosRequest.Order = SearchResource.ListRequest.OrderEnum.Date;
        listVideosRequest.ChannelId = channelId;
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
    private readonly record struct GeneratedVideoUpdate(string Title, string Description, IReadOnlyCollection<string> Tags);
}
