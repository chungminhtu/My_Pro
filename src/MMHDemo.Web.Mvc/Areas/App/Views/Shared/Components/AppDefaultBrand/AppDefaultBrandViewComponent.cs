﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MMHDemo.Web.Areas.App.Models.Layout;
using MMHDemo.Web.Session;
using MMHDemo.Web.Views;

namespace MMHDemo.Web.Areas.App.Views.Shared.Components.AppDefaultBrand
{
    public class AppDefaultBrandViewComponent : MMHDemoViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppDefaultBrandViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var headerModel = new HeaderViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(headerModel);
        }
    }
}
