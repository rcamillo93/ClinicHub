using ClinicHub.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
        }

    }
}