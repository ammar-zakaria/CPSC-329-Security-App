
namespace CPSC_329_Security_App.Tools
{
    partial class PasswordGeneratorForm
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
            this.passLengthController = new System.Windows.Forms.NumericUpDown();
            this.yesRadioButton = new System.Windows.Forms.RadioButton();
            this.noRadioButton = new System.Windows.Forms.RadioButton();
            this.specialCharLabel = new System.Windows.Forms.Label();
            this.passLenghtLabel = new System.Windows.Forms.Label();
            this.passSpecificationsLabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.passLengthController)).BeginInit();
            this.SuspendLayout();
            // 
            // passLengthController
            // 
            this.passLengthController.Location = new System.Drawing.Point(88, 107);
            this.passLengthController.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.passLengthController.Name = "passLengthController";
            this.passLengthController.Size = new System.Drawing.Size(81, 27);
            this.passLengthController.TabIndex = 2;
            this.passLengthController.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // yesRadioButton
            // 
            this.yesRadioButton.AutoSize = true;
            this.yesRadioButton.Checked = true;
            this.yesRadioButton.Location = new System.Drawing.Point(311, 95);
            this.yesRadioButton.Name = "yesRadioButton";
            this.yesRadioButton.Size = new System.Drawing.Size(51, 24);
            this.yesRadioButton.TabIndex = 3;
            this.yesRadioButton.TabStop = true;
            this.yesRadioButton.Text = "Yes";
            this.yesRadioButton.UseVisualStyleBackColor = true;
            // 
            // noRadioButton
            // 
            this.noRadioButton.AutoSize = true;
            this.noRadioButton.Location = new System.Drawing.Point(311, 125);
            this.noRadioButton.Name = "noRadioButton";
            this.noRadioButton.Size = new System.Drawing.Size(50, 24);
            this.noRadioButton.TabIndex = 4;
            this.noRadioButton.Text = "No";
            this.noRadioButton.UseVisualStyleBackColor = true;
            // 
            // specialCharLabel
            // 
            this.specialCharLabel.AutoSize = true;
            this.specialCharLabel.Location = new System.Drawing.Point(301, 72);
            this.specialCharLabel.Name = "specialCharLabel";
            this.specialCharLabel.Size = new System.Drawing.Size(178, 20);
            this.specialCharLabel.TabIndex = 5;
            this.specialCharLabel.Text = "Include special characters";
            // 
            // passLenghtLabel
            // 
            this.passLenghtLabel.AutoSize = true;
            this.passLenghtLabel.Location = new System.Drawing.Point(79, 73);
            this.passLenghtLabel.Name = "passLenghtLabel";
            this.passLenghtLabel.Size = new System.Drawing.Size(116, 20);
            this.passLenghtLabel.TabIndex = 6;
            this.passLenghtLabel.Text = "Password length";
            // 
            // passSpecificationsLabel
            // 
            this.passSpecificationsLabel.AutoSize = true;
            this.passSpecificationsLabel.Location = new System.Drawing.Point(79, 38);
            this.passSpecificationsLabel.Name = "passSpecificationsLabel";
            this.passSpecificationsLabel.Size = new System.Drawing.Size(246, 20);
            this.passSpecificationsLabel.TabIndex = 7;
            this.passSpecificationsLabel.Text = "Select your password specifications:";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(147, 182);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(243, 29);
            this.generateButton.TabIndex = 8;
            this.generateButton.Text = "Generate Random Password";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // PasswordGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 243);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.passSpecificationsLabel);
            this.Controls.Add(this.passLenghtLabel);
            this.Controls.Add(this.specialCharLabel);
            this.Controls.Add(this.noRadioButton);
            this.Controls.Add(this.yesRadioButton);
            this.Controls.Add(this.passLengthController);
            this.Name = "PasswordGenerator";
            this.Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.passLengthController)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown passLengthController;
        private System.Windows.Forms.RadioButton yesRadioButton;
        private System.Windows.Forms.RadioButton noRadioButton;
        private System.Windows.Forms.Label specialCharLabel;
        private System.Windows.Forms.Label passLenghtLabel;
        private System.Windows.Forms.Label passSpecificationsLabel;
        private System.Windows.Forms.Button generateButton;
    }
}