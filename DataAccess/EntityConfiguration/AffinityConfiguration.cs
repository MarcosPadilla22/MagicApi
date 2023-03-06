using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfiguration
{
    public class AffinityConfiguration : IEntityTypeConfiguration<Affinity>
    {
        public void Configure(EntityTypeBuilder<Affinity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(128);

            builder.Property(x => x.Description).HasMaxLength(500);

            builder.Property(x => x.IsDeleted).HasDefaultValue(false).IsRequired();
        }
    }
}
