using ClinicHub.Core.Entity;

namespace ClinicHub.Core.Repositores
{
    public interface IConsultationTypeRepository
    {
        Task<ConsultationType?> GetConsultationTypeByIdAsync(int id);
        Task AddAsync(ConsultationType consultationType);     
        Task<IEnumerable<ConsultationType>> GetAllAsync();
        Task DeleteAsync(int id);

    }
}