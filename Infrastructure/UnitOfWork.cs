using ApplicationCore.Interfaces.Repositories;
using Infrastructure.Data;

namespace Infrastructure;

// This should go in a shared project 
public class UnitOfWork : IDisposable, IUnitOfWork
{

    private readonly MigrationAndSeedContext _dbContext;

    public IUserRepository User { get; }

    public UnitOfWork(MigrationAndSeedContext dbContext, IUserRepository user)
    {
        _dbContext = dbContext;
        User = user;
    }

    public async Task CommitAsync()
    {
        await _dbContext.SaveChangesAsync();
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            _dbContext.Dispose();
        }
    }
}

