namespace MobileBankApp.Forms
{
    partial class ChangeNumberForm
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
            this.changeNumberButton = new System.Windows.Forms.Button();
            this.changeNumberTextBox = new System.Windows.Forms.TextBox();
            this.changeCloseButton = new System.Windows.Forms.Button();
            this.switchCardLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // changeNumberButton
            // 
            this.changeNumberButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.changeNumberButton.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeNumberButton.ForeColor = System.Drawing.SystemColors.Window;
            this.changeNumberButton.Location = new System.Drawing.Point(145, 153);
            this.changeNumberButton.Name = "changeNumberButton";
            this.changeNumberButton.Size = new System.Drawing.Size(168, 29);
            this.changeNumberButton.TabIndex = 31;
            this.changeNumberButton.Text = "Change";
            this.changeNumberButton.UseVisualStyleBackColor = false;
            this.changeNumberButton.Click += new System.EventHandler(this.changeNumberButton_Click);
            // 
            // changeNumberTextBox
            // 
            this.changeNumberTextBox.Location = new System.Drawing.Point(121, 90);
            this.changeNumberTextBox.Name = "changeNumberTextBox";
            this.changeNumberTextBox.Size = new System.Drawing.Size(226, 20);
            this.changeNumberTextBox.TabIndex = 32;
            // 
            // changeCloseButton
            // 
            this.changeCloseButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.changeCloseButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeCloseButton.ForeColor = System.Drawing.Color.White;
            this.changeCloseButton.Location = new System.Drawing.Point(427, 12);
            this.changeCloseButton.Name = "changeCloseButton";
            this.changeCloseButton.Size = new System.Drawing.Size(25, 25);
            this.changeCloseButton.TabIndex = 33;
            this.changeCloseButton.Text = "X";
            this.changeCloseButton.UseVisualStyleBackColor = false;
            this.changeCloseButton.Click += new System.EventHandler(this.changeCloseButton_Click);
            // 
            // switchCardLabel
            // 
            this.switchCardLabel.AutoSize = true;
            this.switchCardLabel.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchCardLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.switchCardLabel.Location = new System.Drawing.Point(117, 16);
            this.switchCardLabel.Name = "switchCardLabel";
            this.switchCardLabel.Size = new System.Drawing.Size(230, 21);
            this.switchCardLabel.TabIndex = 34;
            this.switchCardLabel.Text = "Change your phone number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(164, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "New phone number: ";
            // 
            // ChangeNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 194);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.switchCardLabel);
            this.Controls.Add(this.changeCloseButton);
            this.Controls.Add(this.changeNumberTextBox);
            this.Controls.Add(this.changeNumberButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeNumberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeNumberForm";
            this.Load += new System.EventHandler(this.ChangeNumberForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeNumberButton;
        private System.Windows.Forms.TextBox changeNumberTextBox;
        private System.Windows.Forms.Button changeCloseButton;
        private System.Windows.Forms.Label switchCardLabel;
        private System.Windows.Forms.Label label1;
    }
}