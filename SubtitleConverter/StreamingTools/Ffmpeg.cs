using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace StreamingTools
{
    public static class Ffmpeg
    {
        private static readonly Regex SilenceEndRegex = new(@"silence_end:\s*(?<EndTime>\d+\.?\d*)\s*\|");

        public static async Task<string> TrimLeadingSilence(string filePath, TimeSpan? minSilence = null)
        {
            var startInfo = new ProcessStartInfo
            {
                FileName = "ffmpeg",
                Arguments = $"-i \"{filePath}\" -af silencedetect=n=0.001 -f null -",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false
            };
            double? silenceEndTime = null;
            using (var ffmpegProcess = new Process
            {
                StartInfo = startInfo,
                EnableRaisingEvents = true,
            })
            {
                ffmpegProcess.OutputDataReceived += FfmpegProcess_OutputDataReceived;
                ffmpegProcess.ErrorDataReceived += FfmpegProcess_OutputDataReceived;

                if (!ffmpegProcess.Start()) return "";
                ffmpegProcess.BeginOutputReadLine();
                ffmpegProcess.BeginErrorReadLine();

                await ffmpegProcess.WaitForExitAsync(CancellationToken.None);
                void FfmpegProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
                {
                    if (e.Data?.ToString() is { } line &&
                        SilenceEndRegex.Match(line) is { } match &&
                        match.Success)
                    {
                        silenceEndTime = double.Parse(match.Groups["EndTime"].Value);
                        try
                        {
                            ffmpegProcess.Kill();
                        }
                        catch { }
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

            if (silenceEndTime is null) return "";

            double startSeekTime = silenceEndTime.Value - (minSilence ?? TimeSpan.FromSeconds(2)).TotalSeconds;
            string outputPath = Path.Combine(Path.GetDirectoryName(filePath)!, Path.ChangeExtension(Path.GetFileNameWithoutExtension(filePath) + "_trimmed", Path.GetExtension(filePath)));
            startInfo = new ProcessStartInfo
            {
                FileName = "ffmpeg",
                Arguments = $"-ss \"{startSeekTime:N2}\" -i \"{filePath}\" -c copy -loglevel error -y {outputPath}"
            };

            if (Process.Start(startInfo) is { } ffmpegTrimProcess)
            {
                await ffmpegTrimProcess.WaitForExitAsync(CancellationToken.None);
            }
            return outputPath;
        }
    }
}
