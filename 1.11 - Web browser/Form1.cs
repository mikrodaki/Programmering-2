using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _1._11___Web_browser
{
	public partial class Form1 : Form
	{
		List<string> visitedSites = new List<string>();
		int currentIndex = -1;
		public Form1()
		{
			InitializeComponent();
			UpdateButtons();
			btnGo.Enabled = false;
		}

		private void btnGo_Click(object sender, EventArgs e)
		{
			var url = tbURL.Text;

			if (string.IsNullOrEmpty(url))
				return;

			if (currentIndex < visitedSites.Count - 1)
			{
				visitedSites.RemoveRange(currentIndex + 1, visitedSites.Count - (currentIndex + 1));
			}

			browserWindow.Navigate(url);
			visitedSites.Add(url);
			currentIndex++;
			UpdateButtons();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			if (currentIndex != 0)
				currentIndex = currentIndex - 1;
			var url = visitedSites[currentIndex];
			tbURL.Text = url;
			browserWindow.Navigate(url);
			UpdateButtons();
		}

		private void btnFwd_Click(object sender, EventArgs e)
		{
			if (currentIndex != visitedSites.Count - 1)
				currentIndex = currentIndex + 1;
			var url = visitedSites[currentIndex];
			tbURL.Text = url;
			browserWindow.Navigate(url);
			UpdateButtons();
		}

		private void UpdateButtons()
		{
			btnBack.Enabled = true;
			btnFwd.Enabled = true;

			// There are no sites stored
			if (visitedSites.Count == 0)
			{
				btnBack.Enabled = false;
				btnFwd.Enabled = false;
				return;
			}

			// The current site is the last in the list
			if (currentIndex == visitedSites.Count - 1)
			{
				btnFwd.Enabled = false;
			}

			// The current site is the first in the list
			if (visitedSites.Count == 1 || currentIndex == 0)
			{
				btnBack.Enabled = false;
			}

		}

		private void clearToolStripMenuItem_Click(object sender, EventArgs e)
		{
			visitedSites.Clear();
			currentIndex = -1;
			browserWindow.Navigate("about:blank");
			tbURL.Text = "";
			UpdateButtons();
		}

		private void tbURL_TextChanged(object sender, EventArgs e)
		{
			btnGo.Enabled = !string.IsNullOrEmpty(tbURL.Text);
		}
	}
}
