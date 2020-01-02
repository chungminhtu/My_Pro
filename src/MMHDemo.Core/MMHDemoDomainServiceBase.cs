using Abp.Domain.Services;

namespace MMHDemo
{
    public abstract class MMHDemoDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected MMHDemoDomainServiceBase()
        {
            LocalizationSourceName = MMHDemoConsts.LocalizationSourceName;
        }
    }
}
