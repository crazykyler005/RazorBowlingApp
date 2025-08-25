using System.ComponentModel.DataAnnotations;

namespace BowlingApp.Entity
{
	public class Game
	{
		[Key]
		public int Id { get; set; }
		public DateTime DateCreated { get; set; } = DateTime.UtcNow;

		[Required]
		[MaxLength(120)]
		public string PlayerNames { get; set; } = string.Empty; // up to 8 names seperated by a ;

		// Foreign key
		[Required]
		public int UserId { get; set; }
		// Navigation properties
		public ICollection<ScoreBoard> ScoreBoards { get; set; } = new List<ScoreBoard>();
		public User User { get; set; } = new User();
	}
}