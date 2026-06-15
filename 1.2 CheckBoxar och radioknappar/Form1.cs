namespace _1._2_CheckBoxar_och_radioknappar
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}


		private void bthFinish_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnServ_Click(object sender, EventArgs e)
		{
			string output = string.Empty;
			if (chkVodka.Checked && !chkGin.Checked)
				output = "Vodka serveras ";
			if (chkGin.Checked && !chkVodka.Checked)
				output = "Gin serveras ";
			if (chkGin.Checked && chkVodka.Checked)
				output = "Vodka och Gin serveras ";
			if (optShotGlass.Checked)
				output += "i snapsglas.";
			if (optCoktailGlass.Checked)
				output += "i cocktailglas.";
			if (optWineGlass.Checked)
				output += "i vinglas.";
			MessageBox.Show(output, "Bartender svarar:");
		}
	}
}
