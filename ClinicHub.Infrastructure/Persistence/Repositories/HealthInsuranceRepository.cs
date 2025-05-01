using ClinicHub.Core.Entity;
using ClinicHub.Core.Repositores;

namespace ClinicHub.Infrastructure.Persistence.Repositories
{
    public class HealthInsuranceRepository : IHealthInsuranceRepository
    {
        public Task AddAsync(HealthInsurance healthInsurance)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<HealthInsurance>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<HealthInsurance?> GetHealthInsuranceByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(HealthInsurance healthInsurance)
        {
            throw new NotImplementedException();
        }
    }
}