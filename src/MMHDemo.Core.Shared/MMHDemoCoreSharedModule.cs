using Abp.Modules;
using Abp.Reflection.Extensions;

namespace MMHDemo
{
    public class MMHDemoCoreSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MMHDemoCoreSharedModule).GetAssembly());
        }
    }
}