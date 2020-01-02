using Abp.AutoMapper;
using MMHDemo.Authorization.Roles.Dto;
using MMHDemo.Web.Areas.App.Models.Common;

namespace MMHDemo.Web.Areas.App.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class CreateOrEditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool IsEditMode => Role.Id.HasValue;
    }
}