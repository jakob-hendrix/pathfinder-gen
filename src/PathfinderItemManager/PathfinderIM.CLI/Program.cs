﻿using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PathfinderIM.CLI.Services;
using PathfinderIM.DataAccess;

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
            serviceProvider
                .GetService<ConsoleApplication>()
                .Run();
        }

        private static IServiceCollection ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();

            // Grab any base config settings we need
            var config = LoadConfiguration();
            services.AddLogging(logging =>
            {
                logging.AddConfiguration(config.GetSection("Logging"));
                logging.AddConsole();

            }).Configure<LoggerFilterOptions>
                (options => options.MinLevel = LogLevel.Information);

            // Add the config to our DI container for later use
            services.AddSingleton(config);
//            services.AddTransient<ITestService, TestService>();


            // Set up our Db context
            var connectionString = config.GetConnectionString("ItemsSql");
            services.AddDbContext<PathfinderIMContext>
            (
            //options => options.UseSqlite(connectionString)
            options => options.UseSqlServer(connectionString)
            );
            
            // Register out application entry point
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
