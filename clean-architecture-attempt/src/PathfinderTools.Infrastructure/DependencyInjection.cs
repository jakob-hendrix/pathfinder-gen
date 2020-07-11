using System;
using System.IO;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Data.Sqlite;
using PathfinderTools.Application.Interfaces;
using PathfinderTools.Infrastructure.Data;

namespace PathfinderTools.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration config)
        {
            //var dbDataDirectory = config["DataDirectory"];
            //AppDomain.CurrentDomain.SetData("DataDirectory", dbDataDirectory);


            var connString = BuildSqliteConnectionString(config.GetConnectionString("PathfinderDatabase"));
            services.AddDbContext<PathfinderDbContext>(options =>
                options.UseSqlite(connString));

            // wire up our implementation of the pathfinder db
            services.AddScoped<IPathfinderDbContext>(provider => provider.GetService<PathfinderDbContext>());

            return services;
        }

        private static string BuildSqliteConnectionString(string connectionString)
        {
            var builder = new SqliteConnectionStringBuilder(connectionString);
            //builder.DataSource = Path.Combine("|DataDirectory|", builder.DataSource);

            return builder.ConnectionString;
        }

    }
}
