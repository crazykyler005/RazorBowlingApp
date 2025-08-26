using BowlingApp.Data;
using BowlingApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace BowlingApp.Services
{
	public class GameService : IGameService
	{
		private readonly DataContext _context;

		public GameService(DataContext context)
		{
			_context = context;
		}

		public async Task<int> CreateGame(int UserId, List<string> PlayerNames)
		{
			Game game = new Game();
			game.UserId = UserId;
			game.PlayerNames = string.Join(";", PlayerNames);
			game.ScoreBoards = new List<ScoreBoard>(PlayerNames.Count);
			game.ScoreBoards = PlayerNames.Select(x => new ScoreBoard()).ToList();

			_context.Games.Add(game);
			await _context.SaveChangesAsync();

			return game.Id;
		}

		public async Task<List<Game>> GetAllGamesFromUserId(int UserId)
		{
			Console.WriteLine("test");
			var games = await _context.Games
				.Where(u => u.UserId == UserId)
				.ToListAsync();
			
			return games;
		}

		public async Task<List<Game>> GetAllGames()
		{
			var games = await _context.Games.ToListAsync();
			return games;
		}

		public async Task<Game> GetGame(int GameId)
		{
			var game = await _context.Games
				.Include(g => g.ScoreBoards)
				.FirstAsync(u => u.Id == GameId);

			return game;
		}
	}
}