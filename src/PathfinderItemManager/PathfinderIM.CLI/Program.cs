using Microsoft.Extensions.DependencyInjection;
using PathfinderIM.CLI.Services;

namespace PathfinderIM.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            // configure services
            IServiceCollection services = ConfigureServices();

            // create data provider
            var serviceProvider = services.BuildServiceProvider();

            // start running the program
            serviceProvider.GetService<ConsoleApplication>().Run();
        }

        private static IServiceCollection ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddTransient<ITestService, TestService>();
            services.AddTransient<ConsoleApplication>();
            return services;
        }
    }
}
