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
			label10 = new Label();
			textBoxFreeTextSearch = new TextBox();
			buttonFreeTextSearch = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(24, 28);
			label1.Margin = new Padding(2, 0, 2, 0);
			label1.Name = "label1";
			label1.Size = new Size(0, 20);
			label1.TabIndex = 0;
			// 
			// listBoxMovies
			// 
			listBoxMovies.FormattingEnabled = true;
			listBoxMovies.Location = new Point(22, 173);
			listBoxMovies.Margin = new Padding(2);
			listBoxMovies.Name = "listBoxMovies";
			listBoxMovies.Size = new Size(409, 344);
			listBoxMovies.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9F);
			label2.Location = new Point(520, 304);
			label2.Margin = new Padding(2, 0, 2, 0);
			label2.Name = "label2";
			label2.Size = new Size(112, 20);
			label2.TabIndex = 2;
			label2.Text = "Lägg till ny film";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 9F);
			label3.Location = new Point(22, 19);
			label3.Margin = new Padding(2, 0, 2, 0);
			label3.Name = "label3";
			label3.Size = new Size(0, 20);
			label3.TabIndex = 3;
			// 
			// textBoxTitle
			// 
			textBoxTitle.Location = new Point(523, 358);
			textBoxTitle.Margin = new Padding(2);
			textBoxTitle.Name = "textBoxTitle";
			textBoxTitle.Size = new Size(191, 27);
			textBoxTitle.TabIndex = 4;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(520, 335);
			label4.Margin = new Padding(2, 0, 2, 0);
			label4.Name = "label4";
			label4.Size = new Size(38, 20);
			label4.TabIndex = 5;
			label4.Text = "Titel";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(614, 450);
			label5.Margin = new Padding(2, 0, 2, 0);
			label5.Name = "label5";
			label5.Size = new Size(48, 20);
			label5.TabIndex = 6;
			label5.Text = "Genre";
			// 
			// comboBoxGenre
			// 
			comboBoxGenre.FormattingEnabled = true;
			comboBoxGenre.Location = new Point(614, 473);
			comboBoxGenre.Margin = new Padding(2);
			comboBoxGenre.Name = "comboBoxGenre";
			comboBoxGenre.Size = new Size(146, 28);
			comboBoxGenre.TabIndex = 7;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(520, 391);
			label6.Margin = new Padding(2, 0, 2, 0);
			label6.Name = "label6";
			label6.Size = new Size(59, 20);
			label6.TabIndex = 8;
			label6.Text = "Regisör";
			// 
			// textBoxDirector
			// 
			textBoxDirector.Location = new Point(523, 414);
			textBoxDirector.Margin = new Padding(2);
			textBoxDirector.Name = "textBoxDirector";
			textBoxDirector.Size = new Size(191, 27);
			textBoxDirector.TabIndex = 9;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(523, 450);
			label7.Margin = new Padding(2, 0, 2, 0);
			label7.Name = "label7";
			label7.Size = new Size(24, 20);
			label7.TabIndex = 11;
			label7.Text = "År";
			// 
			// textBoxYear
			// 
			textBoxYear.Location = new Point(523, 473);
			textBoxYear.Margin = new Padding(2);
			textBoxYear.Name = "textBoxYear";
			textBoxYear.Size = new Size(73, 27);
			textBoxYear.TabIndex = 10;
			// 
			// buttonAddMovie
			// 
			buttonAddMovie.Font = new Font("Segoe UI", 9F);
			buttonAddMovie.Location = new Point(773, 473);
			buttonAddMovie.Margin = new Padding(2);
			buttonAddMovie.Name = "buttonAddMovie";
			buttonAddMovie.Size = new Size(90, 27);
			buttonAddMovie.TabIndex = 12;
			buttonAddMovie.Text = "Lägg till";
			buttonAddMovie.UseVisualStyleBackColor = true;
			buttonAddMovie.Click += buttonAddMovie_Click;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(24, 19);
			label8.Margin = new Padding(2, 0, 2, 0);
			label8.Name = "label8";
			label8.Size = new Size(48, 20);
			label8.TabIndex = 13;
			label8.Text = "Genre";
			// 
			// comboBoxGenreSearch
			// 
			comboBoxGenreSearch.FormattingEnabled = true;
			comboBoxGenreSearch.Location = new Point(86, 20);
			comboBoxGenreSearch.Margin = new Padding(2);
			comboBoxGenreSearch.Name = "comboBoxGenreSearch";
			comboBoxGenreSearch.Size = new Size(158, 28);
			comboBoxGenreSearch.TabIndex = 15;
			comboBoxGenreSearch.SelectedIndexChanged += comboBoxGenreSearch_SelectedIndexChanged;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(244, 43);
			label9.Margin = new Padding(2, 0, 2, 0);
			label9.Name = "label9";
			label9.Size = new Size(0, 20);
			label9.TabIndex = 14;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(22, 101);
			label10.Name = "label10";
			label10.Size = new Size(50, 20);
			label10.TabIndex = 16;
			label10.Text = "Fritext";
			// 
			// textBoxFreeTextSearch
			// 
			textBoxFreeTextSearch.Location = new Point(78, 101);
			textBoxFreeTextSearch.Name = "textBoxFreeTextSearch";
			textBoxFreeTextSearch.Size = new Size(158, 27);
			textBoxFreeTextSearch.TabIndex = 17;
			// 
			// buttonFreeTextSearch
			// 
			buttonFreeTextSearch.Location = new Point(252, 101);
			buttonFreeTextSearch.Name = "buttonFreeTextSearch";
			buttonFreeTextSearch.Size = new Size(56, 29);
			buttonFreeTextSearch.TabIndex = 18;
			buttonFreeTextSearch.Text = "Sök";
			buttonFreeTextSearch.UseVisualStyleBackColor = true;
			buttonFreeTextSearch.Click += buttonFreeTextSearch_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(926, 574);
			Controls.Add(buttonFreeTextSearch);
			Controls.Add(textBoxFreeTextSearch);
			Controls.Add(label10);
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
			Margin = new Padding(2);
			Name = "Form1";
			Text = "Filmer";
			//Load += Form1_Load;
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
		private Label label10;
		private TextBox textBoxFreeTextSearch;
		private Button buttonFreeTextSearch;
	}
}
