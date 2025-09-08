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

        public async Task<IEnumerable<CustomerService>> GetAllAsync(DateOnly? startDate, DateOnly? endDate, string? PatientName, string? DoctorName)
        {
            var query = _context.CustomerServices
                                .Include(x => x.Doctor)
                                .Include(x => x.Doctor.User)
                                .Include(x => x.Patient)
                                .Include(x => x.Service)
                                .Include(x => x.ConsultationType)
                                .AsNoTracking()
                                .AsQueryable();

            if (startDate.HasValue)
                query = query.Where(cs => DateOnly.Parse(cs.StartAt.ToString()) >= startDate.Value);

            if (startDate.HasValue)
                query = query.Where(cs => DateOnly.Parse(cs.StartAt.ToString()) <= endDate.Value);

            if (!string.IsNullOrWhiteSpace(PatientName))
                query = query.Where(cs => EF.Functions.Like(cs.Patient.FullName.ToLower(), $"%{PatientName.ToLower()}%"));

            if (!string.IsNullOrWhiteSpace(DoctorName))
                query = query.Where(cs => EF.Functions.Like(cs.Doctor.User.FullName.ToLower(), $"%{DoctorName.ToLower()}%"));

            return await query.ToListAsync();
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