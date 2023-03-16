using System.Threading.Tasks;

namespace NewtonsoftJsonSerializerBug.Data;

public interface INewtonsoftJsonSerializerBugDbSchemaMigrator
{
    Task MigrateAsync();
}
