
namespace CPSC_329_Security_App.Tools
{
    partial class PasswordTester
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.passwordTest = new System.Windows.Forms.Button();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passwordTest
            // 
            this.passwordTest.Location = new System.Drawing.Point(213, 160);
            this.passwordTest.Name = "passwordTest";
            this.passwordTest.Size = new System.Drawing.Size(144, 27);
            this.passwordTest.TabIndex = 0;
            this.passwordTest.Text = "Test Password";
            this.passwordTest.UseVisualStyleBackColor = true;
            this.passwordTest.Click += new System.EventHandler(this.passwordTest_Click);
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(150, 101);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PlaceholderText = "Type your password here";
            this.passwordInput.Size = new System.Drawing.Size(270, 27);
            this.passwordInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(157, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Test the strength of your password";
            // 
            // PasswordTester
            // 
            this.AcceptButton = this.passwordTest;
            this.ClientSize = new System.Drawing.Size(552, 264);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.passwordTest);
            this.Name = "PasswordTester";
            this.Text = "Password Strength Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button passwordTest;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Label label1;
    }
}