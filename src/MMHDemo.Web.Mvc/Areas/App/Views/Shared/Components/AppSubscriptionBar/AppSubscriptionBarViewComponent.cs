﻿using System.Linq;
using System.Threading.Tasks;
using Abp.Configuration;
using Abp.Configuration.Startup;
using Abp.Localization;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc;
using MMHDemo.Authorization;
using MMHDemo.Configuration;
using MMHDemo.Web.Areas.App.Models.Layout;
using MMHDemo.Web.Session;
using MMHDemo.Web.Views;

namespace MMHDemo.Web.Areas.App.Views.Shared.Components.AppSubscriptionBar
{
    public class AppSubscriptionBarViewComponent : MMHDemoViewComponent
    {
        private readonly ILanguageManager _languageManager;
        private readonly IMultiTenancyConfig _multiTenancyConfig;
        private readonly IPerRequestSessionCache _sessionCache;
        private readonly IAbpSession _abpSession;

        public AppSubscriptionBarViewComponent(
            IMultiTenancyConfig multiTenancyConfig,
            IAbpSession abpSession,
            ILanguageManager languageManager,
            IPerRequestSessionCache sessionCache)
        {
            _multiTenancyConfig = multiTenancyConfig;
            _abpSession = abpSession;
            _languageManager = languageManager;
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var headerModel = new HeaderViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync(),
                Languages = _languageManager.GetLanguages().Where(l => !l.IsDisabled).ToList(),
                CurrentLanguage = _languageManager.CurrentLanguage,
                IsMultiTenancyEnabled = _multiTenancyConfig.IsEnabled,
                IsImpersonatedLogin = _abpSession.ImpersonatorUserId.HasValue,
                HasUiCustomizationPagePermission = await PermissionChecker.IsGrantedAsync(AppPermissions.Pages_Administration_UiCustomization),
                SubscriptionExpireNootifyDayCount = SettingManager.GetSettingValue<int>(AppSettings.TenantManagement.SubscriptionExpireNotifyDayCount)
            };

            return View(headerModel);
        }

    }
}
