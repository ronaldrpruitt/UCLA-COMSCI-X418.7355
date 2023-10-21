using System;
using System.Windows.Forms;

namespace UserInterface_RonPruitt
{
    public partial class FormB : Form
    {
        public FormB()
        {
            InitializeComponent();
        }

        private void formBExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void messageBox1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Message Box 1 has been activated");
        }

        private void messageBox2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Message Box 2 has been activated");
        }
    }
}
