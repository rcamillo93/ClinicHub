using ClinicHub.Core.Entity;

namespace ClinicHub.Core.Repositores
{
    public interface IUserRepository
    {
        Task<User?> GetUserByIdAsync(int id);
        Task AddAsync(User order);
        Task UpdateAsync(User order);
        Task AddDoctor(Doctor doctor);
        Task UpdateDoctor(Doctor doctor);
        Task<Doctor> GetDoctorById(int id);
    }
}