using ApplicationCore.Entities;
using ApplicationCore.Interfaces.Repositories;

namespace Infrastructure.Repositories;

public class UserRepository : GenericRepository<User>, IUserRepository
{

    public UserRepository(IUnitOfWork<User> unitOfWork) : base(unitOfWork)
    {

    }

    public Task<User> AddAsync(User entity)
    {
        throw new NotImplementedException();
    }

    public  Task<User> UpdateAsync(User entity)
    {
        throw new NotImplementedException();
    }

    public  Task DeleteAsync(User entity)
    {
        throw new NotImplementedException();
    }
}
