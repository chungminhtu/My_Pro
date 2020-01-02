using System.Threading.Tasks;
using Abp.Application.Services;
using MMHDemo.Sessions.Dto;

namespace MMHDemo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
