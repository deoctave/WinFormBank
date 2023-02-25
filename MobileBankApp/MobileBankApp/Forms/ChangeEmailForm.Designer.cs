namespace MobileBankApp.Forms
{
    partial class ChangeEmailForm
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
            this.changeEmailTextBox = new System.Windows.Forms.TextBox();
            this.changeEmailButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(180, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "New email adress: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // switchCardLabel
            // 
            this.switchCardLabel.AutoSize = true;
            this.switchCardLabel.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchCardLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.switchCardLabel.Location = new System.Drawing.Point(131, 16);
            this.switchCardLabel.Name = "switchCardLabel";
            this.switchCardLabel.Size = new System.Drawing.Size(210, 21);
            this.switchCardLabel.TabIndex = 39;
            this.switchCardLabel.Text = "Change your email adress";
            // 
            // changeCloseButton
            // 
            this.changeCloseButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.changeCloseButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeCloseButton.ForeColor = System.Drawing.Color.White;
            this.changeCloseButton.Location = new System.Drawing.Point(427, 12);
            this.changeCloseButton.Name = "changeCloseButton";
            this.changeCloseButton.Size = new System.Drawing.Size(25, 25);
            this.changeCloseButton.TabIndex = 38;
            this.changeCloseButton.Text = "X";
            this.changeCloseButton.UseVisualStyleBackColor = false;
            this.changeCloseButton.Click += new System.EventHandler(this.changeCloseButton_Click);
            // 
            // changeEmailTextBox
            // 
            this.changeEmailTextBox.Location = new System.Drawing.Point(135, 91);
            this.changeEmailTextBox.Name = "changeEmailTextBox";
            this.changeEmailTextBox.Size = new System.Drawing.Size(206, 20);
            this.changeEmailTextBox.TabIndex = 37;
            // 
            // changeEmailButton
            // 
            this.changeEmailButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.changeEmailButton.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeEmailButton.ForeColor = System.Drawing.SystemColors.Window;
            this.changeEmailButton.Location = new System.Drawing.Point(153, 153);
            this.changeEmailButton.Name = "changeEmailButton";
            this.changeEmailButton.Size = new System.Drawing.Size(168, 29);
            this.changeEmailButton.TabIndex = 36;
            this.changeEmailButton.Text = "Change";
            this.changeEmailButton.UseVisualStyleBackColor = false;
            this.changeEmailButton.Click += new System.EventHandler(this.changeEmailButton_Click);
            // 
            // ChangeEmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 194);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.switchCardLabel);
            this.Controls.Add(this.changeCloseButton);
            this.Controls.Add(this.changeEmailTextBox);
            this.Controls.Add(this.changeEmailButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeEmailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeEmailForm";
            this.Load += new System.EventHandler(this.ChangeEmailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label switchCardLabel;
        private System.Windows.Forms.Button changeCloseButton;
        private System.Windows.Forms.TextBox changeEmailTextBox;
        private System.Windows.Forms.Button changeEmailButton;
    }
}