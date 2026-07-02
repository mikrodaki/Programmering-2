namespace _1._11___Web_browser
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
			this.browserWindow = new System.Windows.Forms.WebBrowser();
			this.tbURL = new System.Windows.Forms.TextBox();
			this.btnGo = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnFwd = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.rensaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// browserWindow
			// 
			this.browserWindow.Location = new System.Drawing.Point(13, 32);
			this.browserWindow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.browserWindow.MinimumSize = new System.Drawing.Size(27, 25);
			this.browserWindow.Name = "browserWindow";
			this.browserWindow.ScriptErrorsSuppressed = true;
			this.browserWindow.Size = new System.Drawing.Size(1161, 648);
			this.browserWindow.TabIndex = 0;
			// 
			// tbURL
			// 
			this.tbURL.Location = new System.Drawing.Point(13, 699);
			this.tbURL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbURL.Name = "tbURL";
			this.tbURL.Size = new System.Drawing.Size(555, 22);
			this.tbURL.TabIndex = 1;
			this.tbURL.TextChanged += new System.EventHandler(this.tbURL_TextChanged);
			// 
			// btnGo
			// 
			this.btnGo.Location = new System.Drawing.Point(598, 699);
			this.btnGo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(107, 37);
			this.btnGo.TabIndex = 2;
			this.btnGo.Text = "Kör";
			this.btnGo.UseVisualStyleBackColor = true;
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(734, 699);
			this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(107, 37);
			this.btnBack.TabIndex = 3;
			this.btnBack.Text = "Bakåt";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnFwd
			// 
			this.btnFwd.Location = new System.Drawing.Point(871, 699);
			this.btnFwd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnFwd.Name = "btnFwd";
			this.btnFwd.Size = new System.Drawing.Size(107, 37);
			this.btnFwd.TabIndex = 4;
			this.btnFwd.Text = "Framåt";
			this.btnFwd.UseVisualStyleBackColor = true;
			this.btnFwd.Click += new System.EventHandler(this.btnFwd_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rensaToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.menuStrip1.Size = new System.Drawing.Size(1197, 28);
			this.menuStrip1.TabIndex = 5;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// rensaToolStripMenuItem
			// 
			this.rensaToolStripMenuItem.Name = "rensaToolStripMenuItem";
			this.rensaToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
			this.rensaToolStripMenuItem.Text = "Rensa historik";
			this.rensaToolStripMenuItem.Click += new System.EventHandler(this.rensaToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1197, 748);
			this.Controls.Add(this.btnFwd);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnGo);
			this.Controls.Add(this.tbURL);
			this.Controls.Add(this.browserWindow);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form1";
			this.Text = "Min första webbläsare";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser browserWindow;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFwd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rensaToolStripMenuItem;
    }
}

