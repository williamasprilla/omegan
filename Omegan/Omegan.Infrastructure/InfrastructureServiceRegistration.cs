using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Omegan.Application.Contracts.Persistence;
using Omegan.Infrastructure.Persistence;
using Omegan.Infrastructure.Repositories;

namespace Omegan.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {


            // connect to mysql with connection string from app settings
            var connectionString = configuration.GetConnectionString("MariaDbConnectionString");

            services.AddDbContext<OmeganDbContext>(options =>
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));


            return services;
        }

    }
}
