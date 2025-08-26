using BowlingApp.Entity;

namespace BowlingApp.Services
{
	public interface IUserService
	{
		Task<User> CreateUser(User user);
		Task<User> GetUser(int UserId);
		Task<List<User>> GetAllUsers();
		Task DeleteAllUserData(int UserId);
    }
}