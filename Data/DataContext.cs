using BowlingApp.Entity;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BowlingApp.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options)
			: base(options)
		{

		}

		public DbSet<User> Users { get; set; }
		public DbSet<Game> Games { get; set; }
		public DbSet<ScoreBoard> ScoreBoards { get; set; }
    }
}