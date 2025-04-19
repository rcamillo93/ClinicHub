using ClinicHub.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicHub.Infrastructure.Persistence.Configurations
{
    public class HealthInsuranceConfigurations : IEntityTypeConfiguration<HealthInsurance>
    {
        public void Configure(EntityTypeBuilder<HealthInsurance> builder)
        {
            builder
                .ToTable("HealthInsurances");

            builder
                .HasKey(h => h.Id);

            builder
                .Property(h => h.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(h => h.Description)
                .IsRequired()
                .HasMaxLength(500);

            builder
                .Property(h => h.Discount)
                .IsRequired()
                .HasColumnType("decimal(3,2)");

            builder
                .Property(h => h.Validity)
                .IsRequired();
        }
    }
}
