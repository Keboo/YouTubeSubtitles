﻿using Azure.Identity;
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
}
