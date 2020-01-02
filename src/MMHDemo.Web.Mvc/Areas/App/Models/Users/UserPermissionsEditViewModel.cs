using Abp.AutoMapper;
using MMHDemo.Authorization.Users;
using MMHDemo.Authorization.Users.Dto;
using MMHDemo.Web.Areas.App.Models.Common;

namespace MMHDemo.Web.Areas.App.Models.Users
{
    [AutoMapFrom(typeof(GetUserPermissionsForEditOutput))]
    public class UserPermissionsEditViewModel : GetUserPermissionsForEditOutput, IPermissionsEditViewModel
    {
        public User User { get; set; }
    }
}