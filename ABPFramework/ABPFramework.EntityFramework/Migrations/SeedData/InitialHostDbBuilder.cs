﻿using ABPFramework.EntityFramework;
using EntityFramework.DynamicFilters;

namespace ABPFramework.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly ABPFrameworkDbContext _context;

        public InitialHostDbBuilder(ABPFrameworkDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
