using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace boilerplatetemplate.EntityFramework.Repositories
{
    public abstract class boilerplatetemplateRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<boilerplatetemplateDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected boilerplatetemplateRepositoryBase(IDbContextProvider<boilerplatetemplateDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class boilerplatetemplateRepositoryBase<TEntity> : boilerplatetemplateRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected boilerplatetemplateRepositoryBase(IDbContextProvider<boilerplatetemplateDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
