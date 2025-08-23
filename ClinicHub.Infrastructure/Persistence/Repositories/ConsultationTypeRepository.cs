using ClinicHub.Core.Entity;
using ClinicHub.Core.Repositores;
using Microsoft.EntityFrameworkCore;

namespace ClinicHub.Infrastructure.Persistence.Repositories
{
    public class ConsultationTypeRepository : IConsultationTypeRepository
    {
        private readonly ClinicHubDbContext _context;

        public ConsultationTypeRepository(ClinicHubDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(ConsultationType consultationType)
        {
            await _context.ConsultationTypes.AddAsync(consultationType);
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ConsultationType>> GetAllAsync()
        {
           return await _context.ConsultationTypes
                        .ToListAsync();
        }

        public async Task<ConsultationType?> GetConsultationTypeByIdAsync(int id)
        {
            return await _context.ConsultationTypes
                .SingleOrDefaultAsync(x => x.Id == id);
        }
    }
}