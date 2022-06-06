using Azure.Data.Tables;
using Microsoft.Extensions.Configuration;

namespace StreamingTools.Azure;

public static class StorageAccount
{
    public static TableClient Get(string? storageAccountKey, string tableName, IConfiguration config)
    {
        storageAccountKey ??= config.GetSection("Azure")["StorageAccountKey"] ?? throw new ArgumentException("No Azure storage account key specified", nameof(storageAccountKey));
        return Get(storageAccountKey, tableName);
    }

    public static TableClient Get(string storageAccountKey, string tableName)
        => new (GetConnectionString(storageAccountKey), tableName);

    private static string GetConnectionString(string storageAccountKey)
        => $"DefaultEndpointsProtocol=https;AccountName=streamautomation;AccountKey={storageAccountKey};EndpointSuffix=core.windows.net";
}
