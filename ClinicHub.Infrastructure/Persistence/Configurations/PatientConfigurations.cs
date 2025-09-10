using ClinicHub.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicHub.Infrastructure.Persistence.Configurations
{
    public class PatientConfigurations : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder
                .HasKey(p => p.Id);

            builder
                .Property(p => p.FullName)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(p => p.Phone)
                .IsRequired() 
                .HasMaxLength(50);
            builder
                .Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(80);
            builder
                .Property(p => p.CPF)
                .IsRequired()
                .HasMaxLength(15);

            builder
                .Property(p => p.Height)
                .HasPrecision(3, 3);
            builder
                .Property(p => p.Weight)
                .HasPrecision(3, 3);

            builder
               .HasOne(p => p.Address)
               .WithOne()
               .HasForeignKey<Patient>(p => p.AddressId)
               .IsRequired(false)
               .OnDelete(DeleteBehavior.Restrict);

            builder
              .Property(a => a.CreatedAt)
              .HasDefaultValueSql("GETUTCDATE()");

            builder
                .Property(a => a.IsDeleted)
                .HasDefaultValue(false);
        }
    }
}
