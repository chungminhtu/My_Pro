using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MMHDemo.Test3.Dtos;
using MMHDemo.Dto;

namespace MMHDemo.Test3
{
    public interface IEmp1sAppService : IApplicationService 
    {
        Task<PagedResultDto<GetEmp1ForViewDto>> GetAll(GetAllEmp1sInput input);

        Task<GetEmp1ForViewDto> GetEmp1ForView(int id);

		Task<GetEmp1ForEditOutput> GetEmp1ForEdit(EntityDto input);

		Task CreateOrEdit(CreateOrEditEmp1Dto input);

		Task Delete(EntityDto input);

		Task<FileDto> GetEmp1sToExcel(GetAllEmp1sForExcelInput input);

		
    }
}