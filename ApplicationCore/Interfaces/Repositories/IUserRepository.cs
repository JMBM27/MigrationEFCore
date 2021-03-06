using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces.Repositories;

public interface IUserRepository : IGenericRepository<User>
{
    Task<IEnumerable<User>> GetAllAsync();
}
