using System.Threading.Tasks;
using MMHDemo.Sessions.Dto;

namespace MMHDemo.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
