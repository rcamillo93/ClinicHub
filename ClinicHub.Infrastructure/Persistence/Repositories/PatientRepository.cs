using ClinicHub.Core.Entity;
using ClinicHub.Core.Repositores;

namespace ClinicHub.Infrastructure.Persistence.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        public Task AddAsync(Patient patient)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Patient>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Patient?> GetPatientByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Patient>> GetPatientsByDoctorIdAsync(int doctorId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Patient>> GetPatientsByHealthInsuranceIdAsync(int healthInsuranceId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Patient patient)
        {
            throw new NotImplementedException();
        }
    }
}