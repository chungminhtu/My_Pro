using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using MMHDemo.ListResultDto;

namespace MMHDemo.Web.Controllers
{
    [AutoMapFrom(typeof(ListResultDto<PersonListDto>))]
    public class IndexViewModel : ListResultDto<PersonListDto>
    {
        public string Filter { get; set; }
    }

}