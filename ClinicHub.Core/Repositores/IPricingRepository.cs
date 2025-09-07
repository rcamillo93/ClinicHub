using ClinicHub.Core.Entity;

namespace ClinicHub.Core.Repositores
{
    public interface IPricingRepository
    {
        Task<Pricing?> GetSpecialtyByIdAsync(int id);
        Task AddAsync(Pricing pricing);
        Task<IEnumerable<Pricing>> GetAllAsync();
        Task DeleteAsync(int id);
    }
}