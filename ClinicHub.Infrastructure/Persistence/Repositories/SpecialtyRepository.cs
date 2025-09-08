using ClinicHub.Core.Entity;
using ClinicHub.Core.Repositores;
using Microsoft.EntityFrameworkCore;

namespace ClinicHub.Infrastructure.Persistence.Repositories
{
    public class SpecialtyRepository : ISpecialtyRepository
    {
        private readonly ClinicHubDbContext _context;

        public SpecialtyRepository(ClinicHubDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Specialty specialty)
        {
            await _context.Specialties.AddAsync(specialty);
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Specialty>> GetAllAsync(string? name)
        {
            var query = _context.Specialties.AsQueryable().AsNoTracking();

            if (!string.IsNullOrWhiteSpace(name))
                query = query.Where(s => EF.Functions.Like(s.Name.ToLower(), $"%{name.ToLower()}%"));

            return await query.ToListAsync();
        }

        public async Task<Specialty?> GetByIdAsync(int id)
        {
            return await _context.Specialties
                        .Where(s => s.Id == id)
                        .SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<Specialty>> GetSpecialtiesByDoctorIdAsync(int doctorId)
        {
            return await _context.Specialties
                        .Where(s => s.Doctors.Any(d => d.Id == doctorId))
                        .ToListAsync();
        }

        public async Task<Specialty?> GetSpecialtyByIdAsync(int id)
        {
            return await _context.Specialties.Where(s => s.Id == id)
                        .SingleOrDefaultAsync();
        }

        public async Task<Specialty?> GetSpecialtyByNameAsync(string name)
        {
           return await _context.Specialties
                        .Where(s => s.Name.ToLower() == name.ToLower())
                        .SingleOrDefaultAsync();
        }
    }
}