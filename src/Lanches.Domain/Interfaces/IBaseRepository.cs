using Lanches.Domain.Entities;

namespace Lanches.Domain.Interfaces;

public interface IBaseRepository<TEntity>where TEntity : BaseEntity
{
    TEntity GetById(int id);
    TEntity Add(TEntity entity);
    TEntity Delete(TEntity entity);
    TEntity Update(TEntity entity);

}
