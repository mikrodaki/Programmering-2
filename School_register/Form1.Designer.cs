
namespace School_register
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
			textBoxNewYear = new TextBox();
			label1 = new Label();
			btnCreateNewYear = new Button();
			listBoxYears = new ListBox();
			label2 = new Label();
			SuspendLayout();
			// 
			// textBoxNewYear
			// 
			textBoxNewYear.Location = new Point(21, 40);
			textBoxNewYear.Name = "textBoxNewYear";
			textBoxNewYear.Size = new Size(100, 23);
			textBoxNewYear.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(21, 22);
			label1.Name = "label1";
			label1.Size = new Size(62, 15);
			label1.TabIndex = 1;
			label1.Text = "Ny årskurs";
			// 
			// btnCreateNewYear
			// 
			btnCreateNewYear.Location = new Point(127, 40);
			btnCreateNewYear.Name = "btnCreateNewYear";
			btnCreateNewYear.Size = new Size(48, 23);
			btnCreateNewYear.TabIndex = 2;
			btnCreateNewYear.Text = "Skapa";
			btnCreateNewYear.UseVisualStyleBackColor = true;
			btnCreateNewYear.Click += btnCreateNewYear_Click;
			// 
			// listBoxYears
			// 
			listBoxYears.FormattingEnabled = true;
			listBoxYears.ItemHeight = 15;
			listBoxYears.Location = new Point(21, 95);
			listBoxYears.Name = "listBoxYears";
			listBoxYears.Size = new Size(100, 94);
			listBoxYears.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(21, 77);
			label2.Name = "label2";
			label2.Size = new Size(56, 15);
			label2.TabIndex = 4;
			label2.Text = "Årskurser";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(432, 637);
			Controls.Add(label2);
			Controls.Add(listBoxYears);
			Controls.Add(btnCreateNewYear);
			Controls.Add(label1);
			Controls.Add(textBoxNewYear);
			Name = "Form1";
			Text = "Skolregister";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBoxNewYear;
		private Label label1;
		private Button btnCreateNewYear;
		private ListBox listBoxYears;
		private Label label2;
	}
}
