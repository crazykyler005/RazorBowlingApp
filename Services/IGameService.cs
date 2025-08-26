using BowlingApp.Entity;

namespace BowlingApp.Services
{
	public interface IGameService
	{
		Task<int> CreateGame(int UserId, List<string> PlayerNames);
		Task<List<Game>> GetAllGamesFromUserId(int UserId);
		Task<List<Game>> GetAllGames();
		Task<Game> GetGame(int GameId);
	}
}