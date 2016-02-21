using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace FreelanceForAll
{
    [DependsOn(typeof(FreelanceForAllCoreModule), typeof(AbpAutoMapperModule))]
    public class FreelanceForAllApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
