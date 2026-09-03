namespace _1_6___Notepad
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void nyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Tömmer textfältet
			textBox1.Clear();
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Skapar en dialogruta för att välja en fil
			OpenFileDialog dialog = new OpenFileDialog();

			// Visar endast textfiler (.txt) i dialogrutan
			dialog.Filter = "Text files (*.txt)|*.txt";

			// Fortsätter endast om användaren har valt en fil och klickat på Open
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				// Läser innehållet i den valda filen och visar det i textfältet
				textBox1.Text = File.ReadAllText(dialog.FileName);
			}
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Skapar en dialogruta för att välja var filen ska sparas
			SaveFileDialog dialog = new SaveFileDialog();

			// Filen ska sparas som en textfil (.txt)
			dialog.Filter = "Text files (*.txt)|*.txt";

			// Fortsätter endast om användaren klickar på Save
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				// Sparar innehållet i textfältet i den valda filen
				File.WriteAllText(dialog.FileName, textBox1.Text);
			}
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Stänger programfönstret
			Close();
		}

		private void boldToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox1.Font = new Font(
				textBox1.Font,
				textBox1.Font.Style ^ FontStyle.Bold
			);
		}

		private void arialToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox1.Font = new Font("Arial", textBox1.Font.Size);
		}

		private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox1.Font = new Font("Times New Roman", textBox1.Font.Size);
		}

		private void consolasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox1.Font = new Font("Consolas", textBox1.Font.Size);
		}

		private void italicToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox1.Font = new Font(
				textBox1.Font,
				textBox1.Font.Style ^ FontStyle.Italic
			);
		}
	}
}
