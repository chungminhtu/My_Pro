﻿using System.Threading.Tasks;
using Abp.Application.Services;

namespace MMHDemo.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task DisableRecurringPayments();

        Task EnableRecurringPayments();
    }
}
