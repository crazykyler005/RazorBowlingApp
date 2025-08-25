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

		public async Task<Game> AddGame(Game game)
		{
			_context.Games.Add(game);
			await _context.SaveChangesAsync();

			return game;
		}

		public async Task<List<Game>> GetAllGames()
		{
			var games = await _context.Games.ToListAsync();
			return games;
		}
	}
}