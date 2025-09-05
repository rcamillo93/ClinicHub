using ClinicHub.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicHub.Infrastructure.Persistence.Configurations
{
    public class ConsultationTypeConfigurations : IEntityTypeConfiguration<ConsultationType>
    {
        public void Configure(EntityTypeBuilder<ConsultationType> builder)
        {
            builder
                .ToTable("ConsultationTypes")
                .HasKey(ct => ct.Id);
            builder
                .Property(ct => ct.Title)
                .IsRequired()
                .HasMaxLength(100);
            builder
                .Property(ct => ct.Description)
                .IsRequired()
                .HasMaxLength(500); 
        }
    }    
}