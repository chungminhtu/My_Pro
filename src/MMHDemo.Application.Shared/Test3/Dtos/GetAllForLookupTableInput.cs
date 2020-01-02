using Abp.Application.Services.Dto;

namespace MMHDemo.Test3.Dtos
{
    public class GetAllForLookupTableInput : PagedAndSortedResultRequestDto
    {
		public string Filter { get; set; }
    }
}