using Microsoft.AspNetCore.Mvc;
using MMHDemo.Web.Controllers;

namespace MMHDemo.Web.Public.Controllers
{
    public class AboutController : MMHDemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}