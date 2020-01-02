using System.Collections.Generic;
using Abp.Application.Services.Dto;
using MMHDemo.Configuration.Tenants.Dto;

namespace MMHDemo.Web.Areas.App.Models.Settings
{
    public class SettingsViewModel
    {
        public TenantSettingsEditDto Settings { get; set; }
        
        public List<ComboboxItemDto> TimezoneItems { get; set; }
    }
}