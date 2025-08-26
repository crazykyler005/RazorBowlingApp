using System.Runtime.CompilerServices;
using BowlingApp.Entity;

namespace BowlingApp.Services
{
	public interface IScoreBoardService
	{
		Task<ScoreBoard> GetScoreBoard(int Id);
		Task<List<ScoreBoard>> GetScoreBoardsFromGame(int GameId);
		Task UpdateScoreBoards(List<ScoreBoard> scoreBoards);
    }
}