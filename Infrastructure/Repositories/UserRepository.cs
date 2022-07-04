
using ApplicationCore.Entities;
using ApplicationCore.Interfaces.Repositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class UserRepository : GenericRepository<User>, IUserRepository
{

    public UserRepository(MigrationAndSeedContext context) : base(context)
    {

    }

    public async Task<IEnumerable<User>> GetAllAsync()
    {
        return await _context.User
                        .Include(d => d.Company)
                        .ToListAsync();
    }

}

