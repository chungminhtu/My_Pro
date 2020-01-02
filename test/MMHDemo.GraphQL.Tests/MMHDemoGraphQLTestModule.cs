using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using MMHDemo.Configure;
using MMHDemo.Startup;
using MMHDemo.Test.Base;

namespace MMHDemo.GraphQL.Tests
{
    [DependsOn(
        typeof(MMHDemoGraphQLModule),
        typeof(MMHDemoTestBaseModule))]
    public class MMHDemoGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MMHDemoGraphQLTestModule).GetAssembly());
        }
    }
}