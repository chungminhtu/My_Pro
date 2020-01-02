using System.Collections.Generic;
using MMHDemo.Caching.Dto;

namespace MMHDemo.Web.Areas.App.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}