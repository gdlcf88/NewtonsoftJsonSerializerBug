using NewtonsoftJsonSerializerBug.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace NewtonsoftJsonSerializerBug.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class NewtonsoftJsonSerializerBugController : AbpControllerBase
{
    protected NewtonsoftJsonSerializerBugController()
    {
        LocalizationResource = typeof(NewtonsoftJsonSerializerBugResource);
    }
}
