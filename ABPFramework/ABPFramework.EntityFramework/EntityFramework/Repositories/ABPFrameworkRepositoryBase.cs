using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace ABPFramework.EntityFramework.Repositories
{
    public abstract class ABPFrameworkRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ABPFrameworkDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ABPFrameworkRepositoryBase(IDbContextProvider<ABPFrameworkDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ABPFrameworkRepositoryBase<TEntity> : ABPFrameworkRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ABPFrameworkRepositoryBase(IDbContextProvider<ABPFrameworkDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
