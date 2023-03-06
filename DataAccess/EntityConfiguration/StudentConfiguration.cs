using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfiguration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(20);

            builder.Property(x => x.Surname).IsRequired().HasMaxLength(20);

            builder.Property(x => x.Identification).IsRequired().HasMaxLength(10);

            builder.Property(x => x.Age).IsRequired().HasMaxLength(2);

            builder.Property(x => x.IdAffinity).IsRequired();

            builder.Property(x => x.IdGrimoire).IsRequired();

            builder.Property(x => x.Status).HasDefaultValue(true).IsRequired();

            builder.Property(x => x.IsDeleted).HasDefaultValue(false).IsRequired();

            builder.Property(x => x.CreateDate).ValueGeneratedOnAdd().HasDefaultValue(DateTime.Now).IsRequired();

            builder.Property(x => x.UpdateDate).IsRequired(false);

            builder.HasOne(s => s.Grimoire)
                .WithOne(g => g.Student)
                .HasForeignKey<Student>(s => s.IdGrimoire)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(s => s.Affinity)
                .WithOne(a => a.Student)
                .HasForeignKey<Student>(s => s.IdAffinity)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
