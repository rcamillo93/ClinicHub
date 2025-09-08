using ClinicHub.Core.Entity;
using ClinicHub.Core.Repositores;
using Microsoft.EntityFrameworkCore;

namespace ClinicHub.Infrastructure.Persistence.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly ClinicHubDbContext _context;

        public DoctorRepository(ClinicHubDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Doctor doctor)
        {
            await _context.Doctors.AddAsync(doctor);
        }

        public async Task<List<Doctor>> GetAllAsync(string? name)
        {
            var query = _context.Doctors
                                .Include(d => d.User)
                                .Include(d => d.Specialty)
                                .AsNoTracking()
                                .AsQueryable();

            if(!string.IsNullOrWhiteSpace(name))
                query = query.Where(d => EF.Functions.Like(d.User.FullName.ToLower(), $"%{name.ToLower()}%"));

            return await query.ToListAsync();
        }

        public async Task<Doctor?> GetDoctorByIdAsync(int id)
        {
            return await _context.Doctors
                            .Include(d => d.User)
                            .Include(d => d.Specialty)
                            .Where(d => d.Id == id)
                            .SingleOrDefaultAsync();
        }        

        public Task UpdateAsync(Doctor doctor)
        {
            throw new NotImplementedException();
        }
    }
}
