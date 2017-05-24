using System.Data.Entity.Migrations;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using ABPFramework.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace ABPFramework.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<ABPFramework.EntityFramework.ABPFrameworkDbContext>, IMultiTenantSeed
    {
        public AbpTenantBase Tenant { get; set; }

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ABPFramework";
        }

        protected override void Seed(ABPFramework.EntityFramework.ABPFrameworkDbContext context)
        {
            context.DisableAllFilters();

            if (Tenant == null)
            {
                //Host seed
                new InitialHostDbBuilder(context).Create();

                //Default tenant seed (in host database).
                new DefaultTenantCreator(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
            }
            else
            {
                //You can add seed for tenant databases and use Tenant property...
            }

            context.SaveChanges();
        }
    }
}
