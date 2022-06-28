using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class MigrationAndSeedContext : DbContext
{
    public MigrationAndSeedContext(DbContextOptions<MigrationAndSeedContext> context) : base(context)
    {
    }
}
