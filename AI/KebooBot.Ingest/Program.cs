using System.CommandLine;
using System.Net.Http.Json;

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

            List<(string Index, string DocumentId)> pendingDocuments = new();
            if (!string.IsNullOrWhiteSpace(fileName))
            {
                FileInfo file = new(Path.Combine(directory.FullName, fileName));
                if (!file.Exists)
                {
                    throw new FileNotFoundException($"File {file.FullName} not found");
                }
                if (await IngestFileAsync(file, client, token) is { } result)
                {
                    pendingDocuments.Add(result);
                }

            }
            else
            {
                var markdownFiles = directory.GetFiles("*.md");
                int fileCount = 1;
                foreach (FileInfo file in markdownFiles)
                {
                    if (await IngestFileAsync(file, client, token) is { } result)
                    {
                        pendingDocuments.Add(result);
                    }
                    Console.WriteLine($"Completed {fileCount++} of {markdownFiles.Length}");
                }
            }

            Console.WriteLine("Waiting for completion");
            while (pendingDocuments.Count > 0)
            {
                var currentPendingDocuments = pendingDocuments.ToList();
                await Task.WhenAll(currentPendingDocuments.Select(async x =>
                {
                    if (await IsCompleteAsync(x.Index, x.DocumentId))
                    {
                        lock (pendingDocuments)
                        {
                            pendingDocuments.Remove(x);
                        }
                    }
                }));
                Console.WriteLine($"Pending documents: {pendingDocuments.Count}");
            }

            async Task<bool> IsCompleteAsync(string index, string documentId)
            {
                var content = await client.GetFromJsonAsync<UploadStatus>($"upload-status?index={index}&documentId={documentId}", token);
                if (content?.failed == true)
                {
                    Console.WriteLine($"Failed to ingest document {documentId}");
                    return true;
                }
                return content?.completed == true;
            }
        });
        return new CliConfiguration(rootCommand);
    }

    private static async Task<(string Index, string DocumentId)?> IngestFileAsync(FileInfo file, HttpClient client, CancellationToken token)
    {
        Console.WriteLine($"Ingesting file '{file}'");
        using var fileStream = file.OpenRead();
        using MultipartFormDataContent formData = new()
        {
            { new StreamContent(fileStream), "Files", file.Name },
            { new StringContent("default"), "index" },
            { new StringContent(Guid.NewGuid().ToString()), "documentId" }
        };
        var response = await client.PostAsync("upload", formData, token);
        response.EnsureSuccessStatusCode();

        var postResponse = await response.Content.ReadFromJsonAsync<PostResponse>();

        if (string.IsNullOrWhiteSpace(postResponse?.documentId))
        {
            Console.WriteLine($"Did not get document id from upload of {file.Name}");
            return null;
        }
        Console.WriteLine($"Queued document {postResponse.documentId} for index {postResponse.index}");

        return (postResponse.index, postResponse.documentId);
        /*
        Console.WriteLine("Waiting for completion");
        bool? isComplete;
        do
        {
            var content = await client.GetFromJsonAsync<UploadStatus>($"upload-status?index={postResponse.index}&documentId={postResponse.documentId}", token);
            isComplete = content?.completed;

            if (content?.failed == true)
            {
                Console.WriteLine($"Failed to ingest file {file.Name}");
                return;
            }
        }
        while (isComplete != true);
        */
    }
}


public class PostResponse
{
    public string index { get; set; }
    public string documentId { get; set; }
    public string message { get; set; }
}



public class UploadStatus
{
    public bool completed { get; set; }
    public bool failed { get; set; }
    public bool empty { get; set; }
    public string index { get; set; }
    public string document_id { get; set; }

    public DateTime creation { get; set; }
    public DateTime last_update { get; set; }
    public string[] steps { get; set; }
    public string[] completed_steps { get; set; }
}