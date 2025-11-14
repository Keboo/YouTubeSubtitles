# Subtitle Migration Analysis

## Summary
**The subtitle conversion functionality has ALREADY been fully migrated to Keboo.Editor!**

The `youtube subtitles` command in `Keboo.Editor/YouTubeCommand.cs` provides complete equivalent functionality to the old `SubtitleConverter` tool.

## Command Usage

### Old Tool (SubtitleConverter)
```bash
cd SubtitleConverter/SubtitleConverter
dotnet run -- --output-directory <path> \
  --azure-storage-account-key <key> \
  --you-tube-client-id <id> \
  --you-tube-client-secret <secret> \
  [--you-tube-video-id <id>]
```

### New Tool (Keboo.Editor)
```bash
cd SubtitleConverter/Keboo.Editor
dotnet run youtube subtitles \
  --output-directory <path> \
  [--video-id <id> | --twitch-id <id> | --all]
```

## Feature Comparison

| Feature | Old SubtitleConverter | New Keboo.Editor | Status |
|---------|----------------------|------------------|---------|
| Download YouTube subtitles | ✅ | ✅ | ✅ Migrated |
| Convert SRT to Markdown | ✅ | ✅ | ✅ Migrated |
| Write markdown files | ✅ | ✅ | ✅ Migrated |
| Update YouTube descriptions | ✅ | ✅ | ✅ Migrated |
| Track subtitle URLs | ✅ (Azure Table) | ✅ (EF Core DB) | ✅ Improved |
| Process all videos | ✅ | ✅ (`--all` flag) | ✅ Migrated |
| Process single video | ✅ | ✅ (`--video-id` or `--twitch-id`) | ✅ Migrated |
| Requires Azure credentials | ❌ Yes | ✅ No | ✅ Improved |

## Code Location

### Old Implementation
- **File:** `SubtitleConverter/SubtitleConverter/Program.cs`
- **Lines:** 68-178
- **Storage:** Azure Table Storage (`VideoRow`)

### New Implementation
- **File:** `SubtitleConverter/Keboo.Editor/YouTubeCommand.cs`
- **Lines:** 79-365 (subtitles command), 247-365 (GenerateSubtitles method)
- **Storage:** Entity Framework (`StreamingDbContext`, `Video` entity)

## Shared Core Logic (StreamingTools Library)

Both implementations use the same core functionality from the `StreamingTools` library:

1. **YouTubeServiceMixins.GetSrtSubtitles()** - Downloads SRT subtitles from YouTube
2. **Subtitles.ConvertSrtToMarkdown()** - Converts SRT format to markdown with timestamps
3. **Subtitles.GetMarkdownFileName()** - Generates consistent filename format
4. **GitHelper.GetRemoteUrl()** - Gets GitHub repository URL for subtitle links

## Advantages of New Implementation

1. **Modern Database:** Uses Entity Framework Core instead of Azure Table Storage
2. **Integrated:** Works with the same Video database used by other commands
3. **No Azure Dependency:** Doesn't require Azure storage account credentials
4. **Better Organization:** Part of a cohesive CLI with twitch, video, and youtube commands
5. **Flexible Filtering:** Can process by video ID, Twitch ID, or all videos

## Migration Status

✅ **COMPLETE** - No additional code changes needed.

The old `SubtitleConverter` tool can be deprecated in favor of the `Keboo.Editor youtube subtitles` command.

## Recommendation

Update documentation and workflows to use:
```bash
dotnet run -- youtube subtitles --all --output-directory ../../Subtitles
```

Instead of the old UpdateSubtitles.ps1 script which references non-existent `--playlist` parameters.
