using System.Data.Entity.Migrations;
using FreelanceForAll.Migrations.SeedData;

namespace FreelanceForAll.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<FreelanceForAll.EntityFramework.FreelanceForAllDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "FreelanceForAll";
        }

        protected override void Seed(FreelanceForAll.EntityFramework.FreelanceForAllDbContext context)
        {
            new InitialDataBuilder(context).Build();
        }
    }
}
