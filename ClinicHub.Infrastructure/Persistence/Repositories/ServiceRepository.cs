using ClinicHub.Core.Entity;
using ClinicHub.Core.Repositores;

namespace ClinicHub.Infrastructure.Persistence.Repositories
{
    public class ServiceRepository : IServiceRepository
    {
        public Task AddAsync(Service service)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Service>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Service?> GetServiceByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Service>> GetServicesByDoctorIdAsync(int doctorId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Service>> GetServicesByHealthInsuranceIdAsync(int healthInsuranceId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Service service)
        {
            throw new NotImplementedException();
        }
    }
}