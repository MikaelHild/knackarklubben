using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AmmStew.Roles.Dto;
using AmmStew.Users.Dto;

namespace AmmStew.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
