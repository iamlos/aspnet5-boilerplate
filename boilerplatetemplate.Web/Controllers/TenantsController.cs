using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using boilerplatetemplate.Authorization;
using boilerplatetemplate.MultiTenancy;

namespace boilerplatetemplate.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Tenants)]
    public class TenantsController : boilerplatetemplateControllerBase
    {
        private readonly ITenantAppService _tenantAppService;

        public TenantsController(ITenantAppService tenantAppService)
        {
            _tenantAppService = tenantAppService;
        }

        public ActionResult Index()
        {
            var output = _tenantAppService.GetTenants();
            return View(output);
        }
    }
}