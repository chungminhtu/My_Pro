﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MMHDemo.Web.Areas.App.Models.Layout;
using MMHDemo.Web.Session;
using MMHDemo.Web.Views;

namespace MMHDemo.Web.Areas.App.Views.Shared.Components.AppTheme9Footer
{
    public class AppTheme9FooterViewComponent : MMHDemoViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppTheme9FooterViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footerModel = new FooterViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(footerModel);
        }
    }
}
