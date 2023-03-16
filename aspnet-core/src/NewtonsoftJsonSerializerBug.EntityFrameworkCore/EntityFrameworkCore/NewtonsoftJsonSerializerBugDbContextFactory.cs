using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace NewtonsoftJsonSerializerBug.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class NewtonsoftJsonSerializerBugDbContextFactory : IDesignTimeDbContextFactory<NewtonsoftJsonSerializerBugDbContext>
{
    public NewtonsoftJsonSerializerBugDbContext CreateDbContext(string[] args)
    {
        NewtonsoftJsonSerializerBugEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<NewtonsoftJsonSerializerBugDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new NewtonsoftJsonSerializerBugDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../NewtonsoftJsonSerializerBug.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
