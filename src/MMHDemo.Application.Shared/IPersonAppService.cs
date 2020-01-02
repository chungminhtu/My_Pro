using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using MMHDemo.ListResultDto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MMHDemo.CreatePersonInfo;
using MMHDemo.IPersonAppServiceInfo;
using System.ComponentModel.DataAnnotations;
using Stripe;

namespace MMHDemo.IPersonAppServiceInfo
{
    public interface IPersonAppService : IApplicationService
    {

        ListResultDto<PersonListDto> GetPeople(GetPeopleInput input);

        Task CreatePerson(CreatePersonInput input);

    }
}
