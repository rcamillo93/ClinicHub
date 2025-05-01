using ClinicHub.Core.Entity;

namespace ClinicHub.Core.Repositores
{
    public interface ISpecialtyRepository
    {
        Task<Specialty?> GetSpecialtyByIdAsync(int id);
        Task AddAsync(Specialty specialty);
        Task UpdateAsync(Specialty specialty);
        Task<IEnumerable<Specialty>> GetAllAsync();
        Task DeleteAsync(int id);
        Task<IEnumerable<Specialty>> GetSpecialtiesByDoctorIdAsync(int doctorId);
        Task<IEnumerable<Specialty>> GetSpecialtiesByHealthInsuranceIdAsync(int healthInsuranceId);
    }
}