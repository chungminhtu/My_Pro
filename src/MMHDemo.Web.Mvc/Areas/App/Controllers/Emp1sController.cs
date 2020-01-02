using System;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using MMHDemo.Web.Areas.App.Models.Emp1s;
using MMHDemo.Web.Controllers;
using MMHDemo.Authorization;
using MMHDemo.Test3;
using MMHDemo.Test3.Dtos;
using Abp.Application.Services.Dto;
using Abp.Extensions;

namespace MMHDemo.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize(AppPermissions.Pages_Emp1s)]
    public class Emp1sController : MMHDemoControllerBase
    {
        private readonly IEmp1sAppService _emp1sAppService;

        public Emp1sController(IEmp1sAppService emp1sAppService)
        {
            _emp1sAppService = emp1sAppService;
        }

        public ActionResult Index()
        {
            var model = new Emp1sViewModel
			{
				FilterText = ""
			};

            return View(model);
        } 

        [AbpMvcAuthorize(AppPermissions.Pages_Emp1s_Create, AppPermissions.Pages_Emp1s_Edit)]
        public async Task<PartialViewResult> CreateOrEditModal(int? id)
        {
			GetEmp1ForEditOutput getEmp1ForEditOutput;

			if (id.HasValue){
				getEmp1ForEditOutput = await _emp1sAppService.GetEmp1ForEdit(new EntityDto { Id = (int) id });
			}
			else {
				getEmp1ForEditOutput = new GetEmp1ForEditOutput{
					Emp1 = new CreateOrEditEmp1Dto()
				};
			}

            var viewModel = new CreateOrEditEmp1ModalViewModel()
            {
				Emp1 = getEmp1ForEditOutput.Emp1
            };

            return PartialView("_CreateOrEditModal", viewModel);
        }

        public async Task<PartialViewResult> ViewEmp1Modal(int id)
        {
			var getEmp1ForViewDto = await _emp1sAppService.GetEmp1ForView(id);

            var model = new Emp1ViewModel()
            {
                Emp1 = getEmp1ForViewDto.Emp1
            };

            return PartialView("_ViewEmp1Modal", model);
        }


    }
}