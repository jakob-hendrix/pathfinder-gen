using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace PathfinderTools.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            // TODO: add our DbContext that would normally be in Startup.cs
            return services;
        }
    }
}
