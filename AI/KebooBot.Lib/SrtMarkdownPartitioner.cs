using Microsoft.Extensions.Logging;
using Microsoft.KernelMemory;
using Microsoft.KernelMemory.AI.OpenAI;
using Microsoft.KernelMemory.Configuration;
using Microsoft.KernelMemory.Context;
using Microsoft.KernelMemory.Diagnostics;
using Microsoft.KernelMemory.Pipeline;
using System.Text;
using System.Text.RegularExpressions;
namespace KebooBot.Lib;

public sealed partial class SrtMarkdownPartitioner : IPipelineStepHandler
{
    private readonly IPipelineOrchestrator _orchestrator;
    private readonly TextPartitioningOptions _options;
    private readonly ILogger<SrtMarkdownPartitioner> _log;

    private readonly int _maxTokensPerPartition = int.MaxValue;

    /// <inheritdoc />
    public string StepName { get; }

    /// <summary>
    /// Handler responsible for partitioning text in small chunks.
    /// Note: stepName and other params are injected with DI.
    /// </summary>
    /// <param name="stepName">Pipeline step for which the handler will be invoked</param>
    /// <param name="orchestrator">Current orchestrator used by the pipeline, giving access to content and other helps.</param>
    /// <param name="options">The customize text partitioning option</param>
    /// <param name="loggerFactory">Application logger factory</param>
    public SrtMarkdownPartitioner(
        string stepName,
        IPipelineOrchestrator orchestrator,
        TextPartitioningOptions? options = null,
        ILoggerFactory? loggerFactory = null)
    {
        StepName = stepName;
        _orchestrator = orchestrator;

        _options = options ?? new TextPartitioningOptions();
        _options.Validate();

        _log = (loggerFactory ?? DefaultLogger.Factory).CreateLogger<SrtMarkdownPartitioner>();
        _log.LogInformation("Handler '{StepName}' ready", stepName);

        if (orchestrator.EmbeddingGenerationEnabled)
        {
            foreach (var gen in orchestrator.GetEmbeddingGenerators())
            {
                // Use the last tokenizer (TODO: revisit)
                _maxTokensPerPartition = Math.Min(gen.MaxTokens, _maxTokensPerPartition);
            }

            if (_options.MaxTokensPerParagraph > _maxTokensPerPartition)
            {
                throw ParagraphsTooBigForEmbeddingsException(_options.MaxTokensPerParagraph, _maxTokensPerPartition, _log);
            }
        }
    }

    /// <inheritdoc />
    public async Task<(bool success, DataPipeline updatedPipeline)> InvokeAsync(
        DataPipeline pipeline, CancellationToken cancellationToken = default)
    {
        _log.LogDebug("Partitioning text, pipeline '{Index}/{DocumentId}'", pipeline.Index, pipeline.DocumentId);

        if (pipeline.Files.Count == 0)
        {
            _log.LogWarning("Pipeline '{Index}/{DocumentId}': there are no files to process, moving to next pipeline step.", pipeline.Index, pipeline.DocumentId);
            return (true, pipeline);
        }

        var context = pipeline.GetContext();

        // Allow to override the paragraph size using context arguments
        var maxTokensPerParagraph = context.GetCustomPartitioningMaxTokensPerParagraphOrDefault(_options.MaxTokensPerParagraph);
        if (maxTokensPerParagraph > _maxTokensPerPartition)
        {
            throw ParagraphsTooBigForEmbeddingsException(maxTokensPerParagraph, _maxTokensPerPartition, _log);
        }

        // Allow to override the number of overlapping tokens using context arguments
        var overlappingTokens = Math.Max(0, context.GetCustomPartitioningOverlappingTokensOrDefault(_options.OverlappingTokens));

        string? chunkHeader = context.GetCustomPartitioningChunkHeaderOrDefault(null);

        foreach (DataPipeline.FileDetails uploadedFile in pipeline.Files)
        {
            // Track new files being generated (cannot edit originalFile.GeneratedFiles while looping it)
            Dictionary<string, DataPipeline.GeneratedFileDetails> newFiles = new();

            foreach (KeyValuePair<string, DataPipeline.GeneratedFileDetails> generatedFile in uploadedFile.GeneratedFiles)
            {
                var file = generatedFile.Value;
                if (file.AlreadyProcessedBy(this))
                {
                    _log.LogTrace("File {FileName} already processed by this handler", file.Name);
                    continue;
                }

                // Partition only the original text
                if (file.ArtifactType != DataPipeline.ArtifactTypes.ExtractedText)
                {
                    _log.LogTrace("Skipping file {FileName} (not original text)", file.Name);
                    continue;
                }

                // Use a different partitioning strategy depending on the file type
                BinaryData partitionContent = await _orchestrator.ReadFileAsync(pipeline, file.Name, cancellationToken).ConfigureAwait(false);

                // Skip empty partitions. Also: partitionContent.ToString() throws an exception if there are no bytes.
                if (partitionContent.ToArray().Length == 0) { continue; }

                _log.LogDebug("Partitioning MarkDown file {FileName}", file.Name);
                string content = partitionContent.ToString();

                //TODO: Overlap the sections, look at splitting up based on time.
                const int maxTokenLength = 250;

                StringBuilder allText = new();
                string? url = null;
                int tokenCount = 0;
                foreach (Match match in MatchLineRegex().Matches(content))
                {
                    string line = match.Groups["Text"].Value + " ";
                    if (string.Equals("YouTube Video", line, StringComparison.OrdinalIgnoreCase)) continue;

                    url ??= match.Groups["Url"].Value;

                    tokenCount += DefaultGPTTokenizer.StaticCountTokens(line);
                    allText.Append(line);

                    if (tokenCount > maxTokenLength)
                    {
                        await MakeChunkAsync();
                    }
                }

                if (allText.Length > 0)
                {
                    await MakeChunkAsync();
                }

                async Task MakeChunkAsync()
                {
                    // TODO: turn partitions in objects with more details, e.g. page number
                    string text = allText.ToString();
                    int sectionNumber = 0; // TODO: use this to store the page number (if any)
                    int partitionNumber = newFiles.Count;
                    BinaryData textData = new(text);

                    var destFile = uploadedFile.GetPartitionFileName(partitionNumber);
                    await _orchestrator.WriteFileAsync(pipeline, destFile, textData, cancellationToken).ConfigureAwait(false);

                    TagCollection tags = pipeline.Tags.Clone();
                    tags["url"] = [url ?? ""];

                    var destFileDetails = new DataPipeline.GeneratedFileDetails
                    {
                        Id = Guid.NewGuid().ToString("N"),
                        ParentId = uploadedFile.Id,
                        Name = destFile,
                        Size = text.Length,
                        MimeType = MimeTypes.MarkDown,
                        ArtifactType = DataPipeline.ArtifactTypes.TextPartition,
                        PartitionNumber = partitionNumber,
                        SectionNumber = sectionNumber,
                        Tags = tags,
                        ContentSHA256 = textData.CalculateSHA256(),
                    };
                    newFiles.Add(destFile, destFileDetails);
                    destFileDetails.MarkProcessedBy(this);

                    allText.Clear();
                    url = null;
                    tokenCount = 0;
                }

                file.MarkProcessedBy(this);
            }

            // Add new files to pipeline status
            foreach (var file in newFiles)
            {
                uploadedFile.GeneratedFiles.Add(file.Key, file.Value);
            }
        }

        return (true, pipeline);
    }

#pragma warning disable CA2254 // the msg is always used
    private static ConfigurationException ParagraphsTooBigForEmbeddingsException(int value, int limit, ILogger logger)
    {
        var errMsg = $"The configured partition size ({value} tokens) is too big for one " +
                     $"of the embedding generators in use. The max value allowed is {limit} tokens. " +
                     $"Consider changing the partitioning options, see https://microsoft.github.io/kernel-memory/how-to/custom-partitioning for details.";
        logger.LogError(errMsg);
        return new ConfigurationException(errMsg);
    }
#pragma warning restore CA2254

    [GeneratedRegex(@"^\[(?<Text>[^\]]*)\]\((?<Url>[^\)]*)\)", RegexOptions.Multiline)]
    private static partial Regex MatchLineRegex();
}

