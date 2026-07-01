namespace _1._13___Menus
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
            fileToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            blackToolStripMenuItem = new ToolStripMenuItem();
            blueToolStripMenuItem = new ToolStripMenuItem();
            redToolStripMenuItem = new ToolStripMenuItem();
            greenToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            timesNewRomanToolStripMenuItem = new ToolStripMenuItem();
            courierToolStripMenuItem = new ToolStripMenuItem();
            comicSansToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            boldToolStripMenuItem = new ToolStripMenuItem();
            italicToolStripMenuItem = new ToolStripMenuItem();
            displayLabel = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, formatToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(594, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(107, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { colorToolStripMenuItem, fontToolStripMenuItem });
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(57, 20);
            formatToolStripMenuItem.Text = "Format";
            formatToolStripMenuItem.Click += formatToolStripMenuItem_Click;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { blackToolStripMenuItem, blueToolStripMenuItem, redToolStripMenuItem, greenToolStripMenuItem });
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(180, 22);
            colorToolStripMenuItem.Text = "Color";
            // 
            // blackToolStripMenuItem
            // 
            blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            blackToolStripMenuItem.Size = new Size(105, 22);
            blackToolStripMenuItem.Text = "Black";
            blackToolStripMenuItem.Click += blackToolStripMenuItem_Click;
            // 
            // blueToolStripMenuItem
            // 
            blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            blueToolStripMenuItem.Size = new Size(105, 22);
            blueToolStripMenuItem.Text = "Blue";
            blueToolStripMenuItem.Click += blueToolStripMenuItem_Click;
            // 
            // redToolStripMenuItem
            // 
            redToolStripMenuItem.Name = "redToolStripMenuItem";
            redToolStripMenuItem.Size = new Size(105, 22);
            redToolStripMenuItem.Text = "Red";
            redToolStripMenuItem.Click += redToolStripMenuItem_Click;
            // 
            // greenToolStripMenuItem
            // 
            greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            greenToolStripMenuItem.Size = new Size(105, 22);
            greenToolStripMenuItem.Text = "Green";
            greenToolStripMenuItem.Click += greenToolStripMenuItem_Click;
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { timesNewRomanToolStripMenuItem, courierToolStripMenuItem, comicSansToolStripMenuItem, toolStripSeparator1, boldToolStripMenuItem, italicToolStripMenuItem });
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(180, 22);
            fontToolStripMenuItem.Text = "Font";
            // 
            // timesNewRomanToolStripMenuItem
            // 
            timesNewRomanToolStripMenuItem.Name = "timesNewRomanToolStripMenuItem";
            timesNewRomanToolStripMenuItem.Size = new Size(180, 22);
            timesNewRomanToolStripMenuItem.Text = "Times New Roman";
            timesNewRomanToolStripMenuItem.Click += timesNewRomanToolStripMenuItem_Click;
            // 
            // courierToolStripMenuItem
            // 
            courierToolStripMenuItem.Name = "courierToolStripMenuItem";
            courierToolStripMenuItem.Size = new Size(180, 22);
            courierToolStripMenuItem.Text = "Courier";
            courierToolStripMenuItem.Click += courierToolStripMenuItem_Click;
            // 
            // comicSansToolStripMenuItem
            // 
            comicSansToolStripMenuItem.Name = "comicSansToolStripMenuItem";
            comicSansToolStripMenuItem.Size = new Size(180, 22);
            comicSansToolStripMenuItem.Text = "Comic Sans";
            comicSansToolStripMenuItem.Click += comicSansToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // boldToolStripMenuItem
            // 
            boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            boldToolStripMenuItem.Size = new Size(180, 22);
            boldToolStripMenuItem.Text = "Bold";
            boldToolStripMenuItem.Click += boldToolStripMenuItem_Click;
            // 
            // italicToolStripMenuItem
            // 
            italicToolStripMenuItem.Name = "italicToolStripMenuItem";
            italicToolStripMenuItem.Size = new Size(180, 22);
            italicToolStripMenuItem.Text = "Italic";
            italicToolStripMenuItem.Click += italicToolStripMenuItem_Click;
            // 
            // displayLabel
            // 
            displayLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            displayLabel.Location = new Point(80, 120);
            displayLabel.Name = "displayLabel";
            displayLabel.Size = new Size(435, 135);
            displayLabel.TabIndex = 1;
            displayLabel.Text = "Använd Format-menyn för att ändra denna texts utseende.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 321);
            Controls.Add(displayLabel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem blackToolStripMenuItem;
        private ToolStripMenuItem blueToolStripMenuItem;
        private ToolStripMenuItem redToolStripMenuItem;
        private ToolStripMenuItem greenToolStripMenuItem;
        private ToolStripMenuItem timesNewRomanToolStripMenuItem;
        private ToolStripMenuItem courierToolStripMenuItem;
        private ToolStripMenuItem comicSansToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem boldToolStripMenuItem;
        private ToolStripMenuItem italicToolStripMenuItem;
        private Label displayLabel;
    }
}
