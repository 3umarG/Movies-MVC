using Microsoft.EntityFrameworkCore;
using MoviesWebApp.Config;
using MoviesWebApp.Models;

namespace MoviesWebApp.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{

			modelBuilder.ApplyConfiguration(new MovieConfig());
			modelBuilder.ApplyConfiguration(new GenreConfig());

			base.OnModelCreating(modelBuilder);
		}

		public virtual DbSet<Movie> Movies { get; set; }
		public virtual DbSet<Genre> Genres { get; set; }
	}
}
