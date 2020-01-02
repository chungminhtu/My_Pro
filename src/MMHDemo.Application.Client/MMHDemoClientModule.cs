using Abp.Modules;
using Abp.Reflection.Extensions;

namespace MMHDemo
{
    public class MMHDemoClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MMHDemoClientModule).GetAssembly());
        }
    }
}
