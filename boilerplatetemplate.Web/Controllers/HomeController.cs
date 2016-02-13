using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace boilerplatetemplate.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : boilerplatetemplateControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}