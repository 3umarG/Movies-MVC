using MoviesWebApp.Models;
using System.ComponentModel.DataAnnotations;

namespace MoviesWebApp.ViewModels
{
	public class MovieFormViewModel
	{
        public int Id { get; set; }

        [Required, StringLength(250)]
		public string Title { get; set; }

		[Range(1900 , 9999)]
		public int Year { get; set; }
		[Range(1, 10)]
		public float Rate { get; set; }

		[Display(Name = "Story Line"), StringLength(2500)]
		public string StoryLine { get; set; }

		[Display(Name = "Choose poster ...")]
		public byte[] Poster { get; set; }

		[Display(Name = "Genre")]
		public byte GenreID { get; set; }
		public IEnumerable<Genre> Genres { get; set; }

	}
}
