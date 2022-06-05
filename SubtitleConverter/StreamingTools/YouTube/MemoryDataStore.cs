using Google.Apis.Util.Store;

namespace StreamingTools.YouTube;

public class MemoryDataStore : IDataStore
{
    private Dictionary<string, object?> Values { get; } = new();

    public Task ClearAsync()
    {
        Values.Clear();
        return Task.CompletedTask;
    }

    public Task DeleteAsync<T>(string key)
    {
        Values.Remove(key);
        return Task.CompletedTask;
    }

    public Task<T?> GetAsync<T>(string key)
    {
        if (Values.TryGetValue(key, out object? value))
        {
            return Task.FromResult((T?)Convert.ChangeType(value, typeof(T)));
        }
        return Task.FromResult(default(T));
    }

    public Task StoreAsync<T>(string key, T value)
    {
        Values[key] = value;
        return Task.CompletedTask;
    }
}
