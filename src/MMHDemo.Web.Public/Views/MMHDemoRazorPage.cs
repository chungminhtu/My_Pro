using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace MMHDemo.Web.Public.Views
{
    public abstract class MMHDemoRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected MMHDemoRazorPage()
        {
            LocalizationSourceName = MMHDemoConsts.LocalizationSourceName;
        }
    }
}
