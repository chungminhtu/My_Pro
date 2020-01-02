using Abp.AspNetCore.Mvc.Views;

namespace MMHDemo.Web.Views
{
    public abstract class MMHDemoRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected MMHDemoRazorPage()
        {
            LocalizationSourceName = MMHDemoConsts.LocalizationSourceName;
        }
    }
}
