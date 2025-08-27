using System.Runtime.CompilerServices;
using BowlingApp.Data;
using BowlingApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace BowlingApp.Services
{
	public class ScoreBoardService : IScoreBoardService
	{
		private readonly DataContext _context;

		public ScoreBoardService(DataContext context)
		{
			_context = context;
		}

		public async Task<ScoreBoard> GetScoreBoard(int Id)
		{
			var scoreboard = await _context.ScoreBoards.FirstAsync(u => u.Id == Id);
			return scoreboard;
		}

		public async Task<List<ScoreBoard>> GetScoreBoardsFromGame(int GameId)
		{
			var scoreboards = await _context.ScoreBoards.Where(u => u.GameId == GameId).ToListAsync();
			return scoreboards;
		}

		public async Task UpdateScoreBoards(List<ScoreBoard> scoreBoards)
		{
			foreach (var board in scoreBoards)
			{
				_context.ScoreBoards.Update(board);
			}

			await _context.SaveChangesAsync(); // one call to DB
		}
	}
}