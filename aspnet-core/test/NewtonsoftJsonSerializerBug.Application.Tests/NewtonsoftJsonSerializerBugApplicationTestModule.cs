using Volo.Abp.Modularity;

namespace NewtonsoftJsonSerializerBug;

[DependsOn(
    typeof(NewtonsoftJsonSerializerBugApplicationModule),
    typeof(NewtonsoftJsonSerializerBugDomainTestModule)
    )]
public class NewtonsoftJsonSerializerBugApplicationTestModule : AbpModule
{

}
