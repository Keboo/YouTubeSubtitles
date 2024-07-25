using Microsoft.KernelMemory;
using Microsoft.KernelMemory.Handlers;

namespace KebooBot.Api;

public static class AiServices
{
    public static void AddAiServices(this IServiceCollection services)
    {
        services.AddSingleton<IKernelMemory>(sp =>
        {
            IConfiguration configuration = sp.GetRequiredService<IConfiguration>();
            MemoryServerless memory = new KernelMemoryBuilder()
                .WithPostgresMemoryDb(new PostgresConfig()
                {
                    ConnectionString = configuration["Azure:AI:PostgresConnectionString"]!
                })
                .WithAzureOpenAITextEmbeddingGeneration(new AzureOpenAIConfig()
                {
                    APIKey = configuration["Azure:AI:OpenAIKey"]!,
                    Endpoint = configuration["Azure:AI:OpenAIEndpoint"]!,
                    Auth = AzureOpenAIConfig.AuthTypes.APIKey,
                    Deployment = "keboobot-embeddings"
                })
                .WithAzureBlobsDocumentStorage(new AzureBlobsConfig()
                {
                    ConnectionString = configuration["Azure:AI:BlobConnectionString"]!,
                    Auth = AzureBlobsConfig.AuthTypes.ConnectionString,
                    Container = "keboobot"
                })
                .WithSimpleQueuesPipeline()
                .WithoutTextGenerator()
                .WithoutDefaultHandlers()
                //.WithContentDecoder<SrtMarkdownDecoder>()
                .Build<MemoryServerless>();

            var syncOrchestrator = memory.Orchestrator;

            syncOrchestrator.AddHandler<TextExtractionHandler>("extract");
            //syncOrchestrator.AddHandler<TextPartitioningHandler>("partition");
            syncOrchestrator.AddHandler<SrtMarkdownPartitioner>("partition");
            //syncOrchestrator.AddHandler<SummarizationHandler>("summarize");
            syncOrchestrator.AddHandler<GenerateEmbeddingsHandler>("gen_embeddings");
            syncOrchestrator.AddHandler<SaveRecordsHandler>("save_records");
            //syncOrchestrator.AddHandler<DeleteDocumentHandler>("private_delete_document");
            //syncOrchestrator.AddHandler<DeleteIndexHandler>("private_delete_index");
            //syncOrchestrator.AddHandler<DeleteGeneratedFilesHandler>("delete_generated_files");
            //syncOrchestrator.AddHandler<GenerateEmbeddingsParallelHandler>("gen_embeddings_parallel");
            //syncOrchestrator.AddHandler<SummarizationParallelHandler>("summarize_parallel");

            return memory;


        });
    }
}
