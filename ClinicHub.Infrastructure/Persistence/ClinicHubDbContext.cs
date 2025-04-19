using ClinicHub.Core.Entity;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ClinicHub.Infrastructure.Persistence
{
    public class ClinicHubDbContext : DbContext
    {
        public ClinicHubDbContext(DbContextOptions<ClinicHubDbContext> options) : base(options) { }
        
        public DbSet<Address> Addresses { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<ConsultationType> ConsultationTypes { get; set; }
        public DbSet<CustomerService> CustomerServices { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<HealthInsurance> HealthInsurances { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Secretary> Secretaries { get; set; }
        public DbSet<Service> Services { get; set; }        
        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<State> States { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
