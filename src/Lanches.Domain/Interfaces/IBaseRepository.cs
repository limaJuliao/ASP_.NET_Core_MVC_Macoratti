using Lanches.Domain.Entities;

namespace Lanches.Domain.Interfaces;

public interface IBaseRepository<TEntity> where TEntity : BaseEntity
{
    IQueryable<TEntity> GetAll();
    TEntity? GetById(int id);
    TEntity? Add(TEntity entity);
    TEntity? Delete(TEntity entity);
    TEntity? Update(TEntity entity);

}
