using System.Threading.Tasks;
using Abp.Application.Services;
using AmmStew.Sessions.Dto;

namespace AmmStew.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
