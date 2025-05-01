using ClinicHub.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicHub.Infrastructure.Persistence.Configurations
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.FullName)
                   .IsRequired()
                   .HasMaxLength(150);

            builder.Property(u => u.Email)
                   .IsRequired()
                   .HasMaxLength(150);

            builder.Property(u => u.Password)
                   .IsRequired();

            builder.Property(u => u.BirthDate)
                   .IsRequired();

            builder.Property(u => u.Phone)
                   .IsRequired()
                   .HasMaxLength(20);

            builder.Property(u => u.Cpf)
                   .IsRequired()
                   .HasMaxLength(14);

            builder.Property(u => u.Role)
                   .IsRequired()
                   .HasConversion<string>()
                   .HasMaxLength(25);

            builder.HasOne(u => u.Doctor)
                   .WithOne(d => d.User)
                   .HasForeignKey<Doctor>(d => d.UserId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
