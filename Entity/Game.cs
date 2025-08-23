using BowlingApp.Entity;

namespace BowlingApp.Entity
{
	public class Game
	{
		public int Id { get; set; }
		public DateTime DateCreated { get; set; } = DateTime.UtcNow;
		public List<ScoreBoard>? ScoreBoards { get; set; }
	}
}