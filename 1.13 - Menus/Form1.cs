namespace _1._13___Menus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Detta program demonstrerar användningen av menyer", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearColor()
        {
            blackToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            displayLabel.ForeColor = Color.Black;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            displayLabel.ForeColor = Color.Blue;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            displayLabel.ForeColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            displayLabel.ForeColor = Color.Green;
        }

        private void ClearFont()
        {
            timesNewRomanToolStripMenuItem.Checked = false;
            courierToolStripMenuItem.Checked = false;
            comicSansToolStripMenuItem.Checked = false;
        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            timesNewRomanToolStripMenuItem.Checked = true;
            displayLabel.Font = new Font("Times New Roman", 14, displayLabel.Font.Style);
        }

        private void courierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            courierToolStripMenuItem.Checked = true;
            displayLabel.Font = new Font("Courier", 14, displayLabel.Font.Style);
        }

        private void comicSansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            comicSansToolStripMenuItem.Checked = true;
            displayLabel.Font = new Font("Comic Sans MS", 14, displayLabel.Font.Style);
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boldToolStripMenuItem.Checked = !boldToolStripMenuItem.Checked;
            displayLabel.Font = new Font(displayLabel.Font, displayLabel.Font.Style ^ FontStyle.Bold);
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            italicToolStripMenuItem.Checked = !italicToolStripMenuItem.Checked;
            displayLabel.Font = new Font(displayLabel.Font, displayLabel.Font.Style ^ FontStyle.Italic);
        }
    }
}
