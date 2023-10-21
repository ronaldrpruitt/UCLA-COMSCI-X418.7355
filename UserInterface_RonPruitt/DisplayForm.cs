using System;
using System.Windows.Forms;

namespace UserInterface_RonPruitt
{
    public partial class DisplayForm : Form
    {
        public DisplayForm()
        {
            InitializeComponent();
        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormA formA = new FormA();
            formA.ShowDialog();
        }

        private void formBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormB formB = new FormB();
            formB.ShowDialog();
        }

        private void messageBox1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Message Box 1 has been activated.");
        }

        private void messageBox2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Message Box 2 has been activated.");
        }
    }
}
