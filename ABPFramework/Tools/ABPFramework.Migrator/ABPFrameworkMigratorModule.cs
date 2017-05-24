using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using ABPFramework.EntityFramework;

namespace ABPFramework.Migrator
{
    [DependsOn(typeof(ABPFrameworkDataModule))]
    public class ABPFrameworkMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<ABPFrameworkDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}