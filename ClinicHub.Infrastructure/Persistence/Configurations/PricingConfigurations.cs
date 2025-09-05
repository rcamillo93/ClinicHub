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
                .HasOne<Service>()
                .WithMany(s => s.Pricings)
                .HasForeignKey(p => p.ServiceId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne<Specialty>()
                .WithMany(sp => sp.Pricings)
                .HasForeignKey(p => p.SpecialtyId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne<ConsultationType>()
                .WithMany(ct => ct.Pricings)
                .HasForeignKey(p => p.ConsultationTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne<HealthInsurance>()
                .WithMany(h => h.Pricings)
                .HasForeignKey(p => p.HealthInsuranceId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);
        }
    }
}
