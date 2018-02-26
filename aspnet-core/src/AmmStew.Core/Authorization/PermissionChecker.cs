using Abp.Authorization;
using AmmStew.Authorization.Roles;
using AmmStew.Authorization.Users;

namespace AmmStew.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
