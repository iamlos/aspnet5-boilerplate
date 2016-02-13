using Abp.Authorization;
using boilerplatetemplate.Authorization.Roles;
using boilerplatetemplate.MultiTenancy;
using boilerplatetemplate.Users;

namespace boilerplatetemplate.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
