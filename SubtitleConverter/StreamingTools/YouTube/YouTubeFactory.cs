using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace StreamingTools.YouTube
{
    public static class YouTubeFactory
    {
        public static async Task<YouTubeService> GetService(string prefix)
        {
            return await GetServiceAsync(new EnvironmentVariablesDataStore(prefix), null, null);
        }

        public static async Task<YouTubeService> GetServiceAsync(
            IDataStore dataStore, 
            IConfiguration config,
            string? clientId, 
            string? clientSecret, 
            params string[] scopes)
        {
            var section = config.GetSection("YouTube");
            clientId ??= section["ClientId"] ?? throw new InvalidOperationException("No YouTube client id specified");
            clientSecret ??= section["ClientSecret"] ?? throw new InvalidOperationException("No YouTube client secret specified");

            return await GetServiceAsync(dataStore, clientId, clientSecret, scopes);
        }

        public static async Task<YouTubeService> GetServiceAsync(IDataStore dataStore, string? clientId, string? clientSecret, params string[] scopes)
        {
            using var cts = new CancellationTokenSource();

            GoogleClientSecrets secrets = await GetClientSecrets(dataStore, clientId, clientSecret);
            
            if (secrets?.Secrets == null)
            {
                throw new InvalidOperationException("Could not find client secrets");
            }
            
            var credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    secrets.Secrets,
                    scopes,
                    "UserAuth",
                    cts.Token,
                    dataStore
                );

            var service = new YouTubeService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
                ApplicationName = "StreamAutomation"
            });

            return service;
        }

        private static async Task<GoogleClientSecrets> GetClientSecrets(IDataStore dataStore, string? clientId, string? clientSecret)
        {
            clientSecret ??= await dataStore.GetAsync<string?>("ClientSecret") ?? "";
            clientId ??= await dataStore.GetAsync<string?>("ClientId") ?? "";

            var stream = new MemoryStream();
            using var sw = new StreamWriter(stream);
            string value = System.Text.Json.JsonSerializer.Serialize(new
            {
                installed = new
                {
                    client_id = clientId,
                    client_secret = clientSecret
                }
            });
            sw.Write(value);
            sw.Flush();
            stream.Position = 0;
            return GoogleClientSecrets.Load(stream);
        }
    }
}
