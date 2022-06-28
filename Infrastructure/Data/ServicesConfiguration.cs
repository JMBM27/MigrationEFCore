using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Data;

public static class ServicesConfiguration
{
    public static void ServiceConfiguration(IConfiguration configuration, IServiceCollection service)
    {
        service.AddDbContext<MigrationAndSeedContext>(option =>
        {
            option.UseSqlServer(// Indicates the database connection
                                configuration.GetConnectionString("MigrationAndSeedsConnection"),
                                // This is use if you want to move your migrations out the project where the
                                // dbcontext is (only for reference)
                                migration => migration.MigrationsAssembly("Infrastructure"));

            #region Dependency Injection


            #endregion
        });
    }
}
