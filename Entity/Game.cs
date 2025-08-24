using System.ComponentModel.DataAnnotations;

namespace BowlingApp.Entity
{
	public class Game
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public DateTime DateCreated { get; set; } = DateTime.UtcNow;

		// Foreign key
		[Required]
		public int UserId { get; set; } = 0;
		// Navigation properties
		public ICollection<ScoreBoard> Games { get; set; } = new List<ScoreBoard>();
		public User User { get; set; } = new User();
	}
}