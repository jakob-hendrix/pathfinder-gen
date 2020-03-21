using Microsoft.EntityFrameworkCore;
using PathfinderIM.Entities.Models;

namespace PathfinderIM.Data
{
    public class PathfinderItemContext : DbContext
    {
        public PathfinderItemContext(DbContextOptions<PathfinderItemContext> options)
            :base(options)
        { }

        public DbSet<WondrousItem> WondrousItems { get; set; }
        public DbSet<SourceBook> SourceBooks { get; set; }
    }
}
