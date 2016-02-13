using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using boilerplatetemplate.Authorization.Roles;
using boilerplatetemplate.Editions;
using boilerplatetemplate.Users;

namespace boilerplatetemplate.MultiTenancy
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