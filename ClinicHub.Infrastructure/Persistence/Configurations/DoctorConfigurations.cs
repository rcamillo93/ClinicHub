using ClinicHub.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicHub.Infrastructure.Persistence.Configurations
{
    public class DoctorConfigurations : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder
                .HasKey(d => d.Id);
            builder
                .HasOne(d => d.Address)
                .WithOne()
                .HasForeignKey<Doctor>(d => d.AddressId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(d => d.Specialty)
                .WithMany(d => d.Doctors)
                .HasForeignKey(d => d.SpecialtyId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(builder => builder.Crm)
                .IsRequired()
                .HasMaxLength(10);

            builder
              .Property(a => a.CreatedAt)
              .HasDefaultValueSql("GETUTCDATE()");

            builder
                .Property(a => a.IsDeleted)
                .HasDefaultValue(false);
        }
    }
}