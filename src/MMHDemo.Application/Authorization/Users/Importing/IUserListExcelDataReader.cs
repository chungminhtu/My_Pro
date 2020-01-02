using System.Collections.Generic;
using MMHDemo.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace MMHDemo.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
