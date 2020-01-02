using System.Collections.Generic;
using MvvmHelpers;
using MMHDemo.Models.NavigationMenu;

namespace MMHDemo.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}