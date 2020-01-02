using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using Abp.Domain.Entities;

namespace MMHDemo.Test3
{
	[Table("emp1s")]
    public class Emp1 : Entity , IMayHaveTenant
    {
			public int? TenantId { get; set; }
			

		public virtual string Name { get; set; }
		
		public virtual string Roll { get; set; }
		
		public virtual string Email { get; set; }
		

    }
}