using System;
using System.Windows.Forms;

namespace DevBrowser
{
    public partial class Form1 : Form
    {
        Navigate myNavigateBox = new Navigate();
        AboutBox myAboutBox = new AboutBox();
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myAboutBox.ShowDialog();
        }

        private void navigateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (myNavigateBox.ShowDialog() == DialogResult.OK) 
            { 
                browserWindow.Navigate(myNavigateBox.txtURL.Text);
            }
        }
    }
}
