using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Diagnostics.CodeAnalysis;

namespace StreamingTools.Data;

[ExcludeFromCodeCoverage]
public class StreamingDbContextFactory : IDesignTimeDbContextFactory<StreamingDbContext>
{
    public StreamingDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<StreamingDbContext>();
        optionsBuilder.EnableSensitiveDataLogging();
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=KebooStreaming;Trusted_Connection=True;");

        return new StreamingDbContext(optionsBuilder.Options);
    }
}
