using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PathfinderIM.CLI.Services;

namespace PathfinderIM.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            // configure services
            var services = ConfigureServices();

            // create data provider
            var serviceProvider = services.BuildServiceProvider();

            // start running the program
            serviceProvider.GetService<ConsoleApplication>().Run();
        }

        private static IServiceCollection ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();

            var config = LoadConfiguration();

            services.AddSingleton(config);
            services.AddTransient<ITestService, TestService>();
            services.AddTransient<ConsoleApplication>();

            return services;
        }

        private static IConfiguration LoadConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            return builder.Build();
        }
    }
}
