
using System;
using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace MMHDemo.Test3.Dtos
{
    public class CreateOrEditEmp1Dto : EntityDto<int?>
    {

		public string Name { get; set; }
		
		
		public string Roll { get; set; }
		
		
		public string Email { get; set; }
		
		

    }
}