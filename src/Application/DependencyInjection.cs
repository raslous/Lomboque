using Microsoft.Extensions.DependencyInjection;
using FluentValidation;
using Lomboque.Application.Actions;

namespace Lomboque.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<DataController>();

            return services;
        }
    }
}