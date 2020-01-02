using Abp.Modules;
using Abp.Reflection.Extensions;

namespace MMHDemo
{
    [DependsOn(typeof(MMHDemoXamarinSharedModule))]
    public class MMHDemoXamarinAndroidModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MMHDemoXamarinAndroidModule).GetAssembly());
        }
    }
}