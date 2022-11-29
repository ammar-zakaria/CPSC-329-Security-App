
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
            this.passLenghtLabel = new System.Windows.Forms.Label();
            this.passSpecificationsLabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.numberLabel = new System.Windows.Forms.Label();
            this.numberNoRadioButton = new System.Windows.Forms.RadioButton();
            this.numberYesRadioButton = new System.Windows.Forms.RadioButton();
            this.ambiguousCharLabel = new System.Windows.Forms.Label();
            this.ambigCharNoRadioButton = new System.Windows.Forms.RadioButton();
            this.ambigCharYesRadioButton = new System.Windows.Forms.RadioButton();
            this.charCasingLabel = new System.Windows.Forms.Label();
            this.uppercaseCheckbox = new System.Windows.Forms.CheckBox();
            this.lowercaseCheckbox = new System.Windows.Forms.CheckBox();
            this.specialCharLabel = new System.Windows.Forms.Label();
            this.specialCharNoRadioButton = new System.Windows.Forms.RadioButton();
            this.specialCharYesRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.passLengthController)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            // passLenghtLabel
            // 
            this.passLenghtLabel.AutoSize = true;
            this.passLenghtLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passLenghtLabel.Location = new System.Drawing.Point(79, 73);
            this.passLenghtLabel.Name = "passLenghtLabel";
            this.passLenghtLabel.Size = new System.Drawing.Size(125, 20);
            this.passLenghtLabel.TabIndex = 6;
            this.passLenghtLabel.Text = "Password length";
            // 
            // passSpecificationsLabel
            // 
            this.passSpecificationsLabel.AutoSize = true;
            this.passSpecificationsLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passSpecificationsLabel.Location = new System.Drawing.Point(80, 24);
            this.passSpecificationsLabel.Name = "passSpecificationsLabel";
            this.passSpecificationsLabel.Size = new System.Drawing.Size(318, 25);
            this.passSpecificationsLabel.TabIndex = 7;
            this.passSpecificationsLabel.Text = "Select your password specifications:";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(202, 302);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(243, 29);
            this.generateButton.TabIndex = 8;
            this.generateButton.Text = "Generate Random Password";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numberLabel.Location = new System.Drawing.Point(16, 12);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(126, 20);
            this.numberLabel.TabIndex = 11;
            this.numberLabel.Text = "Include numbers";
            // 
            // numberNoRadioButton
            // 
            this.numberNoRadioButton.AutoSize = true;
            this.numberNoRadioButton.Location = new System.Drawing.Point(26, 65);
            this.numberNoRadioButton.Name = "numberNoRadioButton";
            this.numberNoRadioButton.Size = new System.Drawing.Size(50, 24);
            this.numberNoRadioButton.TabIndex = 10;
            this.numberNoRadioButton.Text = "No";
            this.numberNoRadioButton.UseVisualStyleBackColor = true;
            // 
            // numberYesRadioButton
            // 
            this.numberYesRadioButton.AutoSize = true;
            this.numberYesRadioButton.Checked = true;
            this.numberYesRadioButton.Location = new System.Drawing.Point(26, 35);
            this.numberYesRadioButton.Name = "numberYesRadioButton";
            this.numberYesRadioButton.Size = new System.Drawing.Size(51, 24);
            this.numberYesRadioButton.TabIndex = 9;
            this.numberYesRadioButton.TabStop = true;
            this.numberYesRadioButton.Text = "Yes";
            this.numberYesRadioButton.UseVisualStyleBackColor = true;
            // 
            // ambiguousCharLabel
            // 
            this.ambiguousCharLabel.AutoSize = true;
            this.ambiguousCharLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ambiguousCharLabel.Location = new System.Drawing.Point(6, 10);
            this.ambiguousCharLabel.Name = "ambiguousCharLabel";
            this.ambiguousCharLabel.Size = new System.Drawing.Size(220, 20);
            this.ambiguousCharLabel.TabIndex = 14;
            this.ambiguousCharLabel.Text = "Exclude ambiguous characters";
            // 
            // ambigCharNoRadioButton
            // 
            this.ambigCharNoRadioButton.AutoSize = true;
            this.ambigCharNoRadioButton.Location = new System.Drawing.Point(16, 63);
            this.ambigCharNoRadioButton.Name = "ambigCharNoRadioButton";
            this.ambigCharNoRadioButton.Size = new System.Drawing.Size(50, 24);
            this.ambigCharNoRadioButton.TabIndex = 13;
            this.ambigCharNoRadioButton.Text = "No";
            this.ambigCharNoRadioButton.UseVisualStyleBackColor = true;
            // 
            // ambigCharYesRadioButton
            // 
            this.ambigCharYesRadioButton.AutoSize = true;
            this.ambigCharYesRadioButton.Checked = true;
            this.ambigCharYesRadioButton.Location = new System.Drawing.Point(16, 33);
            this.ambigCharYesRadioButton.Name = "ambigCharYesRadioButton";
            this.ambigCharYesRadioButton.Size = new System.Drawing.Size(51, 24);
            this.ambigCharYesRadioButton.TabIndex = 12;
            this.ambigCharYesRadioButton.TabStop = true;
            this.ambigCharYesRadioButton.Text = "Yes";
            this.ambigCharYesRadioButton.UseVisualStyleBackColor = true;
            // 
            // charCasingLabel
            // 
            this.charCasingLabel.AutoSize = true;
            this.charCasingLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.charCasingLabel.Location = new System.Drawing.Point(232, 73);
            this.charCasingLabel.Name = "charCasingLabel";
            this.charCasingLabel.Size = new System.Drawing.Size(153, 20);
            this.charCasingLabel.TabIndex = 17;
            this.charCasingLabel.Text = "Alphabets to include";
            // 
            // uppercaseCheckbox
            // 
            this.uppercaseCheckbox.AutoSize = true;
            this.uppercaseCheckbox.Checked = true;
            this.uppercaseCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uppercaseCheckbox.Location = new System.Drawing.Point(243, 97);
            this.uppercaseCheckbox.Name = "uppercaseCheckbox";
            this.uppercaseCheckbox.Size = new System.Drawing.Size(105, 24);
            this.uppercaseCheckbox.TabIndex = 18;
            this.uppercaseCheckbox.Text = "Upper case";
            this.uppercaseCheckbox.UseVisualStyleBackColor = true;
            // 
            // lowercaseCheckbox
            // 
            this.lowercaseCheckbox.AutoSize = true;
            this.lowercaseCheckbox.Checked = true;
            this.lowercaseCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lowercaseCheckbox.Location = new System.Drawing.Point(243, 127);
            this.lowercaseCheckbox.Name = "lowercaseCheckbox";
            this.lowercaseCheckbox.Size = new System.Drawing.Size(104, 24);
            this.lowercaseCheckbox.TabIndex = 19;
            this.lowercaseCheckbox.Text = "Lower case";
            this.lowercaseCheckbox.UseVisualStyleBackColor = true;
            // 
            // specialCharLabel
            // 
            this.specialCharLabel.AutoSize = true;
            this.specialCharLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.specialCharLabel.Location = new System.Drawing.Point(13, 12);
            this.specialCharLabel.Name = "specialCharLabel";
            this.specialCharLabel.Size = new System.Drawing.Size(187, 20);
            this.specialCharLabel.TabIndex = 8;
            this.specialCharLabel.Text = "Include special characters";
            // 
            // specialCharNoRadioButton
            // 
            this.specialCharNoRadioButton.AutoSize = true;
            this.specialCharNoRadioButton.Location = new System.Drawing.Point(23, 65);
            this.specialCharNoRadioButton.Name = "specialCharNoRadioButton";
            this.specialCharNoRadioButton.Size = new System.Drawing.Size(50, 24);
            this.specialCharNoRadioButton.TabIndex = 7;
            this.specialCharNoRadioButton.Text = "No";
            this.specialCharNoRadioButton.UseVisualStyleBackColor = true;
            // 
            // specialCharYesRadioButton
            // 
            this.specialCharYesRadioButton.AutoSize = true;
            this.specialCharYesRadioButton.Checked = true;
            this.specialCharYesRadioButton.Location = new System.Drawing.Point(23, 35);
            this.specialCharYesRadioButton.Name = "specialCharYesRadioButton";
            this.specialCharYesRadioButton.Size = new System.Drawing.Size(51, 24);
            this.specialCharYesRadioButton.TabIndex = 6;
            this.specialCharYesRadioButton.TabStop = true;
            this.specialCharYesRadioButton.Text = "Yes";
            this.specialCharYesRadioButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.specialCharLabel);
            this.panel1.Controls.Add(this.specialCharNoRadioButton);
            this.panel1.Controls.Add(this.specialCharYesRadioButton);
            this.panel1.Location = new System.Drawing.Point(344, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 104);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numberLabel);
            this.panel2.Controls.Add(this.numberYesRadioButton);
            this.panel2.Controls.Add(this.numberNoRadioButton);
            this.panel2.Location = new System.Drawing.Point(400, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 104);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ambiguousCharLabel);
            this.panel3.Controls.Add(this.ambigCharYesRadioButton);
            this.panel3.Controls.Add(this.ambigCharNoRadioButton);
            this.panel3.Location = new System.Drawing.Point(73, 180);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(234, 97);
            this.panel3.TabIndex = 23;
            // 
            // PasswordGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 361);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lowercaseCheckbox);
            this.Controls.Add(this.uppercaseCheckbox);
            this.Controls.Add(this.charCasingLabel);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.passSpecificationsLabel);
            this.Controls.Add(this.passLenghtLabel);
            this.Controls.Add(this.passLengthController);
            this.Name = "PasswordGeneratorForm";
            this.Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.passLengthController)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown passLengthController;
        private System.Windows.Forms.Label passLenghtLabel;
        private System.Windows.Forms.Label passSpecificationsLabel;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.RadioButton numberNoRadioButton;
        private System.Windows.Forms.RadioButton numberYesRadioButton;
        private System.Windows.Forms.Label ambiguousCharLabel;
        private System.Windows.Forms.RadioButton ambigCharNoRadioButton;
        private System.Windows.Forms.RadioButton ambigCharYesRadioButton;
        private System.Windows.Forms.Label charCasingLabel;
        private System.Windows.Forms.CheckBox uppercaseCheckbox;
        private System.Windows.Forms.CheckBox lowercaseCheckbox;
        private System.Windows.Forms.Label specialCharLabel;
        private System.Windows.Forms.RadioButton specialCharNoRadioButton;
        private System.Windows.Forms.RadioButton specialCharYesRadioButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}