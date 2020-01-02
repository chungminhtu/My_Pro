using Abp.Dependency;
using Abp.Reflection.Extensions;
using Microsoft.Extensions.Configuration;
using MMHDemo.Configuration;

namespace MMHDemo.Test.Base
{
    public class TestAppConfigurationAccessor : IAppConfigurationAccessor, ISingletonDependency
    {
        public IConfigurationRoot Configuration { get; }

        public TestAppConfigurationAccessor()
        {
            Configuration = AppConfigurations.Get(
                typeof(MMHDemoTestBaseModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }
    }
}
