using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NewtonsoftJsonSerializerBug.Data;
using Volo.Abp.DependencyInjection;

namespace NewtonsoftJsonSerializerBug.EntityFrameworkCore;

public class EntityFrameworkCoreNewtonsoftJsonSerializerBugDbSchemaMigrator
    : INewtonsoftJsonSerializerBugDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreNewtonsoftJsonSerializerBugDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the NewtonsoftJsonSerializerBugDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<NewtonsoftJsonSerializerBugDbContext>()
            .Database
            .MigrateAsync();
    }
}
