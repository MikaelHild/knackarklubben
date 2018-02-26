using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace AmmStew.Controllers
{
    public abstract class AmmStewControllerBase: AbpController
    {
        protected AmmStewControllerBase()
        {
            LocalizationSourceName = AmmStewConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
