using Abp.Application.Services.Dto;
using System;

namespace MMHDemo.Test3.Dtos
{
    public class GetAllEmp1sInput : PagedAndSortedResultRequestDto
    {
		public string Filter { get; set; }

		public string NameFilter { get; set; }

		public string RollFilter { get; set; }

		public string EmailFilter { get; set; }



    }
}