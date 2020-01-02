using Abp.Auditing;
using MMHDemo.Configuration.Dto;

namespace MMHDemo.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}