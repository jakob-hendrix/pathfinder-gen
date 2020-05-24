using Microsoft.EntityFrameworkCore;
using PathfinderTools.Application.Interfaces;
using PathfinderTools.Domain.Entities;

namespace PathfinderTools.Infrastructure.Data
{
    public class PathfinderDbContext : DbContext, IPathfinderDbContext
    {
        public PathfinderDbContext(DbContextOptions<PathfinderDbContext> options)
            : base(options)
        {

        }

        public DbSet<CharacterClass> CharacterClasses { get; set; }
        public DbSet<Race> Races { get; set; }

        // TODO: useful?
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PathfinderDbContext).Assembly);
        }
    }
}
