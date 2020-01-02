using System.Collections.Generic;
using Abp.Application.Services.Dto;
using MMHDemo.Configuration.Host.Dto;
using MMHDemo.Editions.Dto;

namespace MMHDemo.Web.Areas.App.Models.HostSettings
{
    public class HostSettingsViewModel
    {
        public HostSettingsEditDto Settings { get; set; }

        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }

        public List<ComboboxItemDto> TimezoneItems { get; set; }
    }
}