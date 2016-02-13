using Abp.MultiTenancy;
using boilerplatetemplate.Users;

namespace boilerplatetemplate.MultiTenancy
{
    public class Tenant : AbpTenant<Tenant, User>
    {
        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}