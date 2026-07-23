namespace Movies
{
	public partial class Form1 : Form
	{
		private List<Movie> movies = new List<Movie>();
		public Form1()
		{
			InitializeComponent();
			LoadSampleData();
			foreach(Movie movie in movies) 
			{ 
				listBoxMovies.Items.Add($"{movie.Title} {movie.GetType().Name}");
			}
		}

		private void LoadSampleData()
		{
			// Action
			movies.Add(new ActionMovie("Die Hard", "John McTiernan", 1988));
			movies.Add(new ActionMovie("Mad Max: Fury Road", "George Miller", 2015));
			movies.Add(new ActionMovie("Gladiator", "Ridley Scott", 2000));
			movies.Add(new ActionMovie("John Wick", "Chad Stahelski", 2014));
			movies.Add(new ActionMovie("Top Gun", "Tony Scott", 1986));

			// Comedy
			movies.Add(new ComedyMovie("Home Alone", "Chris Columbus", 1990));
			movies.Add(new ComedyMovie("Groundhog Day", "Harold Ramis", 1993));
			movies.Add(new ComedyMovie("The Mask", "Chuck Russell", 1994));
			movies.Add(new ComedyMovie("Hot Fuzz", "Edgar Wright", 2007));
			movies.Add(new ComedyMovie("Ghostbusters", "Ivan Reitman", 1984));

			// Sci-Fi
			movies.Add(new SciFiMovie("Star Wars", "George Lucas", 1977));
			movies.Add(new SciFiMovie("The Matrix", "The Wachowskis", 1999));
			movies.Add(new SciFiMovie("Interstellar", "Christopher Nolan", 2014));
			movies.Add(new SciFiMovie("Blade Runner", "Ridley Scott", 1982));
			movies.Add(new SciFiMovie("Avatar", "James Cameron", 2009));
		}
	}
}
