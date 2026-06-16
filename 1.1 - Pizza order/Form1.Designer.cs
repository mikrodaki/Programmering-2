namespace _1._1___Pizza_order
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
            comboBoxPizza = new ComboBox();
            groupBoxPizzaSize = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label1 = new Label();
            groupBoxExtras = new GroupBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            groupBoxPizzaSize.SuspendLayout();
            groupBoxExtras.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxPizza
            // 
            comboBoxPizza.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPizza.FormattingEnabled = true;
            comboBoxPizza.Items.AddRange(new object[] { "Margherita", "Vesuvio", "Hawaii", "Kebabpizza" });
            comboBoxPizza.Location = new Point(29, 58);
            comboBoxPizza.Name = "comboBoxPizza";
            comboBoxPizza.Size = new Size(151, 28);
            comboBoxPizza.TabIndex = 0;
            // 
            // groupBoxPizzaSize
            // 
            groupBoxPizzaSize.Controls.Add(radioButton3);
            groupBoxPizzaSize.Controls.Add(radioButton2);
            groupBoxPizzaSize.Controls.Add(radioButton1);
            groupBoxPizzaSize.Location = new Point(207, 29);
            groupBoxPizzaSize.Name = "groupBoxPizzaSize";
            groupBoxPizzaSize.Size = new Size(180, 210);
            groupBoxPizzaSize.TabIndex = 1;
            groupBoxPizzaSize.TabStop = false;
            groupBoxPizzaSize.Text = "Storlek";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(26, 89);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(57, 24);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Stor";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(26, 59);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(75, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Mellan";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(26, 29);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(62, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Liten";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 29);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 2;
            label1.Text = "Pizza";
            // 
            // groupBoxExtras
            // 
            groupBoxExtras.Controls.Add(checkBox4);
            groupBoxExtras.Controls.Add(checkBox3);
            groupBoxExtras.Controls.Add(checkBox2);
            groupBoxExtras.Controls.Add(checkBox1);
            groupBoxExtras.Location = new Point(417, 29);
            groupBoxExtras.Name = "groupBoxExtras";
            groupBoxExtras.Size = new Size(187, 210);
            groupBoxExtras.TabIndex = 3;
            groupBoxExtras.TabStop = false;
            groupBoxExtras.Text = "Tillbehör";
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(19, 120);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(105, 24);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Extra oliver";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(19, 90);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(88, 24);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Stark sås";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(19, 59);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(95, 24);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Vitlökssås";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(19, 29);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(88, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Extra ost";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(29, 191);
            button1.Name = "button1";
            button1.Size = new Size(151, 48);
            button1.TabIndex = 4;
            button1.Text = "Beställ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnOrder_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 279);
            Controls.Add(button1);
            Controls.Add(groupBoxExtras);
            Controls.Add(label1);
            Controls.Add(groupBoxPizzaSize);
            Controls.Add(comboBoxPizza);
            Name = "Form1";
            Text = "Pizza order";
            groupBoxPizzaSize.ResumeLayout(false);
            groupBoxPizzaSize.PerformLayout();
            groupBoxExtras.ResumeLayout(false);
            groupBoxExtras.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxPizza;
        private GroupBox groupBoxPizzaSize;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label1;
        private GroupBox groupBoxExtras;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private CheckBox checkBox4;
        private Button button1;
    }
}
