namespace _1_6___Notepad
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
			menuStrip1 = new MenuStrip();
			arkivToolStripMenuItem = new ToolStripMenuItem();
			newToolStripMenuItem = new ToolStripMenuItem();
			openToolStripMenuItem = new ToolStripMenuItem();
			saveToolStripMenuItem = new ToolStripMenuItem();
			toolStripSeparator1 = new ToolStripSeparator();
			exitToolStripMenuItem = new ToolStripMenuItem();
			formatToolStripMenuItem = new ToolStripMenuItem();
			fontToolStripMenuItem = new ToolStripMenuItem();
			arialToolStripMenuItem = new ToolStripMenuItem();
			consolasToolStripMenuItem = new ToolStripMenuItem();
			timesNewRomanToolStripMenuItem = new ToolStripMenuItem();
			toolStripSeparator2 = new ToolStripSeparator();
			boldToolStripMenuItem = new ToolStripMenuItem();
			italicToolStripMenuItem = new ToolStripMenuItem();
			textBox1 = new TextBox();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { arkivToolStripMenuItem, formatToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(484, 24);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// arkivToolStripMenuItem
			// 
			arkivToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
			arkivToolStripMenuItem.Name = "arkivToolStripMenuItem";
			arkivToolStripMenuItem.Size = new Size(46, 20);
			arkivToolStripMenuItem.Text = "Arkiv";
			// 
			// newToolStripMenuItem
			// 
			newToolStripMenuItem.Name = "newToolStripMenuItem";
			newToolStripMenuItem.Size = new Size(113, 22);
			newToolStripMenuItem.Text = "Ny";
			newToolStripMenuItem.Click += nyToolStripMenuItem_Click;
			// 
			// openToolStripMenuItem
			// 
			openToolStripMenuItem.Name = "openToolStripMenuItem";
			openToolStripMenuItem.Size = new Size(113, 22);
			openToolStripMenuItem.Text = "Öppna";
			openToolStripMenuItem.Click += openToolStripMenuItem_Click;
			// 
			// saveToolStripMenuItem
			// 
			saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			saveToolStripMenuItem.Size = new Size(113, 22);
			saveToolStripMenuItem.Text = "Spara";
			saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new Size(110, 6);
			// 
			// exitToolStripMenuItem
			// 
			exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			exitToolStripMenuItem.Size = new Size(113, 22);
			exitToolStripMenuItem.Text = "Avsluta";
			exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
			// 
			// formatToolStripMenuItem
			// 
			formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontToolStripMenuItem, toolStripSeparator2, boldToolStripMenuItem, italicToolStripMenuItem });
			formatToolStripMenuItem.Name = "formatToolStripMenuItem";
			formatToolStripMenuItem.Size = new Size(57, 20);
			formatToolStripMenuItem.Text = "Format";
			// 
			// fontToolStripMenuItem
			// 
			fontToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { arialToolStripMenuItem, consolasToolStripMenuItem, timesNewRomanToolStripMenuItem });
			fontToolStripMenuItem.Name = "fontToolStripMenuItem";
			fontToolStripMenuItem.Size = new Size(180, 22);
			fontToolStripMenuItem.Text = "Typsnitt";
			// 
			// arialToolStripMenuItem
			// 
			arialToolStripMenuItem.Name = "arialToolStripMenuItem";
			arialToolStripMenuItem.Size = new Size(174, 22);
			arialToolStripMenuItem.Text = "Arial";
			arialToolStripMenuItem.Click += arialToolStripMenuItem_Click;
			// 
			// consolasToolStripMenuItem
			// 
			consolasToolStripMenuItem.Name = "consolasToolStripMenuItem";
			consolasToolStripMenuItem.Size = new Size(174, 22);
			consolasToolStripMenuItem.Text = "Consolas";
			consolasToolStripMenuItem.Click += consolasToolStripMenuItem_Click;
			// 
			// timesNewRomanToolStripMenuItem
			// 
			timesNewRomanToolStripMenuItem.Name = "timesNewRomanToolStripMenuItem";
			timesNewRomanToolStripMenuItem.Size = new Size(174, 22);
			timesNewRomanToolStripMenuItem.Text = "Times New Roman";
			timesNewRomanToolStripMenuItem.Click += timesNewRomanToolStripMenuItem_Click;
			// 
			// toolStripSeparator2
			// 
			toolStripSeparator2.Name = "toolStripSeparator2";
			toolStripSeparator2.Size = new Size(177, 6);
			// 
			// boldToolStripMenuItem
			// 
			boldToolStripMenuItem.Name = "boldToolStripMenuItem";
			boldToolStripMenuItem.Size = new Size(180, 22);
			boldToolStripMenuItem.Text = "Fetstil";
			boldToolStripMenuItem.Click += boldToolStripMenuItem_Click;
			// 
			// italicToolStripMenuItem
			// 
			italicToolStripMenuItem.Name = "italicToolStripMenuItem";
			italicToolStripMenuItem.Size = new Size(180, 22);
			italicToolStripMenuItem.Text = "Kursiv";
			italicToolStripMenuItem.Click += italicToolStripMenuItem_Click;
			// 
			// textBox1
			// 
			textBox1.Dock = DockStyle.Fill;
			textBox1.Location = new Point(0, 24);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.ScrollBars = ScrollBars.Vertical;
			textBox1.Size = new Size(484, 737);
			textBox1.TabIndex = 1;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(484, 761);
			Controls.Add(textBox1);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Enkel textredigerare";
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem arkivToolStripMenuItem;
		private ToolStripMenuItem newToolStripMenuItem;
		private ToolStripMenuItem openToolStripMenuItem;
		private ToolStripMenuItem saveToolStripMenuItem;
		private ToolStripMenuItem exitToolStripMenuItem;
		private TextBox textBox1;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripMenuItem formatToolStripMenuItem;
		private ToolStripMenuItem fontToolStripMenuItem;
		private ToolStripMenuItem arialToolStripMenuItem;
		private ToolStripMenuItem consolasToolStripMenuItem;
		private ToolStripMenuItem timesNewRomanToolStripMenuItem;
		private ToolStripMenuItem boldToolStripMenuItem;
		private ToolStripMenuItem italicToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator2;
	}
}
