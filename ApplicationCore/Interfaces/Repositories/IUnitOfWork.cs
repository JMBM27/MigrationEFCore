namespace ApplicationCore.Interfaces.Repositories;

public interface IUnitOfWork
{
    IUserRepository User { get; }
    Task CommitAsync();

}
