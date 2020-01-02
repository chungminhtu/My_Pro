using Abp.Auditing;
using Microsoft.AspNetCore.Mvc;

namespace MMHDemo.Web.Controllers
{
    public class HomeController : MMHDemoControllerBase
    {
        [DisableAuditing]
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Ui");
        }
    }
}
