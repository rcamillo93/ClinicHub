using ClinicHub.Core.Entity;

namespace ClinicHub.Core.Repositores
{
    public interface IPricingRepository
    {
        Task<Pricing?> GetByIdAsync(int id);
        Task AddAsync(Pricing pricing);
        Task<IEnumerable<Pricing>> GetAllAsync(int? healthInsuranceId, int? specialtyId, int? consultationTypeId);
        Task DeleteAsync(int id);
    }
}