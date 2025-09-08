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

        public async Task<IEnumerable<HealthInsurance>> GetAllAsync(string? name)
        {
            var query = _context.HealthInsurances.AsQueryable();

            if (!string.IsNullOrWhiteSpace(name))
                query = query.Where(h => EF.Functions.Like(h.Name.ToLower(), $"%{name.ToLower()}%"));

            return await query.AsNoTracking().ToListAsync();
        }

        public async Task<HealthInsurance?> GetHealthInsuranceByIdAsync(int id)
        {
            return await _context.HealthInsurances
                .AsNoTracking()
                .FirstOrDefaultAsync(h => h.Id == id);
        }
    }
}