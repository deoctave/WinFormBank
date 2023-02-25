namespace MobileBankApp.Forms
{
    partial class TransactionHistoryForm
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
            this.switchCardLabel = new System.Windows.Forms.Label();
            this.transacCloseButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Destination = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // switchCardLabel
            // 
            this.switchCardLabel.AutoSize = true;
            this.switchCardLabel.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchCardLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.switchCardLabel.Location = new System.Drawing.Point(7, 62);
            this.switchCardLabel.Name = "switchCardLabel";
            this.switchCardLabel.Size = new System.Drawing.Size(214, 30);
            this.switchCardLabel.TabIndex = 29;
            this.switchCardLabel.Text = "Transactions history";
            // 
            // transacCloseButton
            // 
            this.transacCloseButton.BackColor = System.Drawing.Color.White;
            this.transacCloseButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transacCloseButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.transacCloseButton.Location = new System.Drawing.Point(658, 12);
            this.transacCloseButton.Name = "transacCloseButton";
            this.transacCloseButton.Size = new System.Drawing.Size(25, 25);
            this.transacCloseButton.TabIndex = 26;
            this.transacCloseButton.Text = "X";
            this.transacCloseButton.UseVisualStyleBackColor = false;
            this.transacCloseButton.Click += new System.EventHandler(this.transacCloseButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.transacCloseButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 49);
            this.panel1.TabIndex = 30;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Type,
            this.Destination,
            this.Date,
            this.Number,
            this.Amount});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 104);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(671, 357);
            this.listView1.TabIndex = 31;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 106;
            // 
            // Destination
            // 
            this.Destination.Text = "Destination";
            this.Destination.Width = 116;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 125;
            // 
            // Number
            // 
            this.Number.Text = "Number";
            this.Number.Width = 111;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.Width = 102;
            // 
            // TransactionHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 473);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.switchCardLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransactionHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransactionHistoryForm";
            this.Load += new System.EventHandler(this.TransactionHistoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label switchCardLabel;
        private System.Windows.Forms.Button transacCloseButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Destination;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader Amount;
    }
}