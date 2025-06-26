using StreamingTools.Data;

namespace Keboo.Editor;

public record VideoData(int VideoId, FileInfo DownloadedFile, FileInfo? TrimmedFile);
