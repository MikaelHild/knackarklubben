using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AmmStew.MultiTenancy.Dto;

namespace AmmStew.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
