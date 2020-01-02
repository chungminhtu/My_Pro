using Abp.Modules;
using Abp.Reflection.Extensions;

namespace MMHDemo
{
    [DependsOn(typeof(MMHDemoCoreSharedModule))]
    public class MMHDemoApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MMHDemoApplicationSharedModule).GetAssembly());
        }
    }
}