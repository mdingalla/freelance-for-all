using FreelanceForAll.EntityFramework;
using EntityFramework.DynamicFilters;

namespace FreelanceForAll.Migrations.SeedData
{
    public class InitialDataBuilder
    {
        private readonly FreelanceForAllDbContext _context;

        public InitialDataBuilder(FreelanceForAllDbContext context)
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
