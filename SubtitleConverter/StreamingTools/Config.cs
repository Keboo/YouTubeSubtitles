using Azure.Core;
using Azure.Identity;
using Microsoft.Extensions.Configuration;

namespace StreamingTools;

public static class Config
{
    private static IConfiguration Configuration { get; }

    public static TokenCredential Credential { get; } = new DefaultAzureCredential();

    static Config()
    {
        var configBuilder = new ConfigurationBuilder();
        configBuilder.AddEnvironmentVariables();
        configBuilder.AddUserSecrets(typeof(Config).Assembly);

        if (IsAuthenticated())
        {
            configBuilder.AddAzureKeyVault(new Uri("https://streamautomation.vault.azure.net/"), Credential);
        }
        else
        {
            if (Debugger.IsAttached)
            {
                Debugger.Break();
            }
            Console.WriteLine("Unauthenticated - Can't access KeyVault secrets");
        }

        Configuration = configBuilder.Build();
    }


    private static bool IsAuthenticated()
    {
        try
        {
            var token = Credential.GetToken(new TokenRequestContext([$"https://streamautomation.vault.azure.net/.default"]), CancellationToken.None);
            return token.Token != null;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public static string TwitchUserId => Configuration["Twitch:UserId"] ?? throw new InvalidOperationException("Twitch User Id is not configured");
    public static string TwitchClientId => Configuration["Twitch:ClientId"] ?? throw new InvalidOperationException("Twitch Client Id is not configured");
    public static string TwitchClientSecret => Configuration["Twitch:ClientSecret"] ?? throw new InvalidOperationException("Twitch Client Secret is not configured");

    public static string YouTubeClientId => Configuration["YouTube:ClientId"] ?? throw new InvalidOperationException("YouTube Client Id is not configured");
    public static string YouTubeClientSecret => Configuration["YouTube:ClientSecret"] ?? throw new InvalidOperationException("YouTube Client Secret is not configured");
    public static string YouTubeUsername => Configuration["YouTube:Username"] ?? throw new InvalidOperationException("YouTube Username is not configured");
    public static string YouTubePassword => Configuration["YouTube:Password"] ?? throw new InvalidOperationException("YouTube Password is not configured");
    public static string YouTubeRecoveryEmail => Configuration["YouTube:RecoveryEmail"] ?? throw new InvalidOperationException("YouTube RecoveryEmail is not configured");
    public static string YouTubeTwoFactorCallbackUrl => Configuration["YouTube:TwoFactorCallbackUrl"] ?? throw new InvalidOperationException("YouTube TwoFactorCallbackUrl is not configured");
}
