using ClinicHub.Core.Entity;

namespace ClinicHub.Core.Repositores
{
    public interface IDoctorRepository
    {
        Task<Doctor?> GetDoctorByIdAsync(int id);
        Task AddAsync(Doctor doctor);
        Task UpdateAsync(Doctor doctor);
        Task<List<Doctor>> GetAllAsync(string? name);
    }
}