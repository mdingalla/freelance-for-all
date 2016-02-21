using Abp.Authorization.Roles;
using FreelanceForAll.MultiTenancy;
using FreelanceForAll.Users;

namespace FreelanceForAll.Authorization.Roles
{
    public class Role : AbpRole<Tenant, User>
    {

    }
}