using System.Collections.Generic;
using Abp.Application.Services.Dto;
using MMHDemo.Editions.Dto;

namespace MMHDemo.Web.Areas.App.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}