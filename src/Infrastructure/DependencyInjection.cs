using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Lomboque.Infrastructure.Persistence;
using Lomboque.Infrastructure.Services;
using Lomboque.Application.Common.Interfaces;

namespace Lomboque.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options=>
                options.UseSqlite(configuration.GetConnectionString("Application"), migrations=> 
                    migrations.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName))
            );
            services.AddScoped<IApplicationDbContext>(provider =>
                provider.GetRequiredService<ApplicationDbContext>()
            );

            services.AddSingleton<RuntimeService>();
            services.AddSingleton<IRuntimeService>(provider => provider
                .GetRequiredService<RuntimeService>());

            return services;
        }
    }
}