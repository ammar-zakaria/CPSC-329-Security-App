using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPSC_329_Security_App.Tools
{
    public partial class PasswordGeneratorForm : Form
    {
        public PasswordGeneratorForm()
        {
            InitializeComponent();
            this.passLengthController.Value = 8;
        }

        private static string CreatePassword(int passLength, bool includesSpecChars)
        {
            // look into using System.Security.Cryptography.RNGCryptoServiceProvider, more cryptographically secure

            var valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            valid += includesSpecChars ? " !\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~" : "";

            StringBuilder res = new();
            Random rnd = new();
            while (0 < passLength--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }

            return res.ToString();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            var newPassword = CreatePassword((int)this.passLengthController.Value, this.yesRadioButton.Checked);
            Console.WriteLine(newPassword);
            Clipboard.SetText(newPassword);
            MessageBox.Show("Your new password is: " + newPassword + "\n\nIt has been copied to your clipboard.", "New Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
