using System;
using System.Windows.Forms;

namespace week7_rpruitt
{
    public partial class SignOutForm : week7_rpruitt.SignInBase
    {
        public SignOutForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            int result = DBHelper.GuestUpdate(FirstNameTextBox.Text, LastNameTextBox.Text);

            AlertBaselabel.Text = (result > 0) ? "You have been signed out" : "User not found. Try Again";
            AlertBaselabel.Visible = true;
            System.Threading.Tasks.Task.Delay(1500).ContinueWith(_ =>
            {
                Invoke(new MethodInvoker(() =>
                {
                    AlertBaselabel.Visible = false;
                    FirstNameTextBox.Clear();
                    LastNameTextBox.Clear();
                    ApartmentTextBox.Clear();
                }));
            });
        }
    }
}