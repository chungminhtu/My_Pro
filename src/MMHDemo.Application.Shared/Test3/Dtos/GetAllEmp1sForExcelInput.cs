using Abp.Application.Services.Dto;
using System;

namespace MMHDemo.Test3.Dtos
{
    public class GetAllEmp1sForExcelInput
    {
		public string Filter { get; set; }

		public string NameFilter { get; set; }

		public string RollFilter { get; set; }

		public string EmailFilter { get; set; }



    }
}