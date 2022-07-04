using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class MigrationAndSeedContext : DbContext
{
    public MigrationAndSeedContext(DbContextOptions<MigrationAndSeedContext> context) : base(context)
    {
    }

    public DbSet<User> User { get; set; }

    public DbSet<Company> Company { get; set; }

    public DbSet<Catalog> Catalog { get; set; }
}
