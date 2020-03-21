using System.IO;
using Microsoft.Extensions.Configuration;
using PathfinderIM.Utilities;

namespace PathfinderIM.CLI.Services
{
    public class ConfigurationService : IConfigurationService
    {
        public string CurrentDirectory { get; set; }
        public IConfiguration GetConfiguration()
        {
            CurrentDirectory ??= Directory.GetCurrentDirectory();
            var builder = new ConfigurationBuilder()
                .SetBasePath(CurrentDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            return builder.Build();
        }
    }
}
