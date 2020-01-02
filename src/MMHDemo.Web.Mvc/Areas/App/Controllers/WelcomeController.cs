using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using MMHDemo.Web.Controllers;

namespace MMHDemo.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize]
    public class WelcomeController : MMHDemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}