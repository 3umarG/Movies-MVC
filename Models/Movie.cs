namespace MoviesWebApp.Models
{
	public class Movie
	{
        public int MovieID { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

        public float Rate { get; set; }

        public string StoryLine { get; set; }

        public byte[] Poster { get; set; }

        public virtual ICollection<Genre> Genres { get; set; } = new HashSet<Genre>();

    }
}
