namespace ApplicationCore.Interfaces.Repositories;
public interface IUnitOfWork<T> where T : class
{
    Task CommitAsync();

}
