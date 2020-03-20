using Microsoft.EntityFrameworkCore;
using PathfinderIM.Entities.Models;

namespace PathfinderIM.DataAccess
{
    public class PathfinderIMContext : DbContext
    {
        public PathfinderIMContext(DbContextOptions<PathfinderIMContext> options)
            :base(options)
        {
            
        }

        public DbSet<WondrousItem> WondrousItems { get; set; }
        public DbSet<SourceBook> SourceBooks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
