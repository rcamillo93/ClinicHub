using ClinicHub.Core.Entity;
using ClinicHub.Core.Repositores;
using Microsoft.EntityFrameworkCore;

namespace ClinicHub.Infrastructure.Persistence.Repositories
{
    public class PricingRepository : IPricingRepository
    {
        private readonly ClinicHubDbContext _context;

        public PricingRepository(ClinicHubDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Pricing pricing)
        {
            await _context.Pricings.AddAsync(pricing);
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Pricing>> GetAllAsync()
        {
            return await _context.Pricings.AsNoTracking().ToListAsync();
        }

        public async Task<Pricing?> GetSpecialtyByIdAsync(int id)
        {
            return await _context.Pricings.AsNoTracking()
                        .Where(p => p.Id == id)
                        .SingleOrDefaultAsync();
        }
    }
}
