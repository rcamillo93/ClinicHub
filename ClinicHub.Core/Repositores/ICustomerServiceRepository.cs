using ClinicHub.Core.Entity;

namespace ClinicHub.Core.Repositores
{
    public interface ICustomerServiceRepository
    {
        Task<CustomerService?> GetCustomerServiceByIdAsync(int id);
        Task AddAsync(CustomerService customerService);
        Task<IEnumerable<CustomerService>> GetAllAsync();
        Task DeleteAsync(int id);
    }
}