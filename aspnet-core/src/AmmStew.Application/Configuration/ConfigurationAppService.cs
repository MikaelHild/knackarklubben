using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AmmStew.Configuration.Dto;

namespace AmmStew.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AmmStewAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
