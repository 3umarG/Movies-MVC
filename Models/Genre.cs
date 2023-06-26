using System.ComponentModel.DataAnnotations;

namespace MoviesWebApp.Models
{
	public class Genre
	{
        public byte GenreID { get; set; }

       
        public string Name { get; set; }

		public virtual ICollection<Movie> Movies { get; set; } = new HashSet<Movie>();

	}
}
