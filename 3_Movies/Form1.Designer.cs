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
			listBoxMovies.Location = new Point(16, 37);
			listBoxMovies.Name = "listBoxMovies";
			listBoxMovies.Size = new Size(441, 129);
			listBoxMovies.TabIndex = 1;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(listBoxMovies);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Filmer";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private ListBox listBoxMovies;
	}
}
