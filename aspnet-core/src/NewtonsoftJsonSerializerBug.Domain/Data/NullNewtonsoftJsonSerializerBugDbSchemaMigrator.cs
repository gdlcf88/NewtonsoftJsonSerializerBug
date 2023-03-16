using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace NewtonsoftJsonSerializerBug.Data;

/* This is used if database provider does't define
 * INewtonsoftJsonSerializerBugDbSchemaMigrator implementation.
 */
public class NullNewtonsoftJsonSerializerBugDbSchemaMigrator : INewtonsoftJsonSerializerBugDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
