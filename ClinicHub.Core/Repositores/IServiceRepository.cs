using ClinicHub.Core.Entity;

namespace ClinicHub.Core.Repositores
{
    public interface IServiceRepository
    {
        Task<Service?> GetServiceByIdAsync(int id);
        Task AddAsync(Service service);
        Task<IEnumerable<Service>> GetAllAsync(string? name);
        Task DeleteAsync(int id);
        Task<IEnumerable<Service>> GetServicesByDoctorIdAsync(int doctorId);
    }
}