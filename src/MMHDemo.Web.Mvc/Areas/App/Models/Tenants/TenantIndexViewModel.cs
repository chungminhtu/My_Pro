using System.Collections.Generic;
using MMHDemo.Editions.Dto;

namespace MMHDemo.Web.Areas.App.Models.Tenants
{
    public class TenantIndexViewModel
    {
        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }
    }
}