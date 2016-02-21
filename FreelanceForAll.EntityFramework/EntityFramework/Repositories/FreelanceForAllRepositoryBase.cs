using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace FreelanceForAll.EntityFramework.Repositories
{
    public abstract class FreelanceForAllRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<FreelanceForAllDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected FreelanceForAllRepositoryBase(IDbContextProvider<FreelanceForAllDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class FreelanceForAllRepositoryBase<TEntity> : FreelanceForAllRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected FreelanceForAllRepositoryBase(IDbContextProvider<FreelanceForAllDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
