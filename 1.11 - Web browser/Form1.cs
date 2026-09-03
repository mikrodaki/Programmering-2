using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _1._11___Web_browser
{
	public partial class Form1 : Form
	{
		// Stores all visited URLs
		List<string> visitedSites = new List<string>();

		// Keeps track of which site in the history is currently displayed.
		// -1 means that no site has been visited yet.
		int currentIndex = -1;

		public Form1()
		{
			InitializeComponent();

			// Set the initial state of the Back and Forward buttons
			UpdateButtons();

			// Go is disabled until the user enters a URL
			btnGo.Enabled = false;
		}

		private void btnGo_Click(object sender, EventArgs e)
		{
			// Get the URL entered by the user
			var url = tbURL.Text;

			// Do nothing if the URL field is empty
			if (string.IsNullOrEmpty(url))
				return;

			// If the user has gone back in the history and then visits a new site,
			// remove all sites that were ahead of the current position.
			if (currentIndex < visitedSites.Count - 1)
			{
				visitedSites.RemoveRange(
					currentIndex + 1,
					visitedSites.Count - (currentIndex + 1)
				);
			}

			// Navigate to the entered URL
			browserWindow.Navigate(url);

			// Add the new URL to the history
			visitedSites.Add(url);

			// Move the current position to the newly added site
			currentIndex++;

			UpdateButtons();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			// Move one position back in the history
			if (currentIndex != 0)
				currentIndex = currentIndex - 1;

			// Get the URL at the new position
			var url = visitedSites[currentIndex];

			// Display the URL and navigate to the site
			tbURL.Text = url;
			browserWindow.Navigate(url);

			UpdateButtons();
		}

		private void btnFwd_Click(object sender, EventArgs e)
		{
			// Move one position forward in the history
			if (currentIndex != visitedSites.Count - 1)
				currentIndex = currentIndex + 1;

			// Get the URL at the new position
			var url = visitedSites[currentIndex];

			// Display the URL and navigate to the site
			tbURL.Text = url;
			browserWindow.Navigate(url);

			UpdateButtons();
		}

		private void UpdateButtons()
		{
			// Start by enabling both buttons
			btnBack.Enabled = true;
			btnFwd.Enabled = true;

			// If the history is empty, neither Back nor Forward can be used
			if (visitedSites.Count == 0)
			{
				btnBack.Enabled = false;
				btnFwd.Enabled = false;
				return;
			}

			// If we are at the last site in the history,
			// there is nowhere to go forward
			if (currentIndex == visitedSites.Count - 1)
			{
				btnFwd.Enabled = false;
			}

			// If we are at the first site in the history,
			// there is nowhere to go back
			if (visitedSites.Count == 1 || currentIndex == 0)
			{
				btnBack.Enabled = false;
			}
		}

		private void clearToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Clear the entire browsing history
			visitedSites.Clear();

			// Reset the history position
			currentIndex = -1;

			// Display a blank page and clear the URL field
			browserWindow.Navigate("about:blank");
			tbURL.Text = "";

			UpdateButtons();
		}

		private void tbURL_TextChanged(object sender, EventArgs e)
		{
			// Enable Go only when the URL field contains text
			btnGo.Enabled = !string.IsNullOrEmpty(tbURL.Text);
		}
	}
}
