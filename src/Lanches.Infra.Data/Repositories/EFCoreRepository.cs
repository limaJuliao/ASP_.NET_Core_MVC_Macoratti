using Lanches.Domain.Entities;
using Lanches.Domain.Interfaces;
using Lanches.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Lanches.Infra.Data.Repositories;

public abstract class EFCoreRepository<TEntity> : IBaseRepository<TEntity>
    where TEntity : BaseEntity
{
    private readonly AppDbContext _context;
    private readonly DbSet<TEntity> _dbSet;

    protected EFCoreRepository(AppDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<TEntity>();
    }

    public TEntity? Add(TEntity entity)
    {
        _dbSet.Add(entity);
        _context.SaveChanges();
        return entity;
    }

    public TEntity? Delete(TEntity entity)
    {
        _dbSet.Remove(entity);
        _context.SaveChanges();
        return entity;
    }

    public IQueryable<TEntity> GetAll()
    {
        return _dbSet;
    }

    public TEntity? GetById(int id)
    {
        return _dbSet.Find(id);
    }

    public TEntity? Update(TEntity entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
        _context.SaveChanges();
        return entity;
    }
}
