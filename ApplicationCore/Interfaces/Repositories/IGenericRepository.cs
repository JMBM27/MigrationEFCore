namespace ApplicationCore.Interfaces.Repositories;

public interface IGenericRepository<TEntity> where TEntity : class
{
    Task AddAsync(TEntity entity);

    void UpdateAsync(TEntity entity);

    void DeleteAsync(TEntity entity);
}
