namespace MobileBankApp.Forms
{
    partial class ChangePasswordForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.switchCardLabel = new System.Windows.Forms.Label();
            this.changeCloseButton = new System.Windows.Forms.Button();
            this.changePasswordTextBox = new System.Windows.Forms.TextBox();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "New password:";
            // 
            // switchCardLabel
            // 
            this.switchCardLabel.AutoSize = true;
            this.switchCardLabel.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchCardLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.switchCardLabel.Location = new System.Drawing.Point(143, 16);
            this.switchCardLabel.Name = "switchCardLabel";
            this.switchCardLabel.Size = new System.Drawing.Size(187, 21);
            this.switchCardLabel.TabIndex = 44;
            this.switchCardLabel.Text = "Change your password";
            // 
            // changeCloseButton
            // 
            this.changeCloseButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.changeCloseButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeCloseButton.ForeColor = System.Drawing.Color.White;
            this.changeCloseButton.Location = new System.Drawing.Point(427, 12);
            this.changeCloseButton.Name = "changeCloseButton";
            this.changeCloseButton.Size = new System.Drawing.Size(25, 25);
            this.changeCloseButton.TabIndex = 43;
            this.changeCloseButton.Text = "X";
            this.changeCloseButton.UseVisualStyleBackColor = false;
            this.changeCloseButton.Click += new System.EventHandler(this.changeCloseButton_Click);
            // 
            // changePasswordTextBox
            // 
            this.changePasswordTextBox.Location = new System.Drawing.Point(15, 93);
            this.changePasswordTextBox.Name = "changePasswordTextBox";
            this.changePasswordTextBox.Size = new System.Drawing.Size(206, 20);
            this.changePasswordTextBox.TabIndex = 42;
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.changePasswordButton.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordButton.ForeColor = System.Drawing.SystemColors.Window;
            this.changePasswordButton.Location = new System.Drawing.Point(147, 154);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(168, 29);
            this.changePasswordButton.TabIndex = 41;
            this.changePasswordButton.Text = "Change";
            this.changePasswordButton.UseVisualStyleBackColor = false;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(243, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 47;
            this.label2.Text = "Confirm:";
            // 
            // confirmTextBox
            // 
            this.confirmTextBox.Location = new System.Drawing.Point(246, 93);
            this.confirmTextBox.Name = "confirmTextBox";
            this.confirmTextBox.Size = new System.Drawing.Size(206, 20);
            this.confirmTextBox.TabIndex = 46;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 194);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.confirmTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.switchCardLabel);
            this.Controls.Add(this.changeCloseButton);
            this.Controls.Add(this.changePasswordTextBox);
            this.Controls.Add(this.changePasswordButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label switchCardLabel;
        private System.Windows.Forms.Button changeCloseButton;
        private System.Windows.Forms.TextBox changePasswordTextBox;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox confirmTextBox;
    }
}