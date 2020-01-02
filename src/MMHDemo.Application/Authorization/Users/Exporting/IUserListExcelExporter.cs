using System.Collections.Generic;
using MMHDemo.Authorization.Users.Dto;
using MMHDemo.Dto;

namespace MMHDemo.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}