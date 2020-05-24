using Microsoft.EntityFrameworkCore;
using PathfinderTools.Domain.Entities;

namespace PathfinderTools.Application.Interfaces
{
    public interface IPathfinderDbContext
    {
        public DbSet<CharacterClass> CharacterClasses { get; set; }
        public DbSet<Race> Races { get; set; }
    }
}
