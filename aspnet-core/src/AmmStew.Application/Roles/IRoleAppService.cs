using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AmmStew.Roles.Dto;

namespace AmmStew.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
