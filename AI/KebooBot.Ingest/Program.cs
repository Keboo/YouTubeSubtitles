using System.CommandLine;

namespace KebooBot.Ingest;

public sealed class Program
{
    private static Task<int> Main(string[] args)
    {
        CliConfiguration configuration = GetConfiguration();
        return configuration.InvokeAsync(args);
    }

    public static CliConfiguration GetConfiguration()
    {
        CliOption<string> fileNameOption = new("--file-name", "-f")
        {
            Description = "The name of the file to ingest"
        };
        CliOption<DirectoryInfo> directoryOption = new("--directory", "-d")
        {
            Description = "The directory that contains the markdown files to ingest",
            Required = true
        };
        directoryOption.AcceptExistingOnly();
        CliOption<string> apiKeyOption = new("--api-key", "-k")
        {
            Description = "The API key",
            Required = true
        };
        CliOption<string> ingestEndpoint = new("--endpoint", "-e")
        {
            Description = "The ingest endpoint",
            Required = true
        };

        CliRootCommand rootCommand = new("A starter console app by Keboo")
        {
            fileNameOption,
            directoryOption,
            apiKeyOption,
            ingestEndpoint
        };

        rootCommand.SetAction(async (ParseResult parseResult, CancellationToken token) =>
        {
            string? fileName = parseResult.CommandResult.GetValue(fileNameOption);
            DirectoryInfo directory = parseResult.CommandResult.GetValue(directoryOption)!;
            string apiKey = parseResult.CommandResult.GetValue(apiKeyOption)!;
            string uri = parseResult.CommandResult.GetValue(ingestEndpoint)!;

            HttpClient client = new();
            client.BaseAddress = new Uri(uri);
            client.DefaultRequestHeaders.Add("User-Agent", "KebooBot");
            client.DefaultRequestHeaders.Add("Authorization", apiKey);

            if (fileName is not null)
            {
                FileInfo file = new(Path.Combine(directory.FullName, fileName));
                if (!file.Exists)
                {
                    throw new FileNotFoundException($"File {file.FullName} not found");
                }
                await IngestFileAsync(file, client, token);
            }
            else
            {
                var markdownFiles = directory.GetFiles("*.md");
                int fileCount = 1;
                foreach (FileInfo file in markdownFiles)
                {
                    await IngestFileAsync(file, client, token);
                    Console.WriteLine($"Completed {fileCount++} of {markdownFiles.Length}");
                }
            }

        });
        return new CliConfiguration(rootCommand);
    }

    private static async Task IngestFileAsync(FileInfo file, HttpClient client, CancellationToken token)
    {
        Console.WriteLine($"Ingesting file '{file}'");
        using var fileStream = file.OpenRead();
        using MultipartFormDataContent formData = new()
        {
            { new StreamContent(fileStream), "Files", file.Name },
            { new StringContent("default"), "index" },
            { new StringContent(Guid.NewGuid().ToString()), "documentId" }
        };
        var response = await client.PostAsync("/upload", formData, token);
        response.EnsureSuccessStatusCode();
    }
}