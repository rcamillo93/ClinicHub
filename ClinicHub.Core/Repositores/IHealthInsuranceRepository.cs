using ClinicHub.Core.Entity;

namespace ClinicHub.Core.Repositores
{
    public interface IHealthInsuranceRepository
    {
        Task<HealthInsurance?> GetHealthInsuranceByIdAsync(int id);
        Task AddAsync(HealthInsurance healthInsurance);
        Task<IEnumerable<HealthInsurance>> GetAllAsync(string? name);
        Task DeleteAsync(int id);
    }
}