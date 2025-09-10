using ClinicHub.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicHub.Infrastructure.Persistence.Configurations
{
    public class AddressConfigurations : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder
               .HasKey(a => a.Id);

            builder
                .Property(a => a.CityId)
                .IsRequired();

            builder
                .Property(a => a.Neighborhood)
                .IsRequired();

            builder
                .Property(a => a.PublicPlace)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(a => a.CreatedAt)
                .HasDefaultValueSql("GETUTCDATE()");

            builder
                .Property(a => a.IsDeleted)
                .HasDefaultValue(false);
        }
    }
}