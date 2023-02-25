namespace MobileBankApp
{
    partial class AddBankCard
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addCardCloseButton = new System.Windows.Forms.Button();
            this.cardTypeComboBox = new System.Windows.Forms.ComboBox();
            this.currencyComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.paymentSystemComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pinCodeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.addCardButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pinCodeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(72, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 30);
            this.label2.TabIndex = 34;
            this.label2.Text = "Card type";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.addCardCloseButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 55);
            this.panel1.TabIndex = 35;
            // 
            // addCardCloseButton
            // 
            this.addCardCloseButton.BackColor = System.Drawing.Color.White;
            this.addCardCloseButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCardCloseButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.addCardCloseButton.Location = new System.Drawing.Point(376, 12);
            this.addCardCloseButton.Name = "addCardCloseButton";
            this.addCardCloseButton.Size = new System.Drawing.Size(25, 25);
            this.addCardCloseButton.TabIndex = 26;
            this.addCardCloseButton.Text = "X";
            this.addCardCloseButton.UseVisualStyleBackColor = false;
            this.addCardCloseButton.Click += new System.EventHandler(this.addCardCloseButton_Click);
            // 
            // cardTypeComboBox
            // 
            this.cardTypeComboBox.FormattingEnabled = true;
            this.cardTypeComboBox.Items.AddRange(new object[] {
            "Debit",
            "Credit"});
            this.cardTypeComboBox.Location = new System.Drawing.Point(77, 122);
            this.cardTypeComboBox.Name = "cardTypeComboBox";
            this.cardTypeComboBox.Size = new System.Drawing.Size(251, 21);
            this.cardTypeComboBox.TabIndex = 36;
            // 
            // currencyComboBox
            // 
            this.currencyComboBox.FormattingEnabled = true;
            this.currencyComboBox.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "RUB"});
            this.currencyComboBox.Location = new System.Drawing.Point(77, 208);
            this.currencyComboBox.Name = "currencyComboBox";
            this.currencyComboBox.Size = new System.Drawing.Size(251, 21);
            this.currencyComboBox.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(72, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 30);
            this.label1.TabIndex = 37;
            this.label1.Text = "Currency";
            // 
            // paymentSystemComboBox
            // 
            this.paymentSystemComboBox.FormattingEnabled = true;
            this.paymentSystemComboBox.Items.AddRange(new object[] {
            "Visa",
            "Mastercard"});
            this.paymentSystemComboBox.Location = new System.Drawing.Point(77, 299);
            this.paymentSystemComboBox.Name = "paymentSystemComboBox";
            this.paymentSystemComboBox.Size = new System.Drawing.Size(251, 21);
            this.paymentSystemComboBox.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(72, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 30);
            this.label3.TabIndex = 39;
            this.label3.Text = "Payment system";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(72, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 30);
            this.label4.TabIndex = 41;
            this.label4.Text = "PIN";
            // 
            // pinCodeNumericUpDown
            // 
            this.pinCodeNumericUpDown.Location = new System.Drawing.Point(77, 389);
            this.pinCodeNumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.pinCodeNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.pinCodeNumericUpDown.Name = "pinCodeNumericUpDown";
            this.pinCodeNumericUpDown.Size = new System.Drawing.Size(251, 20);
            this.pinCodeNumericUpDown.TabIndex = 42;
            this.pinCodeNumericUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // addCardButton
            // 
            this.addCardButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.addCardButton.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCardButton.ForeColor = System.Drawing.Color.White;
            this.addCardButton.Location = new System.Drawing.Point(160, 456);
            this.addCardButton.Name = "addCardButton";
            this.addCardButton.Size = new System.Drawing.Size(89, 34);
            this.addCardButton.TabIndex = 43;
            this.addCardButton.Text = "Add";
            this.addCardButton.UseVisualStyleBackColor = false;
            this.addCardButton.Click += new System.EventHandler(this.addCardButton_Click);
            // 
            // AddBankCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 548);
            this.Controls.Add(this.addCardButton);
            this.Controls.Add(this.pinCodeNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.paymentSystemComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.currencyComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cardTypeComboBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBankCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBankCard";
            this.Load += new System.EventHandler(this.AddBankCard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pinCodeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addCardCloseButton;
        private System.Windows.Forms.ComboBox cardTypeComboBox;
        private System.Windows.Forms.ComboBox currencyComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox paymentSystemComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown pinCodeNumericUpDown;
        private System.Windows.Forms.Button addCardButton;
    }
}