using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace NewtonsoftJsonSerializerBug;

[Dependency(ReplaceServices = true)]
public class NewtonsoftJsonSerializerBugBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "NewtonsoftJsonSerializerBug";
}
