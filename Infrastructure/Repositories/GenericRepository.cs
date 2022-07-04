using ApplicationCore.Interfaces.Repositories;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
{
    protected readonly MigrationAndSeedContext _context;

    public GenericRepository(MigrationAndSeedContext context)
    {
        _context = context;
    }

    public virtual async Task AddAsync(TEntity entity)
    {
        await _context.Set<TEntity>().AddAsync(entity);
    }

    public virtual void UpdateAsync(TEntity entity)
    {
        _context.Set<TEntity>().Update(entity);
    }

    public virtual void DeleteAsync(TEntity entity)
    {
        _context.Set<TEntity>().Remove(entity);
    }
}
