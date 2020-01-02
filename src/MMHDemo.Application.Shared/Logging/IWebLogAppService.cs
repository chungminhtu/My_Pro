using Abp.Application.Services;
using MMHDemo.Dto;
using MMHDemo.Logging.Dto;

namespace MMHDemo.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
