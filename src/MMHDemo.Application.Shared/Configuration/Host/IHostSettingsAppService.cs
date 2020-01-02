﻿using System.Threading.Tasks;
using Abp.Application.Services;
using MMHDemo.Configuration.Host.Dto;

namespace MMHDemo.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
