using Abp.AspNetCore.Mvc.ViewComponents;

namespace MMHDemo.Web.Public.Views
{
    public abstract class MMHDemoViewComponent : AbpViewComponent
    {
        protected MMHDemoViewComponent()
        {
            LocalizationSourceName = MMHDemoConsts.LocalizationSourceName;
        }
    }
}