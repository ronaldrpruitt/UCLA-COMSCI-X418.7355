using System;
using System.Linq;
using System.Windows.Forms;

namespace week7_rpruitt
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void signInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignInForm signIn = new SignInForm();
            signIn.MdiParent = this;
            signIn.Show();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignOutForm signOut = new SignOutForm();
            signOut.MdiParent = this;
            signOut.Show();
        }

        private void viewGuestLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close existing form and get latest form data.
            if (Application.OpenForms.OfType<GuestLogForm>().Count() == 1)
            {
                Application.OpenForms.OfType<GuestLogForm>().First().Close();
            }

            GuestLogForm logForm = new GuestLogForm();
            logForm.MdiParent = this;
            logForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}