
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordTesterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordGeneratorButton = new System.Windows.Forms.Button();
            this.passwordTesterButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(663, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passwordGeneratorToolStripMenuItem,
            this.passwordTesterToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // passwordGeneratorToolStripMenuItem
            // 
            this.passwordGeneratorToolStripMenuItem.Name = "passwordGeneratorToolStripMenuItem";
            this.passwordGeneratorToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.passwordGeneratorToolStripMenuItem.Text = "Password Generator";
            this.passwordGeneratorToolStripMenuItem.Click += new System.EventHandler(this.passwordGeneratorToolStripMenuItem_Click);
            // 
            // passwordTesterToolStripMenuItem
            // 
            this.passwordTesterToolStripMenuItem.Name = "passwordTesterToolStripMenuItem";
            this.passwordTesterToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.passwordTesterToolStripMenuItem.Text = "Password Tester";
            this.passwordTesterToolStripMenuItem.Click += new System.EventHandler(this.passwordTesterToolStripMenuItem_Click);
            // 
            // passwordGeneratorButton
            // 
            this.passwordGeneratorButton.Location = new System.Drawing.Point(85, 140);
            this.passwordGeneratorButton.Name = "passwordGeneratorButton";
            this.passwordGeneratorButton.Size = new System.Drawing.Size(200, 49);
            this.passwordGeneratorButton.TabIndex = 1;
            this.passwordGeneratorButton.Text = "Generate a New Password";
            this.passwordGeneratorButton.UseVisualStyleBackColor = true;
            this.passwordGeneratorButton.Click += new System.EventHandler(this.passwordGeneratorButton_Click);
            // 
            // passwordTesterButton
            // 
            this.passwordTesterButton.Location = new System.Drawing.Point(374, 140);
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
            this.welcomeLabel.Location = new System.Drawing.Point(186, 72);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(289, 40);
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BaseForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "CPSC 329 Security App";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordGeneratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordTesterToolStripMenuItem;
        private System.Windows.Forms.Button passwordGeneratorButton;
        private System.Windows.Forms.Button passwordTesterButton;
        private System.Windows.Forms.Label welcomeLabel;
    }
}

