using Microsoft.EntityFrameworkCore;
using PathfinderTools.Infrastructure.Data;

namespace PathfinderTools.Infrastructure
{
    public class PathfinderDbContextFactory : DesignTimeDbContextFactoryBase<PathfinderDbContext>
    {
        protected override PathfinderDbContext CreateNewInstance(DbContextOptions<PathfinderDbContext> options) => new PathfinderDbContext(options);
    }
}
