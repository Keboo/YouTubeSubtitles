using Microsoft.Azure.Cosmos.Table;
using Microsoft.Extensions.Configuration;
using System;

namespace StreamingTools.Azure
{
    public static class StorageAccount
    {
        public static CloudStorageAccount Get(string? storageAccountKey, IConfiguration config)
        {
            storageAccountKey ??= config.GetSection("Azure")["StorageAccountKey"] ?? throw new ArgumentException("No Azure storage account key specified", nameof(storageAccountKey));

            return Get(storageAccountKey);
        }

        public static CloudStorageAccount Get(string storageAccountKey)
            => CloudStorageAccount.Parse($"DefaultEndpointsProtocol=https;AccountName=streamautomation;AccountKey={storageAccountKey};EndpointSuffix=core.windows.net");
    }
}
