namespace MobileBankApp.Forms
{
    partial class CommunalPaymets
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
            this.label6 = new System.Windows.Forms.Label();
            this.operatorComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fromCardCvvTextBox = new System.Windows.Forms.TextBox();
            this.fromCardValidTextBox = new System.Windows.Forms.TextBox();
            this.fromCardNumberTextBox = new System.Windows.Forms.TextBox();
            this.fromCardLabel = new System.Windows.Forms.Label();
            this.topUpButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(54, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 60;
            this.label6.Text = "Service type";
            // 
            // operatorComboBox
            // 
            this.operatorComboBox.FormattingEnabled = true;
            this.operatorComboBox.Items.AddRange(new object[] {
            "Gas supply",
            "Water supply",
            "Energy supply",
            "Any internet operator"});
            this.operatorComboBox.Location = new System.Drawing.Point(59, 84);
            this.operatorComboBox.Name = "operatorComboBox";
            this.operatorComboBox.Size = new System.Drawing.Size(144, 21);
            this.operatorComboBox.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(234, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 57;
            this.label3.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(54, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 30);
            this.label2.TabIndex = 58;
            this.label2.Text = "Account number";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(239, 84);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(144, 20);
            this.amountTextBox.TabIndex = 51;
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(59, 166);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(322, 20);
            this.numberTextBox.TabIndex = 52;
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
            this.panel1.Location = new System.Drawing.Point(40, 279);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 198);
            this.panel1.TabIndex = 54;
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
            // fromCardCvvTextBox
            // 
            this.fromCardCvvTextBox.Location = new System.Drawing.Point(242, 149);
            this.fromCardCvvTextBox.Name = "fromCardCvvTextBox";
            this.fromCardCvvTextBox.Size = new System.Drawing.Size(38, 20);
            this.fromCardCvvTextBox.TabIndex = 2;
            // 
            // fromCardValidTextBox
            // 
            this.fromCardValidTextBox.Location = new System.Drawing.Point(19, 149);
            this.fromCardValidTextBox.Name = "fromCardValidTextBox";
            this.fromCardValidTextBox.Size = new System.Drawing.Size(85, 20);
            this.fromCardValidTextBox.TabIndex = 1;
            // 
            // fromCardNumberTextBox
            // 
            this.fromCardNumberTextBox.Location = new System.Drawing.Point(19, 42);
            this.fromCardNumberTextBox.Name = "fromCardNumberTextBox";
            this.fromCardNumberTextBox.Size = new System.Drawing.Size(322, 20);
            this.fromCardNumberTextBox.TabIndex = 0;
            // 
            // fromCardLabel
            // 
            this.fromCardLabel.AutoSize = true;
            this.fromCardLabel.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromCardLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.fromCardLabel.Location = new System.Drawing.Point(35, 232);
            this.fromCardLabel.Name = "fromCardLabel";
            this.fromCardLabel.Size = new System.Drawing.Size(69, 30);
            this.fromCardLabel.TabIndex = 55;
            this.fromCardLabel.Text = "From:";
            // 
            // topUpButton
            // 
            this.topUpButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.topUpButton.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topUpButton.ForeColor = System.Drawing.SystemColors.Window;
            this.topUpButton.Location = new System.Drawing.Point(40, 511);
            this.topUpButton.Name = "topUpButton";
            this.topUpButton.Size = new System.Drawing.Size(407, 38);
            this.topUpButton.TabIndex = 56;
            this.topUpButton.Text = "Pay";
            this.topUpButton.UseVisualStyleBackColor = false;
            this.topUpButton.Click += new System.EventHandler(this.topUpButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.CloseButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(449, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(25, 25);
            this.CloseButton.TabIndex = 53;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // CommunalPaymets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 571);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.operatorComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fromCardLabel);
            this.Controls.Add(this.topUpButton);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CommunalPaymets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CommunalPaymets";
            this.Load += new System.EventHandler(this.CommunalPaymets_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox operatorComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fromCardCvvTextBox;
        private System.Windows.Forms.TextBox fromCardValidTextBox;
        private System.Windows.Forms.TextBox fromCardNumberTextBox;
        private System.Windows.Forms.Label fromCardLabel;
        private System.Windows.Forms.Button topUpButton;
        private System.Windows.Forms.Button CloseButton;
    }
}