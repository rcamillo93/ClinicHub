using ClinicHub.Core.Entity;
using ClinicHub.Core.Repositores;
using Microsoft.EntityFrameworkCore;

namespace ClinicHub.Infrastructure.Persistence.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private readonly ClinicHubDbContext _context;
        public PatientRepository(ClinicHubDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Patient patient)
        {
            await _context.Patients.AddAsync(patient);
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Patient>> GetAllAsync(string? name)
        {
            var query = _context.Patients.Include(p => p.Address)
                                .Include(p => p.HealthInsurance)
                                .AsNoTracking()
                                .AsQueryable();

            if(!string.IsNullOrWhiteSpace(name))
                query = query.Where(p => EF.Functions.Like(p.FullName.ToLower(), $"%{p.FullName}%"));

            return await query.ToListAsync();
        }

        public async Task<Patient?> GetPatientByIdAsync(int id)
        {
            return await _context.Patients
                            .Include(p => p.Address)
                            .Include(p => p.HealthInsurance)
                            .SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Patient>> GetPatientsByDoctorIdAsync(int doctorId)
        {
            return await _context.Patients
                            .Include(p => p.Address)
                            .Include(p => p.HealthInsurance)
                            .Where(p => p.CustomerServices.Any(cs => cs.DoctorId == doctorId))
                            .ToListAsync();
        }

        public async Task<IEnumerable<Patient>> GetPatientsByHealthInsuranceIdAsync(int healthInsuranceId)
        {
            return await _context.Patients
                            .Include(p => p.Address)
                            .Include(p => p.HealthInsurance)
                            .Where(p => p.HealthInsuranceId == healthInsuranceId)
                            .ToListAsync();
        }
    }
}