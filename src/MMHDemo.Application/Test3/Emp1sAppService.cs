

using System;
using System.Linq;
using System.Linq.Dynamic.Core;
using Abp.Linq.Extensions;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using MMHDemo.Test3.Exporting;
using MMHDemo.Test3.Dtos;
using MMHDemo.Dto;
using Abp.Application.Services.Dto;
using MMHDemo.Authorization;
using Abp.Extensions;
using Abp.Authorization;
using Microsoft.EntityFrameworkCore;
using MMHDemo.MMHDemoAppServiceBaseInfo;

namespace MMHDemo.Test3
{
	[AbpAuthorize(AppPermissions.Pages_Emp1s)]
    public class Emp1sAppService : MMHDemoAppServiceBase, IEmp1sAppService
    {
		 private readonly IRepository<Emp1> _emp1Repository;
		 private readonly IEmp1sExcelExporter _emp1sExcelExporter;
		 

		  public Emp1sAppService(IRepository<Emp1> emp1Repository, IEmp1sExcelExporter emp1sExcelExporter ) 
		  {
			_emp1Repository = emp1Repository;
			_emp1sExcelExporter = emp1sExcelExporter;
			
		  }

		 public async Task<PagedResultDto<GetEmp1ForViewDto>> GetAll(GetAllEmp1sInput input)
         {
			
			var filteredEmp1s = _emp1Repository.GetAll()
						.WhereIf(!string.IsNullOrWhiteSpace(input.Filter), e => false  || e.Name.Contains(input.Filter) || e.Roll.Contains(input.Filter) || e.Email.Contains(input.Filter))
						.WhereIf(!string.IsNullOrWhiteSpace(input.NameFilter),  e => e.Name == input.NameFilter)
						.WhereIf(!string.IsNullOrWhiteSpace(input.RollFilter),  e => e.Roll == input.RollFilter)
						.WhereIf(!string.IsNullOrWhiteSpace(input.EmailFilter),  e => e.Email == input.EmailFilter);

			var pagedAndFilteredEmp1s = filteredEmp1s
                .OrderBy(input.Sorting ?? "id asc")
                .PageBy(input);

			var emp1s = from o in pagedAndFilteredEmp1s
                         select new GetEmp1ForViewDto() {
							Emp1 = new Emp1Dto
							{
                                Name = o.Name,
                                Roll = o.Roll,
                                Email = o.Email,
                                Id = o.Id
							}
						};

            var totalCount = await filteredEmp1s.CountAsync();

            return new PagedResultDto<GetEmp1ForViewDto>(
                totalCount,
                await emp1s.ToListAsync()
            );
         }
		 
		 public async Task<GetEmp1ForViewDto> GetEmp1ForView(int id)
         {
            var emp1 = await _emp1Repository.GetAsync(id);

            var output = new GetEmp1ForViewDto { Emp1 = ObjectMapper.Map<Emp1Dto>(emp1) };
			
            return output;
         }
		 
		 [AbpAuthorize(AppPermissions.Pages_Emp1s_Edit)]
		 public async Task<GetEmp1ForEditOutput> GetEmp1ForEdit(EntityDto input)
         {
            var emp1 = await _emp1Repository.FirstOrDefaultAsync(input.Id);
           
		    var output = new GetEmp1ForEditOutput {Emp1 = ObjectMapper.Map<CreateOrEditEmp1Dto>(emp1)};
			
            return output;
         }

		 public async Task CreateOrEdit(CreateOrEditEmp1Dto input)
         {
            if(input.Id == null){
				await Create(input);
			}
			else{
				await Update(input);
			}
         }

		 [AbpAuthorize(AppPermissions.Pages_Emp1s_Create)]
		 protected virtual async Task Create(CreateOrEditEmp1Dto input)
         {
            var emp1 = ObjectMapper.Map<Emp1>(input);

			
			if (AbpSession.TenantId != null)
			{
				emp1.TenantId = (int?) AbpSession.TenantId;
			}
		

            await _emp1Repository.InsertAsync(emp1);
         }

		 [AbpAuthorize(AppPermissions.Pages_Emp1s_Edit)]
		 protected virtual async Task Update(CreateOrEditEmp1Dto input)
         {
            var emp1 = await _emp1Repository.FirstOrDefaultAsync((int)input.Id);
             ObjectMapper.Map(input, emp1);
         }

		 [AbpAuthorize(AppPermissions.Pages_Emp1s_Delete)]
         public async Task Delete(EntityDto input)
         {
            await _emp1Repository.DeleteAsync(input.Id);
         } 

		public async Task<FileDto> GetEmp1sToExcel(GetAllEmp1sForExcelInput input)
         {
			
			var filteredEmp1s = _emp1Repository.GetAll()
						.WhereIf(!string.IsNullOrWhiteSpace(input.Filter), e => false  || e.Name.Contains(input.Filter) || e.Roll.Contains(input.Filter) || e.Email.Contains(input.Filter))
						.WhereIf(!string.IsNullOrWhiteSpace(input.NameFilter),  e => e.Name == input.NameFilter)
						.WhereIf(!string.IsNullOrWhiteSpace(input.RollFilter),  e => e.Roll == input.RollFilter)
						.WhereIf(!string.IsNullOrWhiteSpace(input.EmailFilter),  e => e.Email == input.EmailFilter);

			var query = (from o in filteredEmp1s
                         select new GetEmp1ForViewDto() { 
							Emp1 = new Emp1Dto
							{
                                Name = o.Name,
                                Roll = o.Roll,
                                Email = o.Email,
                                Id = o.Id
							}
						 });


            var emp1ListDtos = await query.ToListAsync();

            return _emp1sExcelExporter.ExportToFile(emp1ListDtos);
         }


    }
}