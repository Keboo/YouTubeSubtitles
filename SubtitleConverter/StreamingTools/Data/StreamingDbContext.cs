using Microsoft.EntityFrameworkCore;

namespace StreamingTools.Data;

public class StreamingDbContext(DbContextOptions<StreamingDbContext> options) 
    : DbContext(options)
{
    public DbSet<Video> Videos => Set<Video>();

    public StreamingDbContext()
        : this(new DbContextOptionsBuilder<StreamingDbContext>()
              .UseAzureSql("Server=tcp:keboostreaming.database.windows.net,1433;Initial Catalog=streaming;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;Authentication=\"Active Directory Default\";").Options)
    {

    }

    public static async Task<StreamingDbContext> CreateAsync(CancellationToken token)
    {
        var dbContext = new StreamingDbContext();
        await dbContext.Database.MigrateAsync(token);
        return dbContext;
    }
}
