using ClinicHub.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicHub.Infrastructure.Persistence.Configurations
{
    public class SecretaryConfigurations : IEntityTypeConfiguration<Secretary>
    {
        public void Configure(EntityTypeBuilder<Secretary> builder)
        {
            builder
                .ToTable("Secretaries")
                .HasKey(s => s.Id);

            builder
                .Property(s => s.CPF)
                .IsRequired()
                .HasMaxLength(11);

            builder
               .Property(s => s.Email)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(s => s.FullName)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(s => s.BirthDate)
                .IsRequired();

            builder
                .Property(s => s.Phone)
                .IsRequired()
                .HasMaxLength(15);
        }
    }
}
