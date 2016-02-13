using System.Threading.Tasks;
using Abp.Application.Services;
using boilerplatetemplate.Roles.Dto;

namespace boilerplatetemplate.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
