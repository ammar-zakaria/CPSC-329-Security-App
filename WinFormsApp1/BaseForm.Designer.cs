
namespace CPSC329SecurityApp
{
    partial class BaseForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.passwordGeneratorButton = new System.Windows.Forms.Button();
            this.passwordTesterButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passwordGeneratorButton
            // 
            this.passwordGeneratorButton.Location = new System.Drawing.Point(85, 137);
            this.passwordGeneratorButton.Name = "passwordGeneratorButton";
            this.passwordGeneratorButton.Size = new System.Drawing.Size(200, 49);
            this.passwordGeneratorButton.TabIndex = 1;
            this.passwordGeneratorButton.Text = "Generate a New Password";
            this.passwordGeneratorButton.UseVisualStyleBackColor = true;
            this.passwordGeneratorButton.Click += new System.EventHandler(this.passwordGeneratorButton_Click);
            // 
            // passwordTesterButton
            // 
            this.passwordTesterButton.Location = new System.Drawing.Point(374, 137);
            this.passwordTesterButton.Name = "passwordTesterButton";
            this.passwordTesterButton.Size = new System.Drawing.Size(200, 49);
            this.passwordTesterButton.TabIndex = 2;
            this.passwordTesterButton.Text = "Test Your Existing Password";
            this.passwordTesterButton.UseVisualStyleBackColor = true;
            this.passwordTesterButton.Click += new System.EventHandler(this.passwordTesterButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.Location = new System.Drawing.Point(129, 40);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(416, 56);
            this.welcomeLabel.TabIndex = 3;
            this.welcomeLabel.Text = "Welcome to the CPSC 329 Security Applet!\r\nSelect an option below:";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 269);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.passwordTesterButton);
            this.Controls.Add(this.passwordGeneratorButton);
            this.Name = "BaseForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "CPSC 329 Security App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button passwordGeneratorButton;
        private System.Windows.Forms.Button passwordTesterButton;
        private System.Windows.Forms.Label welcomeLabel;
    }
}

