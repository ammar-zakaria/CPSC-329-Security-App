using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPSC329SecurityApp;

namespace CPSC_329_Security_App.Tools
{
    public partial class PasswordTester : Form
    {
        public PasswordTester()
        {
            InitializeComponent();
        }

        private void passwordTest_Click(object sender, EventArgs e)
        {
            var passwordToTest = new Tester("NordPass2021List.txt", 8);
            string passwordStr = passwordToTest.testPassword(passwordInput.Text);

            if (!string.IsNullOrEmpty(passwordStr))
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
