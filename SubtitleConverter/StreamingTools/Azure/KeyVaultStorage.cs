using Azure;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using Google.Apis.Json;
using Google.Apis.Util.Store;

namespace StreamingTools.Azure;

public class KeyVaultStorage : IDataStore
{
    private string Prefix { get; }
    private SecretClient SecretClient { get; }
    public KeyVaultStorage(Uri keyVaultUri, string prefix)
    {
        Prefix = prefix;
        SecretClient = new SecretClient(keyVaultUri, new DefaultAzureCredential());
    }

    public Task ClearAsync()
    {
        return Task.CompletedTask;
    }

    public async Task DeleteAsync<T>(string key)
    {
        await SecretClient.StartDeleteSecretAsync(GetKey(key));
    }

    public async Task<T?> GetAsync<T>(string key)
    {
        try
        {
            var kvSecret = await SecretClient.GetSecretAsync(GetKey(key));
            string? value = kvSecret.Value.Value;
            if (string.IsNullOrEmpty(value))
            {
                return default;
            }
            else
            {
                return NewtonsoftJsonSerializer.Instance.Deserialize<T?>(value);
            }
        }
        catch (RequestFailedException ex) when (ex.Status == 404)
        {
            return default;
        }
    }

    public async Task StoreAsync<T>(string key, T value)
    {
        string contents = NewtonsoftJsonSerializer.Instance.Serialize(value);
        await SecretClient.SetSecretAsync(GetKey(key), contents);
    }

    private string GetKey(string key) => Prefix + "--" + key;
}
