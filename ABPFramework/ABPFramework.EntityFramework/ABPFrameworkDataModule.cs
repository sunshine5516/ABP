using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using ABPFramework.EntityFramework;

namespace ABPFramework
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(ABPFrameworkCoreModule))]
    public class ABPFrameworkDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ABPFrameworkDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
