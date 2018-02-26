using System.Threading.Tasks;
using AmmStew.Configuration.Dto;

namespace AmmStew.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
