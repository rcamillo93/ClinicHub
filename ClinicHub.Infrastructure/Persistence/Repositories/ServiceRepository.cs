using ClinicHub.Core.Entity;
using ClinicHub.Core.Repositores;
using Microsoft.EntityFrameworkCore;

namespace ClinicHub.Infrastructure.Persistence.Repositories
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly ClinicHubDbContext _context;

        public ServiceRepository(ClinicHubDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Service service)
        {
            await _context.Services.AddAsync(service);
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Service>> GetAllAsync()
        {
            return await _context.Services
                        .Include(s => s.CustomerServices)
                        .ToListAsync();
        }

        public async Task<Service?> GetServiceByIdAsync(int id)
        {
            return await _context.Services
                        .Where(s => s.Id == id)
                        .SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<Service>> GetServicesByDoctorIdAsync(int doctorId)
        {
            return await _context.Services
                        .Where(s => s.CustomerServices.Any(cs => cs.DoctorId == doctorId))
                        .ToListAsync();
        }
    }
}