using Abp.Authorization;
using ABPFramework.Authorization.Roles;
using ABPFramework.MultiTenancy;
using ABPFramework.Users;

namespace ABPFramework.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
