namespace School_register
{
	public partial class Form1 : Form
	{
		School school1 = new School("The test school");
		public Form1()
		{
			InitializeComponent();
			school1.years = new List<Year>();
		}

		private void btnCreateNewYear_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Knappen fungerar!");
		}
	}
}
