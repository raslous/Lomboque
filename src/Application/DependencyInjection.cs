using Microsoft.Extensions.DependencyInjection;
using FluentValidation;

namespace Lomboque.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            return services;
        }
    }
}