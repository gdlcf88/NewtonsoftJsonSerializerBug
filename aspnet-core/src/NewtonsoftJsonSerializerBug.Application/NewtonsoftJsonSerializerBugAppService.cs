using System;
using System.Collections.Generic;
using System.Text;
using NewtonsoftJsonSerializerBug.Localization;
using Volo.Abp.Application.Services;

namespace NewtonsoftJsonSerializerBug;

/* Inherit your application services from this class.
 */
public abstract class NewtonsoftJsonSerializerBugAppService : ApplicationService
{
    protected NewtonsoftJsonSerializerBugAppService()
    {
        LocalizationResource = typeof(NewtonsoftJsonSerializerBugResource);
    }
}
