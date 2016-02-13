using Abp.Application.Features;
using boilerplatetemplate.Authorization.Roles;
using boilerplatetemplate.MultiTenancy;
using boilerplatetemplate.Users;

namespace boilerplatetemplate.Features
{
    public class FeatureValueStore : AbpFeatureValueStore<Tenant, Role, User>
    {
        public FeatureValueStore(TenantManager tenantManager)
            : base(tenantManager)
        {
        }
    }
}