using Abp.AspNetCore.Mvc.ViewComponents;

namespace MMHDemo.Web.Views
{
    public abstract class MMHDemoViewComponent : AbpViewComponent
    {
        protected MMHDemoViewComponent()
        {
            LocalizationSourceName = MMHDemoConsts.LocalizationSourceName;
        }
    }
}