using MMHDemo.Test3.Dtos;
using Abp.Extensions;

namespace MMHDemo.Web.Areas.App.Models.Emp1s
{
    public class CreateOrEditEmp1ModalViewModel
    {
       public CreateOrEditEmp1Dto Emp1 { get; set; }

	   
	   public bool IsEditMode => Emp1.Id.HasValue;
    }
}