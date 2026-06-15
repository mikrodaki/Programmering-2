namespace Interaction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Texten till en MassageBox som visas varje gång man klickar på" +
                "button1 i formen.", "Det här är en egenvald rubrik till MassageBox");
        }
    }
}
