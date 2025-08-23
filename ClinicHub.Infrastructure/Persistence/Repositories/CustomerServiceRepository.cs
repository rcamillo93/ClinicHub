using ClinicHub.Core.Entity;
using ClinicHub.Core.Repositores;
using Microsoft.EntityFrameworkCore;

namespace ClinicHub.Infrastructure.Persistence.Repositories
{
    public class CustomerServiceRepository : ICustomerServiceRepository
    {
        private readonly ClinicHubDbContext _context;

        public CustomerServiceRepository(ClinicHubDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(CustomerService customerService)
        {
            await _context.CustomerServices.AddAsync(customerService);
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CustomerService>> GetAllAsync()
        {
            return await _context.CustomerServices
                            .ToListAsync();
        }

        public async Task<CustomerService?> GetCustomerServiceByIdAsync(int id)
        {
            return await _context.CustomerServices
                            .Include(x => x.Doctor)
                            .Include(x => x.Patient)
                            .Include(x => x.Service)
                            .Include(x => x.ConsultationType)
                            .SingleOrDefaultAsync(x => x.Id == id);
        }
    }
}