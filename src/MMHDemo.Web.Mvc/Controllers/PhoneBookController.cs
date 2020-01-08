using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MMHDemo.IPersonAppServiceInfo;
using MMHDemo.ListResultDto;
using MMHDemo.Web.Controllers;

namespace MMHDemo.Web.Controllers
{
    [Area("App")]
    public class PhoneBookController : MMHDemoControllerBase
    {
        private readonly IPersonAppService _personAppService;

        public PhoneBookController(IPersonAppService personAppService)
        {
            _personAppService = personAppService;
        }

        public ActionResult Index(GetPeopleInput input)
        {
            var output = _personAppService.GetPeople(input);
            var model = ObjectMapper.Map<IndexViewModel>(output);
            model.Filter = input.Filter;

            return View(model);
        }

        public PartialViewResult CreatePersonModal()
        {
            return PartialView("_CreatePersonModal");
        }

    }

}