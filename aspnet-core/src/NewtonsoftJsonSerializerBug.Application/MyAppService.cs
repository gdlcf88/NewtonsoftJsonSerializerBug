using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Json.Newtonsoft;

namespace NewtonsoftJsonSerializerBug;

public class MyAppService : ApplicationService
{
    private readonly AbpNewtonsoftJsonSerializer _jsonSerializer;

    public MyAppService(AbpNewtonsoftJsonSerializer jsonSerializer)
    {
        _jsonSerializer = jsonSerializer;
    }

    public async Task TestAsync()
    {
        _jsonSerializer.Serialize(new MyModel());
    }
}

public class MyModel : ExtensibleFullAuditedEntityDto<Guid>
{
}