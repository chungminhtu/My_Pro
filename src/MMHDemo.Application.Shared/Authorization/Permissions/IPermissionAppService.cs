using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MMHDemo.Authorization.Permissions.Dto;

namespace MMHDemo.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
