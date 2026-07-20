using System.ComponentModel;
using System.Diagnostics;
using System.Text.Json;

namespace StreamingTools.Copilot;

public static class CopilotCli
{
    public static async Task<CopilotPromptResult> ExecutePromptWithAttachmentAsync(
        string prompt,
        FileInfo attachmentFile,
        string model,
        CancellationToken token = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(prompt);
        ArgumentNullException.ThrowIfNull(attachmentFile);

        if (!attachmentFile.Exists)
        {
            throw new FileNotFoundException("Attachment file was not found.", attachmentFile.FullName);
        }

        string resolvedModel = string.IsNullOrWhiteSpace(model) ? "auto" : model;

        try
        {
            return await ExecutePromptWithAttachmentCoreAsync(
                "copilot",
                prefixWithGhCopilot: false,
                prompt,
                attachmentFile,
                resolvedModel,
                token);
        }
        catch (Win32Exception)
        {
            return await ExecutePromptWithAttachmentCoreAsync(
                "gh",
                prefixWithGhCopilot: true,
                prompt,
                attachmentFile,
                resolvedModel,
                token);
        }
    }

    private static async Task<CopilotPromptResult> ExecutePromptWithAttachmentCoreAsync(
        string fileName,
        bool prefixWithGhCopilot,
        string prompt,
        FileInfo attachmentFile,
        string model,
        CancellationToken token)
    {
        ProcessStartInfo startInfo = new()
        {
            FileName = fileName,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false
        };

        if (prefixWithGhCopilot)
        {
            startInfo.ArgumentList.Add("copilot");
            startInfo.ArgumentList.Add("--");
        }

        startInfo.ArgumentList.Add("-p");
        startInfo.ArgumentList.Add(prompt);
        startInfo.ArgumentList.Add("--attachment");
        startInfo.ArgumentList.Add(attachmentFile.FullName);
        startInfo.ArgumentList.Add("--silent");
        startInfo.ArgumentList.Add("--allow-all-tools");
        startInfo.ArgumentList.Add("--no-color");
        startInfo.ArgumentList.Add("--output-format");
        startInfo.ArgumentList.Add("json");
        startInfo.ArgumentList.Add("--model");
        startInfo.ArgumentList.Add(model);

        using Process process = new() { StartInfo = startInfo };
        if (!process.Start())
        {
            throw new InvalidOperationException($"Failed to start '{fileName}'.");
        }

        Task<string> standardOutputTask = process.StandardOutput.ReadToEndAsync();
        Task<string> standardErrorTask = process.StandardError.ReadToEndAsync();

        await process.WaitForExitAsync(token);
        string standardOutput = await standardOutputTask;
        string standardError = await standardErrorTask;

        return new CopilotPromptResult(
            process.ExitCode,
            standardOutput,
            standardError,
            ExtractAssistantMessage(standardOutput));
    }

    private static string? ExtractAssistantMessage(string standardOutput)
    {
        string? generatedMessage = null;
        using StringReader reader = new(standardOutput);
        string? line;
        while ((line = reader.ReadLine()) is not null)
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                continue;
            }

            try
            {
                using JsonDocument document = JsonDocument.Parse(line);
                if (!document.RootElement.TryGetProperty("type", out JsonElement typeElement) ||
                    !string.Equals(typeElement.GetString(), "assistant.message", StringComparison.Ordinal))
                {
                    continue;
                }

                if (document.RootElement.TryGetProperty("data", out JsonElement dataElement) &&
                    dataElement.TryGetProperty("content", out JsonElement contentElement) &&
                    contentElement.ValueKind == JsonValueKind.String &&
                    contentElement.GetString() is { } content &&
                    !string.IsNullOrWhiteSpace(content))
                {
                    generatedMessage = content;
                }
            }
            catch (JsonException)
            {
                // Keep scanning; some lines may not be JSON if the CLI changes behavior.
            }
        }

        return generatedMessage?.Trim() ?? standardOutput.Trim();
    }
}

public readonly record struct CopilotPromptResult(
    int ExitCode,
    string StandardOutput,
    string StandardError,
    string? MessageContent)
{
    public bool Success => ExitCode == 0;
}
