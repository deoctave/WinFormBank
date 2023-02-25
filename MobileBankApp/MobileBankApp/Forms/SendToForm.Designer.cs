namespace MobileBankApp.Forms
{
    partial class SendToForm
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
            this.sendToCloseButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.transferMoneyButton = new System.Windows.Forms.Button();
            this.fromCardNumberTextBox = new System.Windows.Forms.TextBox();
            this.fromCardValidTextBox = new System.Windows.Forms.TextBox();
            this.fromCardCvvTextBox = new System.Windows.Forms.TextBox();
            this.toCardNumberTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.fromCardLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendToCloseButton
            // 
            this.sendToCloseButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.sendToCloseButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendToCloseButton.ForeColor = System.Drawing.Color.White;
            this.sendToCloseButton.Location = new System.Drawing.Point(575, 12);
            this.sendToCloseButton.Name = "sendToCloseButton";
            this.sendToCloseButton.Size = new System.Drawing.Size(25, 25);
            this.sendToCloseButton.TabIndex = 27;
            this.sendToCloseButton.Text = "X";
            this.sendToCloseButton.UseVisualStyleBackColor = false;
            this.sendToCloseButton.Click += new System.EventHandler(this.sendToCloseButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.fromCardCvvTextBox);
            this.panel1.Controls.Add(this.fromCardValidTextBox);
            this.panel1.Controls.Add(this.fromCardNumberTextBox);
            this.panel1.Location = new System.Drawing.Point(53, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 220);
            this.panel1.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.amountTextBox);
            this.panel2.Controls.Add(this.toCardNumberTextBox);
            this.panel2.Location = new System.Drawing.Point(53, 319);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 157);
            this.panel2.TabIndex = 29;
            // 
            // transferMoneyButton
            // 
            this.transferMoneyButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.transferMoneyButton.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferMoneyButton.ForeColor = System.Drawing.SystemColors.Window;
            this.transferMoneyButton.Location = new System.Drawing.Point(53, 504);
            this.transferMoneyButton.Name = "transferMoneyButton";
            this.transferMoneyButton.Size = new System.Drawing.Size(500, 38);
            this.transferMoneyButton.TabIndex = 31;
            this.transferMoneyButton.Text = "Transfer";
            this.transferMoneyButton.UseVisualStyleBackColor = false;
            this.transferMoneyButton.Click += new System.EventHandler(this.transferMoneyButton_Click);
            // 
            // fromCardNumberTextBox
            // 
            this.fromCardNumberTextBox.Location = new System.Drawing.Point(19, 42);
            this.fromCardNumberTextBox.Name = "fromCardNumberTextBox";
            this.fromCardNumberTextBox.Size = new System.Drawing.Size(322, 20);
            this.fromCardNumberTextBox.TabIndex = 0;
            // 
            // fromCardValidTextBox
            // 
            this.fromCardValidTextBox.Location = new System.Drawing.Point(19, 149);
            this.fromCardValidTextBox.Name = "fromCardValidTextBox";
            this.fromCardValidTextBox.Size = new System.Drawing.Size(85, 20);
            this.fromCardValidTextBox.TabIndex = 1;
            // 
            // fromCardCvvTextBox
            // 
            this.fromCardCvvTextBox.Location = new System.Drawing.Point(242, 149);
            this.fromCardCvvTextBox.Name = "fromCardCvvTextBox";
            this.fromCardCvvTextBox.Size = new System.Drawing.Size(38, 20);
            this.fromCardCvvTextBox.TabIndex = 2;
            // 
            // toCardNumberTextBox
            // 
            this.toCardNumberTextBox.Location = new System.Drawing.Point(19, 43);
            this.toCardNumberTextBox.Name = "toCardNumberTextBox";
            this.toCardNumberTextBox.Size = new System.Drawing.Size(322, 20);
            this.toCardNumberTextBox.TabIndex = 3;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(19, 114);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(129, 20);
            this.amountTextBox.TabIndex = 3;
            // 
            // fromCardLabel
            // 
            this.fromCardLabel.AutoSize = true;
            this.fromCardLabel.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromCardLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.fromCardLabel.Location = new System.Drawing.Point(48, 13);
            this.fromCardLabel.Name = "fromCardLabel";
            this.fromCardLabel.Size = new System.Drawing.Size(69, 30);
            this.fromCardLabel.TabIndex = 32;
            this.fromCardLabel.Text = "From:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 30);
            this.label1.TabIndex = 34;
            this.label1.Text = "Card number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MidnightBlue;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(238, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 21);
            this.label5.TabIndex = 47;
            this.label5.Text = "CVV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MidnightBlue;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 46;
            this.label4.Text = "Valid Thru";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 30);
            this.label2.TabIndex = 48;
            this.label2.Text = "Card number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MidnightBlue;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 48;
            this.label3.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(48, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 30);
            this.label6.TabIndex = 33;
            this.label6.Text = "To:";
            // 
            // SendToForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 566);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fromCardLabel);
            this.Controls.Add(this.transferMoneyButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sendToCloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SendToForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SendToForm";
            this.Load += new System.EventHandler(this.SendToForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendToCloseButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox fromCardCvvTextBox;
        private System.Windows.Forms.TextBox fromCardValidTextBox;
        private System.Windows.Forms.TextBox fromCardNumberTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox toCardNumberTextBox;
        private System.Windows.Forms.Button transferMoneyButton;
        private System.Windows.Forms.Label fromCardLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}