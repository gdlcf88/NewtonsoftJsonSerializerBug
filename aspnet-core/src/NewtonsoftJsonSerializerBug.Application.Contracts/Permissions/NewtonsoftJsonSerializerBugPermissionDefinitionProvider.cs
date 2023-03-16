using NewtonsoftJsonSerializerBug.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace NewtonsoftJsonSerializerBug.Permissions;

public class NewtonsoftJsonSerializerBugPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(NewtonsoftJsonSerializerBugPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(NewtonsoftJsonSerializerBugPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<NewtonsoftJsonSerializerBugResource>(name);
    }
}
