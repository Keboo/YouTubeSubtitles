using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace DownloadSubtitle
{
    public static class YouTube
    {
        public static async Task<YouTubeService> GetService()
        {
            UserCredential credential;
            using (var cts = new CancellationTokenSource())
            {
                GoogleClientSecrets secrets = GetClientSecrets();

                if (secrets?.Secrets == null)
                {
                    throw new InvalidOperationException("Could not find client secrets");
                }

                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    secrets.Secrets,
                    // This OAuth 2.0 access scope allows for full read/write access to the
                    // authenticated user's account.
                    new[] { YouTubeService.Scope.YoutubeForceSsl, YouTubeService.Scope.Youtube },
                    "UserAuth",
                    cts.Token,
                    new EnvironmentVariablesDataStore()
                );
            }

            var service = new YouTubeService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
                ApplicationName = "SubtitleConverter"
            });
            return service;
        }

        private static GoogleClientSecrets GetClientSecrets()
        {
            using (var stream = new MemoryStream())
            using (var sw = new StreamWriter(stream))
            {
                string value = EnvironmentVariablesDataStore.GetValue("ClientSecret");
                sw.Write(value);
                sw.Flush();
                stream.Position = 0;
                return GoogleClientSecrets.Load(stream);
            }
        }
    }
}
