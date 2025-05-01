using ClinicHub.Core.Entity;
using ClinicHub.Core.Repositores;

namespace ClinicHub.Infrastructure.Persistence.Repositories
{
    public class ConsultationTypeRepository : IConsultationTypeRepository
    {
        public Task AddAsync(ConsultationType consultationType)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ConsultationType>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ConsultationType?> GetConsultationTypeByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ConsultationType consultationType)
        {
            throw new NotImplementedException();
        }
    }
}