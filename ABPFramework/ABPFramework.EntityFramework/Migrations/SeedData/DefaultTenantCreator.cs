using System.Linq;
using ABPFramework.EntityFramework;
using ABPFramework.MultiTenancy;

namespace ABPFramework.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly ABPFrameworkDbContext _context;

        public DefaultTenantCreator(ABPFrameworkDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
