using ClinicHub.Core.Entity;

namespace ClinicHub.Core.Repositores
{
    public interface IHealthInsuranceRepository
    {
        Task<HealthInsurance?> GetHealthInsuranceByIdAsync(int id);
        Task AddAsync(HealthInsurance healthInsurance);
        Task UpdateAsync(HealthInsurance healthInsurance);
        Task<IEnumerable<HealthInsurance>> GetAllAsync();
        Task DeleteAsync(int id);
    }
}