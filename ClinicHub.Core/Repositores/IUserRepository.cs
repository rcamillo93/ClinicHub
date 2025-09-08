using ClinicHub.Core.Entity;

namespace ClinicHub.Core.Repositores
{
    public interface IUserRepository
    {
        Task<User?> GetUserByIdAsync(int id);
        Task AddAsync(User order);
        Task UpdateAsync(User order);     
        Task<User?> GetUserById(int id);
        Task<List<User>> GetAllAsync(string? name);
    }
}