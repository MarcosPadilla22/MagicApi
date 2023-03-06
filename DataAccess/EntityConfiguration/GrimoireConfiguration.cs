using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfiguration
{
    public class GrimoireConfiguration : IEntityTypeConfiguration<Grimoire>
    {
        public void Configure(EntityTypeBuilder<Grimoire> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(128);

            builder.Property(x => x.Description).IsRequired().HasMaxLength(500);

            builder.Property(x => x.IsDeleted).HasDefaultValue(false).IsRequired();
        }
    }
}
