using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MMHDemo.Authorization;

namespace MMHDemo
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(MMHDemoApplicationSharedModule),
        typeof(MMHDemoCoreModule)
        )]
    public class MMHDemoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MMHDemoApplicationModule).GetAssembly());
        }
    }
}