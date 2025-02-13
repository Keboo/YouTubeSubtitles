using Microsoft.KernelMemory.DataFormats;
using Microsoft.KernelMemory.Pipeline;
using Microsoft.KernelMemory.AI.OpenAI;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.KernelMemory.AI;

namespace KebooBot.Api;

public partial class SrtMarkdownDecoder : IContentDecoder
{
    public Task<FileContent> DecodeAsync(string filename, CancellationToken cancellationToken = default)
    {
        using var fs = File.OpenRead(filename);
        return DecodeAsync(fs, cancellationToken);
    }

    public Task<FileContent> DecodeAsync(BinaryData data, CancellationToken cancellationToken = default)
    {
        return DecodeAsync(data.ToStream(), cancellationToken);
    }

    public async Task<FileContent> DecodeAsync(Stream data, CancellationToken cancellationToken = default)
    {
        using var reader = new StreamReader(data);
        //Throw away the header line
        _ = await reader.ReadLineAsync(cancellationToken);
        var text = await reader.ReadToEndAsync(cancellationToken);

        List<Chunk> sections = [];
        const int maxTokenLength = 250;

        StringBuilder allText = new();
        int tokenCount = 0;
        GPT4Tokenizer tokenizer = new();
        foreach (Match match in MatchLineRegex().Matches(text))
        {
            string line = match.Groups["Text"].Value + " ";
            string url = match.Groups["Url"].Value;

            tokenCount += tokenizer.CountTokens(line);
            allText.Append(line);

            if (tokenCount > maxTokenLength)
            {
                sections.Add(new Chunk(allText.ToString(), sections.Count));
                allText.Clear();
                tokenCount = 0;
            }
        }

        if (allText.Length > 0)
        {
            sections.Add(new Chunk(allText.ToString(), sections.Count));
        }

        return new FileContent(MimeTypes.MarkDown)
        {
            Sections = sections,
        };
    }


    public bool SupportsMimeType(string mimeType) => mimeType == MimeTypes.MarkDown;

    [GeneratedRegex(@"^\[(?<Text>[^\]]*)\]\((?<Url>[^\)]*)\)", RegexOptions.Multiline)]
    private static partial Regex MatchLineRegex();
}
