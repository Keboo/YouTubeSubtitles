using Google.Apis.Util.Store;
using Microsoft.Azure.Cosmos.Table;
using Microsoft.Azure.Documents.Linq;
using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace StreamingTools.Azure
{
    public class CloudTableDataStore : IDataStore
    {
        private class DataItem : TableEntity
        {
            public string? JsonData { get; set; }
        }

        public CloudTableDataStore(CloudTable table, string? partitionKey = null)
        {
            Table = table ?? throw new ArgumentNullException(nameof(table));
            PartitionKey = partitionKey ?? "GoogleDataStore";
        }

        private CloudTable Table { get; }
        private string PartitionKey { get; }

        public async Task ClearAsync()
        {
            int count = await Table.CreateQuery<DataItem>().CountAsync();

            var batch = new TableBatchOperation();
            for (int i = count - 1; i >= 0; i--)
            {
                batch.RemoveAt(i);
            }
            await Table.ExecuteBatchAsync(batch);
        }

        public async Task DeleteAsync<T>(string key)
        {
            TableOperation retrieveOperation = TableOperation.Retrieve<DataItem>(PartitionKey, key);
            TableResult result = await Table.ExecuteAsync(retrieveOperation);
            if (result.Result is not DataItem foundItem)
            {
                return;
            }
            TableOperation deleteOperation = TableOperation.Delete(foundItem);
            await Table.ExecuteAsync(deleteOperation);
        }

        public async Task<T?> GetAsync<T>(string key)
        {
            TableOperation retrieveOperation = TableOperation.Retrieve<DataItem>(PartitionKey, key);
            TableResult result = await Table.ExecuteAsync(retrieveOperation);
            if (result.Result is not DataItem foundItem ||
                string.IsNullOrWhiteSpace(foundItem.JsonData))
            {
                return default;
            }
            return JsonSerializer.Deserialize<T>(foundItem.JsonData);
        }

        public async Task StoreAsync<T>(string key, T value)
        {
            // Create the InsertOrReplace table operation
            var item = new DataItem
            {
                RowKey = key,
                PartitionKey = PartitionKey,
                JsonData = JsonSerializer.Serialize(value)
            };
            TableOperation insertOperation = TableOperation.InsertOrReplace(item);

            // Execute the operation.
            TableResult _ = await Table.ExecuteAsync(insertOperation);
        }
    }
}
