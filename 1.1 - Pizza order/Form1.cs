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

            foreach (RadioButton rb in groupBoxPizzaSize.Controls) 
            {
                if (rb.Checked)
                    output += "\n-" + rb.Text;
            }

            foreach (CheckBox cb in groupBoxExtras.Controls)
            {
                if (cb.Checked)
                    output += "\n-" + cb.Text;
            }

            MessageBox.Show(output, "Din beställning");
        }
    }
}
