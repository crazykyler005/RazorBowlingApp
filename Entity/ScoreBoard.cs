using System.ComponentModel.DataAnnotations;

namespace BowlingApp.Entity
{
	public class ScoreBoard
	{
		[Key]
		public int Id { get; set; }
		public uint[] Scores { get; set; } = new uint[21]; // pre-sized and all default to zero

		// Foreign key
		[Required]
		public int GameId { get; set; }
		// Navigation properties
		public Game Game { get; set; } = null!;
	}
}

