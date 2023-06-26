using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviesWebApp.Models;

namespace MoviesWebApp.Config
{
	public class MovieConfig : IEntityTypeConfiguration<Movie>
	{
		public void Configure(EntityTypeBuilder<Movie> builder)
		{
			builder.HasKey(M => M.MovieID);

			builder.Property(M => M.Title).IsRequired().HasMaxLength(150);
			builder.Property(M => M.StoryLine).HasMaxLength(2500);
			builder.Property(M => M.Year).IsRequired().HasMaxLength(9999);
		}
	}
}
