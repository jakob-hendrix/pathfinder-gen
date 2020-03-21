using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using PathfinderIM.CLI.Services;
using PathfinderIM.DataAccess;

namespace PathfinderIM.CLI.DesignTooling
{
    public class PathfinderItemContextFactory : IDesignTimeDbContextFactory<PathfinderItemContext>
    {
        public PathfinderItemContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationService().GetConfiguration();
            var builder = new DbContextOptionsBuilder<PathfinderItemContext>();
            var context = new PathfinderItemContext(builder.UseSqlite(
                config.GetConnectionString(nameof(PathfinderItemContext)), 
                options => options.MigrationsAssembly("PathfinderIM.DataAccess")).Options);
            return context;
        }
    }
}
