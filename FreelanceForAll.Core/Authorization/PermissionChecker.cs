using Abp.Authorization;
using FreelanceForAll.Authorization.Roles;
using FreelanceForAll.MultiTenancy;
using FreelanceForAll.Users;

namespace FreelanceForAll.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
