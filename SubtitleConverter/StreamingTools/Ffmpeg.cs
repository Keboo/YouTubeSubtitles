using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace StreamingTools
{
    public static class Ffmpeg
    {
        private static readonly Regex SilenceStartRegex = new(@"silence_start:\s*(?<StartTime>\d+\.?\d*)");
        private static readonly Regex SilenceEndRegex = new(@"silence_end:\s*(?<EndTime>\d+\.?\d*)\s*\|");

        public static async Task<FileInfo?> TrimLeadingSilence(FileInfo filePath, 
            TimeSpan? minStartSilence = null,
            TimeSpan? minEndSilence = null)
        {
            var startInfo = new ProcessStartInfo
            {
                FileName = "ffmpeg",
                Arguments = $"-i \"{filePath}\" -af silencedetect=n=0.001 -f null -",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false
            };
            List<(double StartTime, double EndTime)> silenceRegions = new();

            using (var ffmpegProcess = new Process
            {
                StartInfo = startInfo,
                EnableRaisingEvents = true,
            })
            {
                double? lastStartTime = null;
                ffmpegProcess.OutputDataReceived += FfmpegProcess_OutputDataReceived;
                ffmpegProcess.ErrorDataReceived += FfmpegProcess_OutputDataReceived;

                if (!ffmpegProcess.Start()) return null;
                ffmpegProcess.BeginOutputReadLine();
                ffmpegProcess.BeginErrorReadLine();

                await ffmpegProcess.WaitForExitAsync(CancellationToken.None);

                void FfmpegProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
                {
                    if (e.Data?.ToString() is { } line)
                    {
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
                }
            }

            foreach(var process in Process.GetProcessesByName("ffmpeg"))
            {
                try
                {
                    process.Kill();
                }
                catch { }
            }

            if (silenceRegions.Count == 0) return null;

            double startSeekTime = silenceRegions[0].EndTime - (minStartSilence ?? TimeSpan.FromSeconds(2)).TotalSeconds;

            StringBuilder argumentBuilder = new();
            argumentBuilder.Append($"-ss \"{startSeekTime:N2}\" ");
            if (silenceRegions.Count > 1)
            {
                double endSeekTime = silenceRegions.Last().StartTime + (minEndSilence ?? TimeSpan.FromSeconds(18)).TotalSeconds;
                argumentBuilder.Append($"-to \"{endSeekTime}\" ");
            }

            string outputPath = Path.Combine(filePath.DirectoryName!, Path.ChangeExtension(Path.GetFileNameWithoutExtension(filePath.Name) + "_trimmed", filePath.Extension));
            argumentBuilder.Append($"-i \"{filePath}\" -c copy -loglevel error -y {outputPath}");

            startInfo = new ProcessStartInfo
            {
                FileName = "ffmpeg",
                Arguments = argumentBuilder.ToString()
            };

            if (Process.Start(startInfo) is { } ffmpegTrimProcess)
            {
                await ffmpegTrimProcess.WaitForExitAsync(CancellationToken.None);
            }
            File.Move(outputPath, filePath.FullName, true);
            return new FileInfo(filePath.FullName);
        }
    }
}
