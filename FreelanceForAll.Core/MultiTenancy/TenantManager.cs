using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using FreelanceForAll.Authorization.Roles;
using FreelanceForAll.Editions;
using FreelanceForAll.Users;

namespace FreelanceForAll.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, Role, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager
            )
        {
        }
    }
}