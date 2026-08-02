namespace Minesweeper
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
			buttonStart = new Button();
			labelWinOrLoose = new Label();
			SuspendLayout();
			// 
			// buttonStart
			// 
			buttonStart.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonStart.Location = new Point(392, 12);
			buttonStart.Name = "buttonStart";
			buttonStart.Size = new Size(94, 29);
			buttonStart.TabIndex = 0;
			buttonStart.Text = "START";
			buttonStart.UseVisualStyleBackColor = true;
			buttonStart.Click += buttonStart_Click;
			// 
			// labelLost
			// 
			labelWinOrLoose.AutoSize = true;
			labelWinOrLoose.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			labelWinOrLoose.ForeColor = Color.Red;
			labelWinOrLoose.Location = new Point(135, 17);
			labelWinOrLoose.Name = "labelLost";
			labelWinOrLoose.Size = new Size(0, 33);
			labelWinOrLoose.TabIndex = 1;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(618, 221);
			Controls.Add(labelWinOrLoose);
			Controls.Add(buttonStart);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button buttonStart;
		private Label labelWinOrLoose;
	}
}
