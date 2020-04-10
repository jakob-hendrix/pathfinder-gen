using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
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
        public DbSet<Spell> Spells { get; set; }
        public DbSet<Feat> Feats { get; set; }

        // Setting up a many-to-many relationship
        // https://blog.oneunicorn.com/2017/09/25/many-to-many-relationships-in-ef-core-2-0-part-1-the-basics/
        //
        // ie. construction requirements
        //
        // How do I model the complex objects of ConstructionRequirements in our Db - serialize & deserialize from JSON
        // https://stackoverflow.com/questions/20711986/entity-framework-code-first-cant-store-liststring/56727929#56727929
        //
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<WondrousItem>()
                .Property(p => p.Aura)
                .HasConversion(
                    v => JsonConvert.SerializeObject(v),
                    v => JsonConvert.DeserializeObject<Aura>(v));

            builder
                .Entity<WondrousItem>()
                .Property(p => p.ConstructionRequirements)
                .HasConversion(
                    v => JsonConvert.SerializeObject(v),
                    v => JsonConvert.DeserializeObject<List<ConstructionRequirement>>(v));

            base.OnModelCreating(builder);
        }
    }
}
