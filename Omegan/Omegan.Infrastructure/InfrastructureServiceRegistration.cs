using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Omegan.Application.Contracts.Identity;
using Omegan.Application.Contracts.Persistence;
using Omegan.Application.Interfaces.Common;
using Omegan.Application.Models.Identity;
using Omegan.Domain.Models;
using Omegan.Infrastructure.Common;
using Omegan.Infrastructure.Persistence;
using Omegan.Infrastructure.Repositories;
using Omegan.Infrastructure.Services;
using System.Text;

namespace Omegan.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {


            // connect to mysql with connection string from app settings
            var connectionString = configuration.GetConnectionString("MariaDbConnectionString");

            services.Configure<JwtSettings>(configuration.GetSection("JwtSettings"));

            services.AddDbContext<OmeganDbContext>(options =>
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

            services.AddIdentity<ApplicationUser, IdentityRole>()
               .AddEntityFrameworkStores<OmeganDbContext>().AddDefaultTokenProviders();

           
            services.AddScoped(typeof(IGenericRepository<,>), typeof(GenericRepository<,>));

            services.AddTransient<IAuthService, AuthService>();

            services.AddTransient<IDateTime, DateTimeService>();

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero,
                    ValidIssuer = configuration["JwtSettings:Issuer"],
                    ValidAudience = configuration["JwtSettings:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtSettings:Key"]))
                };

            });

            return services;
        }

    }
}
