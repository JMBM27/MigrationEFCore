using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class MigrationAndSeedContext : DbContext
{
    public MigrationAndSeedContext(DbContextOptions<MigrationAndSeedContext> context) : base(context)
    {
    }

    public DbSet<User> User;

    public DbSet<Company> Company;

    public DbSet<Catalog> Catalog;
}
