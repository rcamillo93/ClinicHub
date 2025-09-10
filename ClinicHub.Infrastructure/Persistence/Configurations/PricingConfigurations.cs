using ClinicHub.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicHub.Infrastructure.Persistence.Configurations
{
    public class PricingConfigurations : IEntityTypeConfiguration<Pricing>
    {
        public void Configure(EntityTypeBuilder<Pricing> builder)
        {
            builder
                .HasKey(p => p.Id);

            builder
                .HasOne(p => p.Service)
                .WithMany(s => s.Pricings)
                .HasForeignKey(p => p.ServiceId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(p => p.Specialty)
                .WithMany(sp => sp.Pricings)
                .HasForeignKey(p => p.SpecialtyId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(p => p.ConsultationType)
                .WithMany(ct => ct.Pricings)
                .HasForeignKey(p => p.ConsultationTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(p => p.HealthInsurance)
                .WithMany(h => h.Pricings)
                .HasForeignKey(p => p.HealthInsuranceId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);

            builder
              .Property(a => a.CreatedAt)
              .HasDefaultValueSql("GETUTCDATE()");

            builder
                .Property(a => a.IsDeleted)
                .HasDefaultValue(false);
        }
    }
}
