using System.Linq.Expressions;

namespace dotnetTemplate.Core.Interfaces.Repositories;

public interface IGenericRepository<TEntity> where TEntity : class
{
    public IEnumerable<TEntity> Get(
        Expression<Func<TEntity, bool>> filter = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
        string includeProperties = "");
    public TEntity GetById(int id);
    
    public TEntity Insert(TEntity entity);
    public TEntity Update(TEntity entity);
    public void Delete(int id);
}