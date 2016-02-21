using System.Data.Common;
using Abp.Zero.EntityFramework;
using FreelanceForAll.Authorization.Roles;
using FreelanceForAll.MultiTenancy;
using FreelanceForAll.Users;

namespace FreelanceForAll.EntityFramework
{
    public class FreelanceForAllDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public FreelanceForAllDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in FreelanceForAllDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of FreelanceForAllDbContext since ABP automatically handles it.
         */
        public FreelanceForAllDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public FreelanceForAllDbContext(DbConnection connection)
            : base(connection, true)
        {

        }
    }
}
