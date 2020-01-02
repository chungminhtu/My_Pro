using Abp.AspNetCore.Mvc.Authorization;
using MMHDemo.Authorization;
using MMHDemo.Storage;
using Abp.BackgroundJobs;
using Abp.Authorization;

namespace MMHDemo.Web.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Users)]
    public class UsersController : UsersControllerBase
    {
        public UsersController(IBinaryObjectManager binaryObjectManager, IBackgroundJobManager backgroundJobManager)
            : base(binaryObjectManager, backgroundJobManager)
        {
        }
    }
}