using CPSC_329_Security_App.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPSC329SecurityApp
{
    public partial class BaseForm : Form
    {
        private Form PasswordGeneratorWindow { get; set; }
        private Form PasswordTesterWindow { get; set; }

        public BaseForm()
        {
            InitializeComponent();
        }

        private void passwordGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenPasswordGeneratorForm();
        }

        private void passwordTesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenPasswordTesterForm();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void passwordGeneratorButton_Click(object sender, EventArgs e)
        {
            this.OpenPasswordGeneratorForm();
        }

        private void passwordTesterButton_Click(object sender, EventArgs e)
        {
            this.OpenPasswordTesterForm();
        }

        private void OpenPasswordGeneratorForm()
        {
            if (this.PasswordGeneratorWindow == null)
            {
                this.PasswordGeneratorWindow = new PasswordGeneratorForm();
                this.PasswordGeneratorWindow.Show();
                this.PasswordGeneratorWindow.FormClosed += (sender1, e1) =>
                {
                    this.PasswordGeneratorWindow = null;
                };
            }
            else
            {
                this.PasswordGeneratorWindow.BringToFront();
            }
        }

        private void OpenPasswordTesterForm()
        {
            if (this.PasswordTesterWindow == null)
            {
                this.PasswordTesterWindow = new PasswordTester();
                this.PasswordTesterWindow.Show();
                this.PasswordTesterWindow.FormClosed += (sender1, e1) =>
                {
                    this.PasswordTesterWindow = null;
                };
            }
            else
            {
                this.PasswordTesterWindow.BringToFront();
            }
        }
    }
}
