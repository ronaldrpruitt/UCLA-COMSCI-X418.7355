using System;
using System.Windows.Forms;

namespace week7_rpruitt
{
    public partial class SignInForm : week7_rpruitt.SignInBase
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            int result = DBHelper.GuestSave(FirstNameTextBox.Text, LastNameTextBox.Text, ApartmentTextBox.Text);

            if (result > 0)
            {
                AlertBaselabel.Text = "You have been signed in";
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
}