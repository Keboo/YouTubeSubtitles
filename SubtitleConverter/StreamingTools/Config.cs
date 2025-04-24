using Azure.Core;
using Azure.Identity;
using Microsoft.Extensions.Configuration;

namespace StreamingTools;

public static class Config
{
    private static IConfiguration Configuration { get; }

    public static TokenCredential Credential { get; } = new ChainedTokenCredential(
        new AzureCliCredential(),
        new EnvironmentCredential()
    );

    static Config()
    {
        var configBuilder = new ConfigurationBuilder();
        configBuilder.AddEnvironmentVariables();
        configBuilder.AddUserSecrets(typeof(Config).Assembly);

        if (IsAuthenticated())
        {
            configBuilder.AddAzureKeyVault(new Uri("https://streamautomation.vault.azure.net/"), Credential);
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

    public static string YouTubeUsername => Configuration["YouTube:Username"] ?? throw new InvalidOperationException("YouTube Username is not configured");
    public static string YouTubePassword => Configuration["YouTube:Password"] ?? throw new InvalidOperationException("YouTube Password is not configured");
    public static string YouTubeRecoveryEmail => Configuration["YouTube:RecoveryEmail"] ?? throw new InvalidOperationException("YouTube RecoveryEmail is not configured");
    public static string YouTubeTwoFactorCallbackUrl => Configuration["YouTube:TwoFactorCallbackUrl"] ?? throw new InvalidOperationException("YouTube TwoFactorCallbackUrl is not configured");
}
