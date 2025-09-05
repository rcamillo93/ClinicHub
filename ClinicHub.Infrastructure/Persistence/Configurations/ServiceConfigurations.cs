using ClinicHub.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicHub.Infrastructure.Persistence.Configurations
{
    public class ServiceConfigurations : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder
                .ToTable("Services");
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
                .Property(s => s.Duration)
                .IsRequired();
        }
    }
}
