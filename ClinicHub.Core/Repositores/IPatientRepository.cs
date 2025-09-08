using ClinicHub.Core.Entity;

namespace ClinicHub.Core.Repositores
{
    public interface IPatientRepository
    {
        Task<Patient?> GetPatientByIdAsync(int id);
        Task AddAsync(Patient patient);  
        Task<IEnumerable<Patient>> GetAllAsync(string? name);
        Task DeleteAsync(int id);
        Task<IEnumerable<Patient>> GetPatientsByDoctorIdAsync(int doctorId);
        Task<IEnumerable<Patient>> GetPatientsByHealthInsuranceIdAsync(int healthInsuranceId);
    }
}