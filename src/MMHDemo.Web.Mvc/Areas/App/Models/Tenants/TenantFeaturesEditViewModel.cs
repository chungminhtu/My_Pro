using Abp.AutoMapper;
using MMHDemo.MultiTenancy;
using MMHDemo.MultiTenancy.Dto;
using MMHDemo.Web.Areas.App.Models.Common;

namespace MMHDemo.Web.Areas.App.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }
    }
}