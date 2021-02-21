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
                Arguments = $"-i \"{filePath}\" -af silencedetect=n=0.001 -c copy -f null -",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false
            };
            var ffmpegProcess = new Process
            {
                StartInfo = startInfo,
                EnableRaisingEvents = true,
            };
            ffmpegProcess.OutputDataReceived += FfmpegProcess_OutputDataReceived;
            ffmpegProcess.ErrorDataReceived += FfmpegProcess_OutputDataReceived;

            double? silenceEndTime = null;
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
                        ffmpegProcess.OutputDataReceived -= FfmpegProcess_OutputDataReceived;
                        ffmpegProcess.ErrorDataReceived -= FfmpegProcess_OutputDataReceived;

                        ffmpegProcess.Kill();
                    }
                    catch { }
                }
            }

            if (silenceEndTime is null) return "";

            string outputPath = Path.Combine(Path.GetDirectoryName(filePath)!, Path.ChangeExtension(Path.GetFileNameWithoutExtension(filePath) + "_trimmed", Path.GetExtension(filePath)));
            double startSeekTime = silenceEndTime.Value - (minSilence ?? TimeSpan.FromSeconds(2)).TotalSeconds;
            startInfo = new ProcessStartInfo
            {
                FileName = "ffmpeg",
                Arguments = $"-ss \"{startSeekTime:N2}\" -i \"{filePath}\" -c copy -y {outputPath}"
            };

            if (Process.Start(startInfo) is { } ffmpegTrimProcess)
            {
                await ffmpegTrimProcess.WaitForExitAsync(CancellationToken.None);
            }
            return outputPath;
        }
    }
}
