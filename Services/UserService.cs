using BowlingApp.Data;
using BowlingApp.Entity;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BowlingApp.Services
{
    public class UserService : IUserService
    {
		private readonly DataContext _context;

		public UserService(DataContext context)
		{
			_context = context;
		}

		public async Task<User> CreateUser(User user)
		{
			_context.Users.Add(user);
			await _context.SaveChangesAsync();

			return user;
		}

		public async Task<User> GetUser(int UserId)
		{
			var user = await _context.Users.FirstAsync(u => u.Id == UserId);

			// if (user == null)
			// {
			// 	return null;
			// }

			return user;
		}

		public async Task<List<User>> GetAllUsers()
		{
			var users = await _context.Users.ToListAsync();
			return users;
		}
    }
}