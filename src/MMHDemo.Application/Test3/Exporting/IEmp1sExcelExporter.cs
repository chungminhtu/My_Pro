using System.Collections.Generic;
using MMHDemo.Test3.Dtos;
using MMHDemo.Dto;

namespace MMHDemo.Test3.Exporting
{
    public interface IEmp1sExcelExporter
    {
        FileDto ExportToFile(List<GetEmp1ForViewDto> emp1s);
    }
}