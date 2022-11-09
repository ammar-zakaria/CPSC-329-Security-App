using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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

        private static string CreatePassword(int passLength, bool includesSpecChars, bool includeNumbers, bool excludeAmbigChars, bool includeUpperChars, bool includeLowerChars)
        {
            var valid = string.Empty;
            valid += includeLowerChars ? "abcdefghijklmnopqrstuvwxyz" : string.Empty;
            valid += includeUpperChars ? "ABCDEFGHIJKLMNOPQRSTUVWXYZ" : string.Empty;
            valid += includeNumbers ? "1234567890" : string.Empty;
            valid += includesSpecChars ? " !\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~" : string.Empty;

            // is this the full list of ambiguous characters?
            var ambiguousChars = new string[] { "l", "1", "I", "O", "0" };
            if (excludeAmbigChars)
            {
                foreach (var ambigChar in ambiguousChars)
                {
                    valid = valid.Replace(ambigChar, string.Empty);
                }
            }

            StringBuilder res = new();

            if (valid.Length > 0)
            {
                while (0 < passLength--)
                {
                    res.Append(valid[RandomNumberGenerator.GetInt32(valid.Length)]);
                }
            }

            return res.ToString();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            var newPassword = CreatePassword((int)this.passLengthController.Value, this.specialCharYesRadioButton.Checked, this.numberYesRadioButton.Checked, this.ambigCharYesRadioButton.Checked,
                this.uppercaseCheckbox.Checked, this.lowercaseCheckbox.Checked);

            if (!string.IsNullOrEmpty(newPassword))
            {
                Clipboard.SetText(newPassword);
                MessageBox.Show("Your new password is: " + newPassword + "\n\nIt has been copied to your clipboard.", "New Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cannot generate an empty password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
