This is simply a reposity for me to store captions from my [YouTube videos](http://youtube.keboo.dev).

The idea was to have a simple set of text documents that I can search to be able to find content inside of my videos.

## Generate a YouTube description from a transcript

After a video is uploaded to YouTube and captions are available, download subtitles first, then generate a description draft with Copilot CLI:

```powershell
dotnet run --project .\SubtitleConverter\Keboo.Editor\Keboo.Editor.csproj -- youtube subtitles --video-id <videoId> --output-directory .\Subtitles
dotnet run --project .\SubtitleConverter\Keboo.Editor\Keboo.Editor.csproj -- youtube description --youtube-id <youTubeId> --transcript-directory .\Subtitles --model auto
```

New uploads include the marker `###TODO_DESCRIPTIOON###` in the initial YouTube description.

If `youtube description` is run **without** `--youtube-id` (and without `--video-id`/`--twitch-id`), it pulls all draft/private channel videos containing that marker and updates each video's **title, description, and tags** from transcript-based Copilot output.
