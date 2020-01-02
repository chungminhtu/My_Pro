using System.Collections.Generic;
using Abp.Runtime.Session;
using Abp.Timing.Timezone;
using MMHDemo.DataExporting.Excel.EpPlus;
using MMHDemo.Test3.Dtos;
using MMHDemo.Dto;
using MMHDemo.Storage;

namespace MMHDemo.Test3.Exporting
{
    public class Emp1sExcelExporter : EpPlusExcelExporterBase, IEmp1sExcelExporter
    {

        private readonly ITimeZoneConverter _timeZoneConverter;
        private readonly IAbpSession _abpSession;

        public Emp1sExcelExporter(
            ITimeZoneConverter timeZoneConverter,
            IAbpSession abpSession,
			ITempFileCacheManager tempFileCacheManager) :  
	base(tempFileCacheManager)
        {
            _timeZoneConverter = timeZoneConverter;
            _abpSession = abpSession;
        }

        public FileDto ExportToFile(List<GetEmp1ForViewDto> emp1s)
        {
            return CreateExcelPackage(
                "Emp1s.xlsx",
                excelPackage =>
                {
                    var sheet = excelPackage.Workbook.Worksheets.Add(L("Emp1s"));
                    sheet.OutLineApplyStyle = true;

                    AddHeader(
                        sheet,
                        L("Name"),
                        L("Roll"),
                        L("Email")
                        );

                    AddObjects(
                        sheet, 2, emp1s,
                        _ => _.Emp1.Name,
                        _ => _.Emp1.Roll,
                        _ => _.Emp1.Email
                        );

					

                });
        }
    }
}
