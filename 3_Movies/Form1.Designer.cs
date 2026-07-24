namespace Movies
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			listBoxMovies = new ListBox();
			label2 = new Label();
			label3 = new Label();
			textBoxTitle = new TextBox();
			label4 = new Label();
			label5 = new Label();
			comboBoxGenre = new ComboBox();
			label6 = new Label();
			textBoxDirector = new TextBox();
			label7 = new Label();
			textBoxYear = new TextBox();
			buttonAddMovie = new Button();
			label8 = new Label();
			comboBoxGenreSearch = new ComboBox();
			label9 = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(20, 22);
			label1.Name = "label1";
			label1.Size = new Size(0, 25);
			label1.TabIndex = 0;
			// 
			// listBoxMovies
			// 
			listBoxMovies.FormattingEnabled = true;
			listBoxMovies.ItemHeight = 25;
			listBoxMovies.Location = new Point(20, 76);
			listBoxMovies.Name = "listBoxMovies";
			listBoxMovies.Size = new Size(238, 429);
			listBoxMovies.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9F);
			label2.Location = new Point(331, 155);
			label2.Name = "label2";
			label2.Size = new Size(133, 25);
			label2.TabIndex = 2;
			label2.Text = "Lägg till ny film";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 9F);
			label3.Location = new Point(18, 11);
			label3.Name = "label3";
			label3.Size = new Size(0, 25);
			label3.TabIndex = 3;
			// 
			// textBoxTitle
			// 
			textBoxTitle.Location = new Point(335, 222);
			textBoxTitle.Name = "textBoxTitle";
			textBoxTitle.Size = new Size(238, 31);
			textBoxTitle.TabIndex = 4;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(331, 194);
			label4.Name = "label4";
			label4.Size = new Size(44, 25);
			label4.TabIndex = 5;
			label4.Text = "Titel";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(449, 338);
			label5.Name = "label5";
			label5.Size = new Size(58, 25);
			label5.TabIndex = 6;
			label5.Text = "Genre";
			// 
			// comboBoxGenre
			// 
			comboBoxGenre.FormattingEnabled = true;
			comboBoxGenre.Location = new Point(449, 366);
			comboBoxGenre.Name = "comboBoxGenre";
			comboBoxGenre.Size = new Size(182, 33);
			comboBoxGenre.TabIndex = 7;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(331, 264);
			label6.Name = "label6";
			label6.Size = new Size(71, 25);
			label6.TabIndex = 8;
			label6.Text = "Regisör";
			// 
			// textBoxDirector
			// 
			textBoxDirector.Location = new Point(335, 292);
			textBoxDirector.Name = "textBoxDirector";
			textBoxDirector.Size = new Size(238, 31);
			textBoxDirector.TabIndex = 9;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(335, 338);
			label7.Name = "label7";
			label7.Size = new Size(30, 25);
			label7.TabIndex = 11;
			label7.Text = "År";
			// 
			// textBoxYear
			// 
			textBoxYear.Location = new Point(335, 366);
			textBoxYear.Name = "textBoxYear";
			textBoxYear.Size = new Size(90, 31);
			textBoxYear.TabIndex = 10;
			// 
			// buttonAddMovie
			// 
			buttonAddMovie.Font = new Font("Segoe UI", 9F);
			buttonAddMovie.Location = new Point(647, 366);
			buttonAddMovie.Name = "buttonAddMovie";
			buttonAddMovie.Size = new Size(112, 34);
			buttonAddMovie.TabIndex = 12;
			buttonAddMovie.Text = "Lägg till";
			buttonAddMovie.UseVisualStyleBackColor = true;
			buttonAddMovie.Click += buttonAddMovie_Click;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(20, 11);
			label8.Name = "label8";
			label8.Size = new Size(58, 25);
			label8.TabIndex = 13;
			label8.Text = "Genre";
			// 
			// comboBoxGenreSearch
			// 
			comboBoxGenreSearch.FormattingEnabled = true;
			comboBoxGenreSearch.Location = new Point(84, 12);
			comboBoxGenreSearch.Name = "comboBoxGenreSearch";
			comboBoxGenreSearch.Size = new Size(182, 33);
			comboBoxGenreSearch.TabIndex = 15;
			comboBoxGenreSearch.SelectedIndexChanged += comboBoxGenreSearch_SelectedIndexChanged;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(295, 41);
			label9.Name = "label9";
			label9.Size = new Size(0, 25);
			label9.TabIndex = 14;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(778, 605);
			Controls.Add(comboBoxGenreSearch);
			Controls.Add(label9);
			Controls.Add(label8);
			Controls.Add(buttonAddMovie);
			Controls.Add(label7);
			Controls.Add(textBoxYear);
			Controls.Add(textBoxDirector);
			Controls.Add(label6);
			Controls.Add(comboBoxGenre);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(textBoxTitle);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(listBoxMovies);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Filmer";
			Click += Form1_Click;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private ListBox listBoxMovies;
		private Label label2;
		private Label label3;
		private TextBox textBoxTitle;
		private Label label4;
		private Label label5;
		private ComboBox comboBoxGenre;
		private Label label6;
		private TextBox textBoxDirector;
		private Label label7;
		private TextBox textBoxYear;
		private Button buttonAddMovie;
		private Label label8;
		private ComboBox comboBoxGenreSearch;
		private Label label9;
	}
}
