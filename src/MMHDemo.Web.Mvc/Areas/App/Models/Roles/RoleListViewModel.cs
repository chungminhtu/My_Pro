using System.Collections.Generic;
using Abp.Application.Services.Dto;
using MMHDemo.Authorization.Permissions.Dto;
using MMHDemo.Web.Areas.App.Models.Common;

namespace MMHDemo.Web.Areas.App.Models.Roles
{
    public class RoleListViewModel : IPermissionsEditViewModel
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}