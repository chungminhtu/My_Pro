using System.Collections.Generic;
using MMHDemo.Authorization.Users.Importing.Dto;
using MMHDemo.Dto;

namespace MMHDemo.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
