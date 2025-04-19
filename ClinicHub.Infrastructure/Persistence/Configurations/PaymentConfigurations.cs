using ClinicHub.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicHub.Infrastructure.Persistence.Configurations
{
    public class PaymentConfigurations : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.ToTable("Payments");

            builder
                .HasKey(p => p.Id);

            builder
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();
            builder
                .Property(p => p.Amount)
                .HasColumnType("decimal(18,2)");

            builder
                .Property(p => p.PaymentDate)
                .IsRequired();

            builder
                .Property(p => p.PaymentType)
                .IsRequired();

            builder
                .Property(p => p.CustomerServiceId)
                .IsRequired();

            builder
                .HasOne<CustomerService>()
                .WithOne(cs => cs.Payment)
                .HasForeignKey<Payment>(p => p.CustomerServiceId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
