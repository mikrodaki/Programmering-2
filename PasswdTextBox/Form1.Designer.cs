namespace PasswdTextBox
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
			tbPasswd = new TextBox();
			lblShowPasswd = new Label();
			btnShowMe = new Button();
			SuspendLayout();
			// 
			// tbPasswd
			// 
			tbPasswd.Location = new Point(20, 25);
			tbPasswd.Name = "tbPasswd";
			tbPasswd.PasswordChar = '*';
			tbPasswd.Size = new Size(245, 31);
			tbPasswd.TabIndex = 0;
			tbPasswd.TextChanged += textBox1_TextChanged;
			// 
			// lblShowPasswd
			// 
			lblShowPasswd.BorderStyle = BorderStyle.Fixed3D;
			lblShowPasswd.Location = new Point(20, 75);
			lblShowPasswd.Name = "lblShowPasswd";
			lblShowPasswd.Size = new Size(245, 31);
			lblShowPasswd.TabIndex = 1;
			lblShowPasswd.Text = "MyPassword";
			lblShowPasswd.Click += label1_Click;
			// 
			// btnShowMe
			// 
			btnShowMe.Location = new Point(83, 152);
			btnShowMe.Name = "btnShowMe";
			btnShowMe.Size = new Size(100, 40);
			btnShowMe.TabIndex = 2;
			btnShowMe.Text = "Show Me";
			btnShowMe.UseVisualStyleBackColor = true;
			btnShowMe.Click += btnShowMe_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(298, 270);
			Controls.Add(btnShowMe);
			Controls.Add(lblShowPasswd);
			Controls.Add(tbPasswd);
			Location = new Point(90, 150);
			Name = "Form1";
			Text = "PasswdTextBox";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox tbPasswd;
		private Label lblShowPasswd;
		private Button btnShowMe;
	}
}
