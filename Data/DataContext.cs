using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BowlingApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace BowlingApp.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options)
			: base(options)
		{

		}

		public DbSet<Game> Games { get; set; }
		public DbSet<ScoreBoard> ScoreBoard { get; set; }
    }
}