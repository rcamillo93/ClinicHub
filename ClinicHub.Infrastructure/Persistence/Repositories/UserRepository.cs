using ClinicHub.Core.Entity;
using ClinicHub.Core.Repositores;
using Microsoft.EntityFrameworkCore;

namespace ClinicHub.Infrastructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ClinicHubDbContext _context;

        public UserRepository(ClinicHubDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(User user)
        {
            await _context.Users.AddAsync(user);
        }
       
        public async Task<User?> GetUserByIdAsync(int id)
        {
            return await _context.Users.SingleOrDefaultAsync(u => u.Id == id);
        }

        public async Task UpdateAsync(User order)
        {
            throw new NotImplementedException();
        }       

        public async Task<User?> GetUserById(int id)
        {
            return await _context.Users.SingleOrDefaultAsync(u => u.Id == id);
        }

        public async Task<List<User>> GetAllAsync(string? name)
        {
            var query = _context.Users.AsQueryable().AsNoTracking();

            if (!string.IsNullOrWhiteSpace(name))
                query = query.Where(u => EF.Functions.Like(u.FullName.ToLower(), $"%{name.ToLower()}%"));

            return await query.ToListAsync();
        }
    }
}