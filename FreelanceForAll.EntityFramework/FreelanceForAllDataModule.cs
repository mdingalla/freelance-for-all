using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using FreelanceForAll.EntityFramework;

namespace FreelanceForAll
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(FreelanceForAllCoreModule))]
    public class FreelanceForAllDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
