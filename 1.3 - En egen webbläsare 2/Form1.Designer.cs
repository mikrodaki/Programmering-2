namespace Webbrowser
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.tbURL = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.browserWindow = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(18, 1000);
            this.tbURL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(1528, 26);
            this.tbURL.TabIndex = 1;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(1590, 1000);
            this.btnGo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(120, 46);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Kör";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // browserWindow
            // 
            this.browserWindow.Location = new System.Drawing.Point(12, 18);
            this.browserWindow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.browserWindow.MinimumSize = new System.Drawing.Size(30, 31);
            this.browserWindow.Name = "browserWindow";
            this.browserWindow.ScriptErrorsSuppressed = true;
            this.browserWindow.Size = new System.Drawing.Size(1150, 620);
            this.browserWindow.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 704);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.browserWindow);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Min första webbläsare";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox tbURL;
		private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.WebBrowser browserWindow;
    }
}

