using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using MMHDemo.Dto;

namespace MMHDemo.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
