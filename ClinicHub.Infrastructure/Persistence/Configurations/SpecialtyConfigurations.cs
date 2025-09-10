using ClinicHub.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace ClinicHub.Infrastructure.Persistence.Configurations
{
    public class SpecialtyConfigurations : IEntityTypeConfiguration<Specialty>
    {
        public void Configure(EntityTypeBuilder<Specialty> builder)
        {
            builder
                .ToTable("Specialties");
            builder
                .HasKey(s => s.Id);
            builder
                .Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(100);
            builder
                .Property(s => s.Description)
                .IsRequired()
                .HasMaxLength(400);

            builder
              .Property(a => a.CreatedAt)
              .HasDefaultValueSql("GETUTCDATE()");

            builder
                .Property(a => a.IsDeleted)
                .HasDefaultValue(false);
        }
    }
}