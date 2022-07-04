using ApplicationCore.Entities;
using ApplicationCore.Interfaces.Repositories;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ApplicationCore.Helpers;
using ApplicationCore.Interfaces;

namespace Infrastructure.Data;

public static class ServicesConfiguration
{
    public static IServiceCollection AddInfrastructureConfiguration(this IServiceCollection service, IConfiguration configuration)
    {
        service.AddDbContext<MigrationAndSeedContext>(option =>
        {
            option.UseSqlServer(// Indicates the database connection
                                configuration.GetConnectionString("MigrationAndSeedsConnection"),
                                // This is use if you want to move your migrations out the project where the
                                // dbcontext is (only for reference)
                                migration => migration.MigrationsAssembly("Infrastructure"));
        });


        #region Dependency Injection
        service.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        service.AddTransient<IUnitOfWork, UnitOfWork>();
        service.AddTransient<IUserRepository, UserRepository>();
        #endregion

        return service;
    }

    public static IServiceProvider AddInfrastructureSeeds(this IServiceProvider service)
    {
        using (var scopped = service.CreateScope())
        {
            using (var context = scopped.ServiceProvider.GetService<MigrationAndSeedContext>())
            {
                Company company = new Company();

                if (!context.Company.Any()) 
                {
                    company.Name = "Face inc";
                    company.CreatedAt = DateTime.Now;
                    company.Active = true;
                    context.Company.Add(company);
                }


                if (!context.User.Any())
                {
                    var adminUser = new User
                    {
                        Email = "admin@admin.com",
                        Password = Cryptography.ReturnHash("admin123"),
                        CreatedAt = DateTime.Now,
                        Company = company
                    };

                    context.User.Add(adminUser);
                }

                context.SaveChanges();
            }
        }

        return service;
    }
}
