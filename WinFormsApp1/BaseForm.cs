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

        public BaseForm()
        {
            InitializeComponent();
        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }

        private void passwordGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.PasswordGeneratorWindow == null)
            {

                this.PasswordGeneratorWindow = new PasswordGenerator();
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

            var numlist = new List<int>();
            numlist.Add(5);

            foreach (var a in numlist)
            {

            }


        }

        public static bool disableBttn = false;

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void testformToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var x = new testform();
            x.Show();
        }
    }
}
