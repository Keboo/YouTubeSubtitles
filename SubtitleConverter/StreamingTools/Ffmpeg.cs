using System.Collections.Concurrent;

namespace StreamingTools;

public static class Ffmpeg
{
    private static readonly Regex SilenceStartRegex = new(@"silence_start:\s*(?<StartTime>\d+\.?\d*)");
    private static readonly Regex SilenceEndRegex = new(@"silence_end:\s*(?<EndTime>\d+\.?\d*)\s*\|");

    public static async Task<FileInfo?> TrimSilence(
        FileInfo filePath,
       TimeSpan? minStartSilence = null,
       TimeSpan? minEndSilence = null,
       Action<string>? log = null)
    {
        string outputPath = Path.Combine(filePath.DirectoryName!, Path.ChangeExtension(Path.GetFileNameWithoutExtension(filePath.Name) + "_trimmed", filePath.Extension));
        if (await TrimSilenceAsync(filePath, new FileInfo(outputPath), minStartSilence, minEndSilence, log))
        {
            File.Move(outputPath, filePath.FullName, true);
        }
        return filePath;
    }

    public static async Task<bool> TrimSilenceAsync(
        FileInfo filePath,
        FileInfo outputFile,
        TimeSpan? minStartSilence = null,
        TimeSpan? minEndSilence = null,
        Action<string>? log = null)
    {
        log?.Invoke($"Trimming silence from {filePath.FullName} => {outputFile.FullName} ({DateTime.Now})");
        var startInfo = new ProcessStartInfo
        {
            FileName = "ffmpeg",
            Arguments = $"-i \"{filePath}\" -af silencedetect=n=-55dB -f null -",
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false
        };
        List<(double StartTime, double EndTime)> silenceRegions = [];

        log?.Invoke($"Running {startInfo.FileName} {startInfo.Arguments} ({DateTime.Now})");

        using (var ffmpegProcess = new Process
        {
            StartInfo = startInfo,
            EnableRaisingEvents = true,
        })
        {
            BlockingCollection<string?> lines = [];

            ffmpegProcess.OutputDataReceived += FfmpegProcess_OutputDataReceived;
            ffmpegProcess.ErrorDataReceived += FfmpegProcess_OutputDataReceived;

            if (!ffmpegProcess.Start()) return false;
            ffmpegProcess.BeginOutputReadLine();
            ffmpegProcess.BeginErrorReadLine();

            Task ffmpegProcessTask = ffmpegProcess.WaitForExitAsync(CancellationToken.None)
                .ContinueWith(t => lines.CompleteAdding());
            silenceRegions = GetSilenceRegions(lines);
            await ffmpegProcessTask;

            void FfmpegProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
            {
                lines.Add(e.Data);
            }
        }

        foreach (var process in Process.GetProcessesByName("ffmpeg"))
        {
            try
            {
                process.Kill();
            }
            catch { }
        }

        if (silenceRegions.Count == 0)
        {
            log?.Invoke("Did not find any silence");
            return false;
        }

        (double startSeekTime, double? endSeekTime) = GetSeekRegion(silenceRegions, minStartSilence, minEndSilence);

        StringBuilder argumentBuilder = new();
        argumentBuilder.Append($"-ss \"{startSeekTime:N2}\" ");

        if (endSeekTime is not null)
        {
            argumentBuilder.Append($"-to \"{endSeekTime}\" ");
        }

        argumentBuilder.Append($"-i \"{filePath}\" -c copy -loglevel error -y \"{outputFile.FullName}\"");

        startInfo = new ProcessStartInfo
        {
            FileName = "ffmpeg",
            Arguments = argumentBuilder.ToString()
        };

        log?.Invoke($"Running {startInfo.FileName} {startInfo.Arguments} ({DateTime.Now})");

        if (Process.Start(startInfo) is { } ffmpegTrimProcess)
        {
            await ffmpegTrimProcess.WaitForExitAsync(CancellationToken.None);
            log?.Invoke($"Trimmed silence => {outputFile.FullName} ({DateTime.Now})");
            return true;
        }
        log?.Invoke("Failed to trim silence");
        return false;
    }

    public static List<(double StartTime, double EndTime)> GetSilenceRegions(BlockingCollection<string?> provideLines)
    {
        double? lastStartTime = null;
        List<(double StartTime, double EndTime)> silenceRegions = new();
        foreach (var line in provideLines.GetConsumingEnumerable())
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                continue;
            }
            if (SilenceStartRegex.Match(line) is { } startMatch &&
                startMatch.Success &&
                double.TryParse(startMatch.Groups["StartTime"].Value, out double startTime))
            {
                lastStartTime = startTime;
            }
            else if (SilenceEndRegex.Match(line) is { } endMatch &&
                endMatch.Success &&
                double.TryParse(endMatch.Groups["EndTime"].Value, out double endTime) &&
                lastStartTime is { } lastStart)
            {
                silenceRegions.Add((lastStart, endTime));
                lastStartTime = null;
            }
        }
        return silenceRegions;
    }

    public static (double StartTime, double? EndTime) GetSeekRegion(
        List<(double StartTime, double EndTime)> silenceRegions,
        TimeSpan? minStartSilence = null,
        TimeSpan? minEndSilence = null)
    {
        for (int i = 0; i < silenceRegions.Count - 1; i++)
        {
            //Combine close silence regions
            if (silenceRegions[i + 1].StartTime - silenceRegions[i].EndTime <= TimeSpan.FromSeconds(10).TotalSeconds)
            {
                silenceRegions[i] = (silenceRegions[i].StartTime, silenceRegions[i + 1].EndTime);
                silenceRegions.RemoveAt(i + 1);
                i--;
            }
        }

        double startSeekTime = silenceRegions[0].EndTime - (minStartSilence ?? TimeSpan.FromSeconds(2)).TotalSeconds;
        double? endSeekTime = null;

        if (silenceRegions.Count > 1)
        {
            endSeekTime = silenceRegions.Last().StartTime + (minEndSilence ?? TimeSpan.FromSeconds(15)).TotalSeconds;
        }

        return (startSeekTime, endSeekTime);
    }
}
