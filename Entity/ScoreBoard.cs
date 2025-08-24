using System.ComponentModel.DataAnnotations;

namespace BowlingApp.Entity
{
	public class ScoreBoard
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(120)]
		public string PlayerNames { get; set; } = string.Empty; // up to 8 names seperated by a ;
		public List<uint> Scores { get; set; } = new List<uint>(new uint[21]); // pre-sized and all default to zero

		// Foreign key
		[Required]
		public int GameId { get; set; }
		// Navigation properties
		public Game Game { get; set; } = new Game();
	}
}

