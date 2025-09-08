using ClinicHub.Core.Entity;

namespace ClinicHub.Core.Repositores
{
    public interface ISpecialtyRepository
    {
        Task<Specialty?> GetSpecialtyByIdAsync(int id);
        Task AddAsync(Specialty specialty);
        Task<IEnumerable<Specialty>> GetAllAsync(string? name);
        Task<Specialty?> GetSpecialtyByNameAsync(string name);
        Task<Specialty?> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task<IEnumerable<Specialty>> GetSpecialtiesByDoctorIdAsync(int doctorId);
    }
}