using ApplicationCore.Entities;
using ApplicationCore.Interfaces.Repositories;
using Infrastructure.Data;
using Infrastructure.Repositories;

namespace Infrastructure;

public class UnitOfWork<TContext> : IUnitOfWork<TContext> where TContext : MigrationAndSeedContext, IDisposable
{
    private TContext _context;

    public UnitOfWork()
    {

    }

    public TContext Context
    {
        get { return _context; }
    }


    public async Task CommitAsync()
    {
        await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
       _context.Dispose();
    }
}
