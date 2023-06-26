using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviesWebApp.Models;

namespace MoviesWebApp.Config
{
	public class GenreConfig : IEntityTypeConfiguration<Genre>
	{
		public void Configure(EntityTypeBuilder<Genre> builder)
		{
			builder.HasKey(G => G.GenreID);


			builder
				.HasMany(G => G.Movies)
				.WithMany(M => M.Genres);


			builder
				.Property(G => G.Name)
				.IsRequired()
				.HasMaxLength(150);
		}
	}
}
