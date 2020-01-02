using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using MMHDemo.EntityFrameworkCore;

namespace MMHDemo.HealthChecks
{
    public class MMHDemoDbContextHealthCheck : IHealthCheck
    {
        private readonly DatabaseCheckHelper _checkHelper;

        public MMHDemoDbContextHealthCheck(DatabaseCheckHelper checkHelper)
        {
            _checkHelper = checkHelper;
        }

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            if (_checkHelper.Exist("db"))
            {
                return Task.FromResult(HealthCheckResult.Healthy("MMHDemoDbContext connected to database."));
            }

            return Task.FromResult(HealthCheckResult.Unhealthy("MMHDemoDbContext could not connect to database"));
        }
    }
}
