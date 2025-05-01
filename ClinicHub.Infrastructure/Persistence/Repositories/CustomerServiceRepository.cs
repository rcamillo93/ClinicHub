using ClinicHub.Core.Entity;
using ClinicHub.Core.Repositores;

namespace ClinicHub.Infrastructure.Persistence.Repositories
{
    public class CustomerServiceRepository : ICustomerServiceRepository
    {
        public Task AddAsync(CustomerService customerService)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CustomerService>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CustomerService?> GetCustomerServiceByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(CustomerService customerService)
        {
            throw new NotImplementedException();
        }
    }
}