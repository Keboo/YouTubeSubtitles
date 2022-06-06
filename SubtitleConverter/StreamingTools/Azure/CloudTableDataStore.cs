using Azure.Data.Tables;
using Google.Apis.Util.Store;

namespace StreamingTools.Azure;

public class CloudTableDataStore : IDataStore
{
    private const string JsonDataKey = "JsonData";

    public CloudTableDataStore(TableClient tableClient, string? partitionKey = null)
    {
        TableClient = tableClient ?? throw new ArgumentNullException(nameof(tableClient));
        PartitionKey = partitionKey ?? "GoogleDataStore";
    }

    private TableClient TableClient { get; }
    private string PartitionKey { get; }

    public async Task ClearAsync()
    {
        await TableClient.DeleteAsync();
        await TableClient.CreateAsync();
    }

    public async Task DeleteAsync<T>(string key)
    {
        await TableClient.DeleteEntityAsync(PartitionKey, key);
    }

    public async Task<T?> GetAsync<T>(string key)
    {
        var response = await TableClient.GetEntityAsync<TableEntity>(PartitionKey, key);

        if (response.Value is { } tableEntity)
        {
            return JsonSerializer.Deserialize<T>(tableEntity.GetString(JsonDataKey));
        }
        return default;
    }

    public async Task StoreAsync<T>(string key, T value)
    {
        // Create the InsertOrReplace table operation
        var item = new TableEntity
        {
            RowKey = key,
            PartitionKey = PartitionKey,
        };
        item[JsonDataKey] = JsonSerializer.Serialize(value);
        await TableClient.AddEntityAsync(item);
    }
}
