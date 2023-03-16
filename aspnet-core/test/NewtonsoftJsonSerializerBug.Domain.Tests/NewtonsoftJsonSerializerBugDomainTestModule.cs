using NewtonsoftJsonSerializerBug.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace NewtonsoftJsonSerializerBug;

[DependsOn(
    typeof(NewtonsoftJsonSerializerBugEntityFrameworkCoreTestModule)
    )]
public class NewtonsoftJsonSerializerBugDomainTestModule : AbpModule
{

}
