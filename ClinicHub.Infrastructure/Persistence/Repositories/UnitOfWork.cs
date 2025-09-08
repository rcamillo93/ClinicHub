using ClinicHub.Core.Repositores;
using Microsoft.EntityFrameworkCore;

namespace ClinicHub.Infrastructure.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ClinicHubDbContext _context;

        public UnitOfWork(ClinicHubDbContext context,
                            ISpecialtyRepository specialties,
                            IServiceRepository services,
                            IHealthInsuranceRepository healthInsurances,
                            IConsultationTypeRepository consultationTypes,
                            ICustomerServiceRepository customerServices,
                            IPatientRepository patients,
                            IUserRepository users,
                            IDoctorRepository doctors,
                            IPricingRepository pricing)
        {
            _context = context;
            Specialties = specialties;
            Services = services;
            HealthInsurances = healthInsurances;
            ConsultationTypes = consultationTypes;
            CustomerServices = customerServices;
            Patients = patients;
            Users = users;
            Doctors = doctors;
            Pricings = pricing;
        }

        public IUserRepository Users { get; }
        public IDoctorRepository Doctors { get; }

        public ISpecialtyRepository Specialties { get; }

        public IServiceRepository Services { get; }

        public IHealthInsuranceRepository HealthInsurances { get; }

        public IConsultationTypeRepository ConsultationTypes { get; }

        public ICustomerServiceRepository CustomerServices { get; }

        public IPricingRepository Pricings { get; }

        public IPatientRepository Patients { get; }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }
}