using Microsoft.Extensions.DependencyInjection;
using FluentValidation;
using Lomboque.Application.Actions;
using Lomboque.Application.Common.Managers;

namespace Lomboque.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<AppController>();
            services.AddSingleton<ApplicationManager>();

            return services;
        }
    }
}