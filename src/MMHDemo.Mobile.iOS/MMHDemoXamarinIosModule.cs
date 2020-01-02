using Abp.Modules;
using Abp.Reflection.Extensions;

namespace MMHDemo
{
    [DependsOn(typeof(MMHDemoXamarinSharedModule))]
    public class MMHDemoXamarinIosModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MMHDemoXamarinIosModule).GetAssembly());
        }
    }
}