using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace ABPFramework.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ABPFrameworkControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}