using System.ComponentModel.DataAnnotations;

namespace BowlingApp.Entity
{
	public class User
	{
		[Key]
		public int Id { get; set; }
		[MaxLength(15)]
		public int? Name { get; set; }

		// Navigation properties
		public ICollection<Game> Games { get; set; } = new List<Game>();
    }
}