using Volo.Abp.Settings;

namespace NewtonsoftJsonSerializerBug.Settings;

public class NewtonsoftJsonSerializerBugSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(NewtonsoftJsonSerializerBugSettings.MySetting1));
    }
}
