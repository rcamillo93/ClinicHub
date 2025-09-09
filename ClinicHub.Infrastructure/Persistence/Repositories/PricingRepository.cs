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

        public async Task<IEnumerable<Pricing>> GetAllAsync(int? healthInsuranceId, int? specialtyId, int? consultationTypeId)
        {
            var query = _context.Pricings
                        .AsQueryable()
                        .Include(p => p.HealthInsurance)
                        .Include(p => p.ConsultationType)
                        .Include(p => p.Specialty)
                        .Include(p => p.Service)
                        .AsNoTracking();

            if (healthInsuranceId.HasValue)
                query = query.Where(p => p.HealthInsuranceId == healthInsuranceId.Value);

            if (specialtyId.HasValue)
                query = query.Where(p => p.SpecialtyId == specialtyId.Value);

            if (consultationTypeId.HasValue)
                query = query.Where(p => p.ConsultationTypeId == consultationTypeId.Value);

            return await query.ToListAsync();
        }

        public async Task<Pricing?> GetByIdAsync(int id)
        {
            return await _context.Pricings.AsNoTracking()
                        .Include(p => p.HealthInsurance)
                        .Include(p => p.ConsultationType)
                        .Include(p => p.Specialty)
                        .Include(p => p.Service)
                        .Where(p => p.Id == id)
                        .SingleOrDefaultAsync();
        }
    }
}