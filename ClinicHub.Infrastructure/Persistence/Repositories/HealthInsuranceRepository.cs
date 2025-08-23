using ClinicHub.Core.Entity;
using ClinicHub.Core.Repositores;
using Microsoft.EntityFrameworkCore;

namespace ClinicHub.Infrastructure.Persistence.Repositories
{
    public class HealthInsuranceRepository : IHealthInsuranceRepository
    {
        private readonly ClinicHubDbContext _context;

        public HealthInsuranceRepository(ClinicHubDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(HealthInsurance healthInsurance)
        {
            await _context.HealthInsurances.AddAsync(healthInsurance);
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<HealthInsurance>> GetAllAsync()
        {
            return await _context.HealthInsurances
                            .AsNoTracking()
                            .ToListAsync();
        }

        public async Task<HealthInsurance?> GetHealthInsuranceByIdAsync(int id)
        {
            return await _context.HealthInsurances
                .AsNoTracking()
                .FirstOrDefaultAsync(h => h.Id == id);
        }
    }
}