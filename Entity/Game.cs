using System.ComponentModel.DataAnnotations;

namespace BowlingApp.Entity
{
	public class Game
	{
		[Key]
		public int Id { get; set; }
		public DateTime DateCreated { get; set; } = DateTime.UtcNow;

		// Foreign key
		public int? UserId { get; set; }
		// Navigation properties
		public ICollection<ScoreBoard> Games { get; set; } = new List<ScoreBoard>();
		public User? User { get; set; }
	}
}