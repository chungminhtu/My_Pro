using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace MMHDemo.Startup
{
    [DependsOn(typeof(MMHDemoCoreModule))]
    public class MMHDemoGraphQLModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MMHDemoGraphQLModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            base.PreInitialize();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }
    }
}