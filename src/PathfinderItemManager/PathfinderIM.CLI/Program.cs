using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PathfinderIM.CLI.Services;
using PathfinderIM.Data;

namespace PathfinderIM.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = ConfigureServices();
            var serviceProvider = services.BuildServiceProvider();

            ConfigureData(serviceProvider);

            // start running the program
            serviceProvider
                .GetService<ConsoleApplication>()
                .Run();
        }

        private static void ConfigureData(ServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<PathfinderItemContext>();
            
            Console.WriteLine("Seeding data");
            DataInitializer.InitializeData(context);
            Console.WriteLine("Data seed complete.");
        }

        private static IServiceCollection ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();

            // Grab any base config settings we need
            var config = new ConfigurationService().GetConfiguration();
            services.AddLogging(logging =>
            {
                logging.AddConfiguration(config.GetSection("Logging"));
                logging.AddConsole();

            }).Configure<LoggerFilterOptions>
                (options => options.MinLevel = LogLevel.Information);

            // Add the config to our DI container for later use
            services.AddSingleton(config);

            // Set up our Db context
            services.AddDbContext<PathfinderItemContext>
            (
            //options => options.UseSqlite(connectionString)
            options => options.UseSqlServer(config.GetConnectionString(nameof(PathfinderItemContext)))
            );

            // Register out application entry point
            services.AddTransient<ConsoleApplication>();

            return services;
        }
    }
}
