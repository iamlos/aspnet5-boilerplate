using Abp.Authorization.Roles;
using boilerplatetemplate.MultiTenancy;
using boilerplatetemplate.Users;

namespace boilerplatetemplate.Authorization.Roles
{
    public class Role : AbpRole<Tenant, User>
    {

    }
}