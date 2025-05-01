using ClinicHub.Core.Entity;
using ClinicHub.Core.Repositores;

namespace ClinicHub.Infrastructure.Persistence.Repositories
{
    public class SpecialtyRepository : ISpecialtyRepository
    {
        public Task AddAsync(Specialty specialty)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Specialty>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Specialty>> GetSpecialtiesByDoctorIdAsync(int doctorId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Specialty>> GetSpecialtiesByHealthInsuranceIdAsync(int healthInsuranceId)
        {
            throw new NotImplementedException();
        }

        public Task<Specialty?> GetSpecialtyByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Specialty specialty)
        {
            throw new NotImplementedException();
        }
    }
}