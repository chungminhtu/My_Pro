using System.Threading.Tasks;
using Abp.Application.Services;
using MMHDemo.Install.Dto;

namespace MMHDemo.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}