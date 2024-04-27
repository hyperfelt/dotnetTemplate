using System.Linq.Expressions;
using dotnetTemplate.Core.Attributes;
using dotnetTemplate.Core.Interfaces.Repositories;

namespace dotnetTemplate.Persistence.Repositories;

[LogAndMeasure]
public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
{
    public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
    {
        throw new NotImplementedException();
    }

    public TEntity GetById(int id)
    {
        throw new NotImplementedException();
    }

    public TEntity Insert(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public TEntity Update(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }
}