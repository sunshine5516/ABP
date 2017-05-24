using System.Data.Common;
using Abp.Zero.EntityFramework;
using ABPFramework.Authorization.Roles;
using ABPFramework.MultiTenancy;
using ABPFramework.Users;

namespace ABPFramework.EntityFramework
{
    public class ABPFrameworkDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public ABPFrameworkDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in ABPFrameworkDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of ABPFrameworkDbContext since ABP automatically handles it.
         */
        public ABPFrameworkDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public ABPFrameworkDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public ABPFrameworkDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
