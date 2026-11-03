using Ecommerce.Api.Entities;

using Microsoft.AspNetCore.Identity;

namespace Ecommerce.Api;

public static class DependencyInjection
{
    extension(IServiceCollection services)
    {
        public IServiceCollection AddDependencyInjection(IConfiguration configuration)
        {
            services
                .AddDatabaseServices(configuration)
                .AddIdentityServices();

            return services;
        }

        private IServiceCollection AddDatabaseServices(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection")
                ?? throw new InvalidOperationException("Connection string 'DefaultConnection' is not found.");

            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

            return services;
        }

        private IServiceCollection AddIdentityServices()
        {
            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredLength = 8;

                options.User.RequireUniqueEmail = true;
            })
            .AddEntityFrameworkStores<ApplicationDbContext>();

            return services;
        }
    }
}
