using Abp.AutoMapper;
using MMHDemo.MultiTenancy.Dto;

namespace MMHDemo.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(EditionsSelectOutput))]
    public class EditionsSelectViewModel : EditionsSelectOutput
    {
    }
}
