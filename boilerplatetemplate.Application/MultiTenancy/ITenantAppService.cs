using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using boilerplatetemplate.MultiTenancy.Dto;

namespace boilerplatetemplate.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultOutput<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
