using PayMon.Models;
using PayMon.Data; // Updated to match the new namespace
using Microsoft.EntityFrameworkCore;

namespace PayMon.Repositories
{
    public class UserRepository
    {
        private readonly PayMonDbContext _context;

        public UserRepository(PayMonDbContext context)
        {
            _context = context;
        }

        public async Task<User?> GetUserByUsername(string username)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
        }

        public async Task AddUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }
    }
}
