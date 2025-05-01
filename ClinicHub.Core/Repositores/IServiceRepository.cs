using ClinicHub.Core.Entity;

namespace ClinicHub.Core.Repositores
{
    public interface IServiceRepository
    {
        Task<Service?> GetServiceByIdAsync(int id);
        Task AddAsync(Service service);
        Task UpdateAsync(Service service);
        Task<IEnumerable<Service>> GetAllAsync();
        Task DeleteAsync(int id);
        Task<IEnumerable<Service>> GetServicesByDoctorIdAsync(int doctorId);
        Task<IEnumerable<Service>> GetServicesByHealthInsuranceIdAsync(int healthInsuranceId);
    }
}