using Microsoft.Extensions.Configuration;

namespace PathfinderIM.Utilities
{
    public interface IConfigurationService
    {
        IConfiguration GetConfiguration();
    }
}
