using Microsoft.AspNetCore.Diagnostics;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BowlingApp.Entity
{
	public class ScoreBoard
	{
		public int Id { get; set; }
		public int GameId { get; set; }

		[MaxLength(30)]
		public string? PlayerName { get; set; }
		public int PlayerPosition { get; set; }
		public List<uint> Scores { get; set; } = new List<uint>(new uint[21]); // pre-sized to 21 zeros
	}
}

