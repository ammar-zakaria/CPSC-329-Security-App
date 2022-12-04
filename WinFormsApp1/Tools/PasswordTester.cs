using System;
using System.Windows.Forms;
using CPSC_329_Security_App.Resources;

namespace CPSC_329_Security_App.Tools
{
    public partial class PasswordTester : Form
    {
        public PasswordTester()
        {
            InitializeComponent();
            this.passwordInput.Select();
        }

        private void passwordTest_Click(object sender, EventArgs e)
        {
            var passwordToTest = new Tester(Environment.CurrentDirectory + "\\Resources\\NordPass2021List.txt", 8);
            string passwordStr = passwordToTest.testPassword(passwordInput.Text);

            if (!string.IsNullOrEmpty(passwordInput.Text))
            {
                MessageBox.Show(passwordStr, "Password Strength", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cannot test an empty password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
