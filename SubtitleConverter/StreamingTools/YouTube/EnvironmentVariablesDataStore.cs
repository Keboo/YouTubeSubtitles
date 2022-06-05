using Google.Apis.Json;
using Google.Apis.Util.Store;

namespace StreamingTools.YouTube;

public class EnvironmentVariablesDataStore : IDataStore
{
    private string Prefix { get; }

    public EnvironmentVariablesDataStore(string prefix)
    {
        Prefix = prefix;
    }

    public Task ClearAsync()
    {
        foreach (string variable in Environment.GetEnvironmentVariables().Keys
            .Cast<string>()
            .Where(x => x.StartsWith(Prefix)))
        {
            Environment.SetEnvironmentVariable(variable, "");
        }
        return Task.CompletedTask;
    }

    public Task DeleteAsync<T>(string key)
    {
        Environment.SetEnvironmentVariable(Prefix + key, "");
        return Task.CompletedTask;
    }

    public Task<T?> GetAsync<T>(string key)
    {
        TaskCompletionSource<T?> taskCompletionSource = new TaskCompletionSource<T?>();
        try
        {
            string? value = GetValue(key);
            if (string.IsNullOrEmpty(value))
            {
                taskCompletionSource.SetResult(default);
            }
            else
            {
                taskCompletionSource.SetResult(NewtonsoftJsonSerializer.Instance.Deserialize<T?>(value));
            }
        }
        catch (Exception exception)
        {
            taskCompletionSource.SetException(exception);
        }
        return taskCompletionSource.Task;
    }

    public string? GetValue(string key) => Environment.GetEnvironmentVariable(Prefix + key);

    public Task StoreAsync<T>(string key, T value)
    {
        string contents = NewtonsoftJsonSerializer.Instance.Serialize(value);
        Environment.SetEnvironmentVariable(Prefix + key, contents);
        return Task.CompletedTask;
    }
}
