using Abp.Authorization;
using MMHDemo.Authorization.Roles;
using MMHDemo.Authorization.Users;

namespace MMHDemo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
