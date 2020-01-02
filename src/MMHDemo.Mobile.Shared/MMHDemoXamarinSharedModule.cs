using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace MMHDemo
{
    [DependsOn(typeof(MMHDemoClientModule), typeof(AbpAutoMapperModule))]
    public class MMHDemoXamarinSharedModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MMHDemoXamarinSharedModule).GetAssembly());
        }
    }
}