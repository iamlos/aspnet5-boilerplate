using boilerplatetemplate.EntityFramework;
using EntityFramework.DynamicFilters;

namespace boilerplatetemplate.Migrations.SeedData
{
    public class InitialDataBuilder
    {
        private readonly boilerplatetemplateDbContext _context;

        public InitialDataBuilder(boilerplatetemplateDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            _context.DisableAllFilters();

            new DefaultEditionsBuilder(_context).Build();
            new DefaultTenantRoleAndUserBuilder(_context).Build();
            new DefaultLanguagesBuilder(_context).Build();
        }
    }
}
