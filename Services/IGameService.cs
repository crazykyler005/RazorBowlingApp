using BowlingApp.Entity;

namespace BowlingApp.Services
{
	public interface IGameService
	{
		Task<List<Game>> GetAllGames();

	}
}