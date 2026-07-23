namespace Movies
{
	public abstract class Movie
	{
		private string title;
		private string director;
		private int year;
		public string Title { get { return title; } }
		public string Director { get { return director; } }
		public int Year { get { return year; } }

		public Movie(string title, string director, int year)
		{
			this.title = title;
			this.director = director;
			this.year = year;
		}
	}
}
