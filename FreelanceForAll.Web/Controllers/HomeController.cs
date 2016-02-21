using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace FreelanceForAll.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : FreelanceForAllControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}