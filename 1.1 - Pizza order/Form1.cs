namespace _1._1___Pizza_order
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string output = string.Empty;
            output = $"-{comboBoxPizza.Text}";

            foreach (Control c in groupBoxPizzaSize.Controls) 
            {
                if (c is RadioButton rb && rb.Checked)
                    output += "\n-" + rb.Text;
            }

            foreach (Control c in groupBoxExtras.Controls)
            {
                if (c is CheckBox cb && cb.Checked)
                    output += "\n-" + cb.Text;
            }

            MessageBox.Show(output, "Din beställning");
        }
    }
}
