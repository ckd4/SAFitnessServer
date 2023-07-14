using Microsoft.Extensions.DependencyInjection;
using Server.Core.Application.Services;

namespace Server.Core.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IAuthentificationService, AuthentificationService>();
            return services;
        }
    }
}
