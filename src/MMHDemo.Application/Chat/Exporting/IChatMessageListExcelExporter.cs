using System.Collections.Generic;
using MMHDemo.Chat.Dto;
using MMHDemo.Dto;

namespace MMHDemo.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(List<ChatMessageExportDto> messages);
    }
}
