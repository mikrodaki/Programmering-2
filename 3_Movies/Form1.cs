using System.Diagnostics.Eventing.Reader;

namespace Movies
{
	public partial class Form1 : Form
	{
		private List<Movie> movies = new List<Movie>();
		private List<string> genres = new List<string>();
		public Form1()
		{
			InitializeComponent();
			LoadSampleData();
			foreach (Movie movie in movies)
			{
				listBoxMovies.Items.Add($"{movie.Title}");
			}
			comboBoxGenreSearch.Items.Add("All genres");
			foreach (string genre in genres)
			{
				comboBoxGenre.Items.Add(genre);
				comboBoxGenreSearch.Items.Add(genre);
			}
			comboBoxGenreSearch.SelectedItem = "All genres";
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

			genres.Add("ActionMovie");
			genres.Add("ComedyMovie");
			genres.Add("SciFiMovie");

		}

		private void buttonAddMovie_Click(object sender, EventArgs e)
		{
			string title = textBoxTitle.Text;
			string year = textBoxYear.Text;
			string director = textBoxDirector.Text;
			string genre = "";
			if (comboBoxGenre.SelectedIndex != -1)
				genre = comboBoxGenre.SelectedItem.ToString();

			if (!string.IsNullOrEmpty(title) &&
				!string.IsNullOrEmpty(director) &&
				!string.IsNullOrEmpty(genre) &&
				ValidYear(year))
			{
				switch (genre)
				{
					case "ActionMovie":
						movies.Add(new ActionMovie(title, director, Convert.ToInt32(year)));
						break;
					case "ComedyMovie":
						movies.Add(new ComedyMovie(title, director, Convert.ToInt32(year)));
						break;
					case "SciFiMovie":
						movies.Add(new SciFiMovie(title, director, Convert.ToInt32(year)));
						break;
					default:
						break;
				}
				ClearFields();
				UpdateMovieList();
				MessageBox.Show($"Filmen '{title}' lades till.");
			}
			else
			{
				MessageBox.Show("Alla fält är inte rätt ifyllda!");
				return;
			}
		}

		private bool ValidYear(string year)
		{
			if (int.TryParse(year, out int result))
			{
				if (result >= 1888 && result <= 2026)
					return true;
			}
			return false;
		}

		private void ClearFields()
		{
			textBoxTitle.Clear();
			textBoxYear.Clear();
			textBoxDirector.Clear();
			comboBoxGenre.SelectedIndex = -1;
		}

		private void UpdateMovieList()
		{
			listBoxMovies.Items.Clear();
			foreach (Movie movie in movies)
			{
				listBoxMovies.Items.Add($"{movie.Title}");
			}
		}

		private void Form1_Click(object sender, EventArgs e)
		{
			ClearAll();
		}

		private void ClearAll()
		{
			listBoxMovies.ClearSelected();
			comboBoxGenre.SelectedIndex = -1;
		}

		private void comboBoxGenreSearch_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBoxGenreSearch.SelectedIndex == -1)
				return;
			string genre = comboBoxGenreSearch.SelectedItem.ToString();
			listBoxMovies.Items.Clear();
			if (genre == "All genres") 
			{
				UpdateMovieList();
				return;
			}
			foreach (Movie movie in movies) 
			{ 
				if (movie.GetType().Name == genre)
					listBoxMovies.Items.Add(movie.Title);
			}
			
		}
	}
}
