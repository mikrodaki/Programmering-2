namespace _1._2_CheckBoxar_och_radioknappar
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
			grbDrink = new GroupBox();
			chkGin = new CheckBox();
			chkVodka = new CheckBox();
			grbGlass = new GroupBox();
			optWineGlass = new RadioButton();
			optCoktailGlass = new RadioButton();
			optShotGlass = new RadioButton();
			btnServ = new Button();
			bthFinish = new Button();
			grbDrink.SuspendLayout();
			grbGlass.SuspendLayout();
			SuspendLayout();
			// 
			// grbDrink
			// 
			grbDrink.Controls.Add(chkGin);
			grbDrink.Controls.Add(chkVodka);
			grbDrink.Location = new Point(37, 42);
			grbDrink.Name = "grbDrink";
			grbDrink.Size = new Size(155, 150);
			grbDrink.TabIndex = 0;
			grbDrink.TabStop = false;
			grbDrink.Text = "Dryck";
			// 
			// chkGin
			// 
			chkGin.AutoSize = true;
			chkGin.Location = new Point(27, 81);
			chkGin.Name = "chkGin";
			chkGin.Size = new Size(64, 29);
			chkGin.TabIndex = 1;
			chkGin.Text = "Gin";
			chkGin.UseVisualStyleBackColor = true;
			// 
			// chkVodka
			// 
			chkVodka.AutoSize = true;
			chkVodka.Location = new Point(27, 36);
			chkVodka.Name = "chkVodka";
			chkVodka.Size = new Size(88, 29);
			chkVodka.TabIndex = 0;
			chkVodka.Text = "Vodka";
			chkVodka.UseVisualStyleBackColor = true;
			// 
			// grbGlass
			// 
			grbGlass.Controls.Add(optWineGlass);
			grbGlass.Controls.Add(optCoktailGlass);
			grbGlass.Controls.Add(optShotGlass);
			grbGlass.Location = new Point(220, 42);
			grbGlass.Name = "grbGlass";
			grbGlass.Size = new Size(188, 150);
			grbGlass.TabIndex = 2;
			grbGlass.TabStop = false;
			grbGlass.Text = "Välj glas";
			// 
			// optWineGlass
			// 
			optWineGlass.AutoSize = true;
			optWineGlass.Location = new Point(28, 104);
			optWineGlass.Name = "optWineGlass";
			optWineGlass.Size = new Size(94, 29);
			optWineGlass.TabIndex = 2;
			optWineGlass.TabStop = true;
			optWineGlass.Text = "Vinglas";
			optWineGlass.UseVisualStyleBackColor = true;
			// 
			// optCoktailGlass
			// 
			optCoktailGlass.AutoSize = true;
			optCoktailGlass.Location = new Point(28, 66);
			optCoktailGlass.Name = "optCoktailGlass";
			optCoktailGlass.Size = new Size(131, 29);
			optCoktailGlass.TabIndex = 1;
			optCoktailGlass.TabStop = true;
			optCoktailGlass.Text = "Cocktailglas";
			optCoktailGlass.UseVisualStyleBackColor = true;
			// 
			// optShotGlass
			// 
			optShotGlass.AutoSize = true;
			optShotGlass.Location = new Point(28, 31);
			optShotGlass.Name = "optShotGlass";
			optShotGlass.Size = new Size(117, 29);
			optShotGlass.TabIndex = 0;
			optShotGlass.TabStop = true;
			optShotGlass.Text = "Snapsglas";
			optShotGlass.UseVisualStyleBackColor = true;
			// 
			// btnServ
			// 
			btnServ.Location = new Point(448, 44);
			btnServ.Name = "btnServ";
			btnServ.Size = new Size(148, 95);
			btnServ.TabIndex = 3;
			btnServ.Text = "Servera";
			btnServ.UseVisualStyleBackColor = true;
			btnServ.Click += btnServ_Click;
			// 
			// bthFinish
			// 
			bthFinish.Location = new Point(462, 158);
			bthFinish.Name = "bthFinish";
			bthFinish.Size = new Size(114, 69);
			bthFinish.TabIndex = 4;
			bthFinish.Text = "Avsluta";
			bthFinish.UseVisualStyleBackColor = true;
			bthFinish.Click += bthFinish_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(643, 268);
			Controls.Add(bthFinish);
			Controls.Add(btnServ);
			Controls.Add(grbGlass);
			Controls.Add(grbDrink);
			Name = "Form1";
			Text = "Var så god och välj";
			Load += Form1_Load;
			grbDrink.ResumeLayout(false);
			grbDrink.PerformLayout();
			grbGlass.ResumeLayout(false);
			grbGlass.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox grbDrink;
		private CheckBox chkGin;
		private CheckBox chkVodka;
		private GroupBox grbGlass;
		private RadioButton optWineGlass;
		private RadioButton optCoktailGlass;
		private RadioButton optShotGlass;
		private Button btnServ;
		private Button bthFinish;
	}
}
