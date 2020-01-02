using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MMHDemo.MultiTenancy.HostDashboard.Dto;

namespace MMHDemo.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}