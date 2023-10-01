using Microsoft.Extensions.Configuration;

namespace Tests;

public static class Config
{
    private static IConfiguration Configuration { get; }

    static Config()
    {
        var configBuilder = new ConfigurationBuilder();
        configBuilder.AddEnvironmentVariables();
        configBuilder.AddUserSecrets(typeof(Config).Assembly);

        Configuration = configBuilder.Build();
    }

    public static string YouTubeUsername => Configuration["YouTube:Username"] ?? throw new InvalidOperationException("YouTubeUsername is not configured");
    public static string YouTubePassword => Configuration["YouTube:Password"] ?? throw new InvalidOperationException("YouTubePassword is not configured");
    public static string YouTubeRecoveryEmail => Configuration["YouTube:RecoveryEmail"] ?? throw new InvalidOperationException("YouTubeRecoveryEmail is not configured");
    public static string YouTubeTwoFactorCallbackUrl => Configuration["YouTube:TwoFactorCallbackUrl"] ?? throw new InvalidOperationException("YouTubeTwoFactorCallbackUrl is not configured");
}
