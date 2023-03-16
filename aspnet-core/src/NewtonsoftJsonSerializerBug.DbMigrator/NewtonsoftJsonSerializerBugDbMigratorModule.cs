using NewtonsoftJsonSerializerBug.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace NewtonsoftJsonSerializerBug.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(NewtonsoftJsonSerializerBugEntityFrameworkCoreModule),
    typeof(NewtonsoftJsonSerializerBugApplicationContractsModule)
    )]
public class NewtonsoftJsonSerializerBugDbMigratorModule : AbpModule
{

}
