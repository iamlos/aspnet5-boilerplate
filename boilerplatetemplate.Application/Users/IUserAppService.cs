using System.Threading.Tasks;
using Abp.Application.Services;
using boilerplatetemplate.Users.Dto;

namespace boilerplatetemplate.Users
{
    public interface IUserAppService : IApplicationService
    {
        Task ProhibitPermission(ProhibitPermissionInput input);

        Task RemoveFromRole(long userId, string roleName);
    }
}