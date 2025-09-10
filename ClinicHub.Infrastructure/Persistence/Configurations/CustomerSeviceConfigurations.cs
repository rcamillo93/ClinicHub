using ClinicHub.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicHub.Infrastructure.Persistence.Configurations
{
    public class CustomerSeviceConfigurations : IEntityTypeConfiguration<CustomerService>
    {
        public void Configure(EntityTypeBuilder<CustomerService> builder)
        {
            builder
                .ToTable("CustomerServices")
                .HasKey(cs => cs.Id);
            builder
                .Property(cs => cs.PatientId)
                .IsRequired();
            builder
                .Property(cs => cs.ServiceId)
                .IsRequired();

            builder
                .Property(cs => cs.StartAt)
                .IsRequired();

            builder
                .Property(cs => cs.TypeService)
                .IsRequired();

            builder
                .Property(cs => cs.StatusService)
                .IsRequired();

            builder
                .Property(cs => cs.Observations)
                .HasMaxLength(500);

            builder
                .Property(cs => cs.Value)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder
                .HasOne(cs => cs.Doctor)
                .WithMany(d => d.CustomerServices)
                .HasForeignKey(cs => cs.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(cs => cs.Patient)
                .WithMany(p => p.CustomerServices)
                .HasForeignKey(cs => cs.PatientId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(cs => cs.Service)
                .WithMany(s => s.CustomerServices)
                .HasForeignKey(cs => cs.ServiceId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(cs => cs.ConsultationType)
                .WithMany(ct => ct.CustomerServices)
                .HasForeignKey(cs => cs.ConsultationTypeId)
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
