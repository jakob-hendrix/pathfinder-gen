using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PathfinderTools.Domain.Entities;

namespace PathfinderTools.Infrastructure.Configurations
{
    public class RaceConfiguration : IEntityTypeConfiguration<Race>
    {
        public void Configure(EntityTypeBuilder<Race> builder)
        {
            builder.Property(e => e.Name)
                .IsRequired();
        }
    }
}
