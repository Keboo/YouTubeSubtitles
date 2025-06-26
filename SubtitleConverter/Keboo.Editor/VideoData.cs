using StreamingTools.Data;

namespace Keboo.Editor;

public record VideoData(Video Video, FileInfo DownloadedFile, FileInfo? TrimmedFile);
