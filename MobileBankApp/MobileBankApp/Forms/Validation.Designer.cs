namespace MobileBankApp
{
    partial class Validation
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
            this.pinValidNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.validationCloseButton = new System.Windows.Forms.Button();
            this.okValidationButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pinValidNumUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pinValidNumUpDown
            // 
            this.pinValidNumUpDown.Location = new System.Drawing.Point(17, 91);
            this.pinValidNumUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.pinValidNumUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.pinValidNumUpDown.Name = "pinValidNumUpDown";
            this.pinValidNumUpDown.Size = new System.Drawing.Size(235, 20);
            this.pinValidNumUpDown.TabIndex = 44;
            this.pinValidNumUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(12, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 30);
            this.label4.TabIndex = 43;
            this.label4.Text = "PIN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.validationCloseButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 46);
            this.panel1.TabIndex = 45;
            // 
            // validationCloseButton
            // 
            this.validationCloseButton.BackColor = System.Drawing.Color.White;
            this.validationCloseButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validationCloseButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.validationCloseButton.Location = new System.Drawing.Point(234, 12);
            this.validationCloseButton.Name = "validationCloseButton";
            this.validationCloseButton.Size = new System.Drawing.Size(25, 25);
            this.validationCloseButton.TabIndex = 26;
            this.validationCloseButton.Text = "X";
            this.validationCloseButton.UseVisualStyleBackColor = false;
            this.validationCloseButton.Click += new System.EventHandler(this.validationCloseButton_Click);
            // 
            // okValidationButton
            // 
            this.okValidationButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.okValidationButton.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okValidationButton.ForeColor = System.Drawing.Color.White;
            this.okValidationButton.Location = new System.Drawing.Point(89, 136);
            this.okValidationButton.Name = "okValidationButton";
            this.okValidationButton.Size = new System.Drawing.Size(89, 34);
            this.okValidationButton.TabIndex = 46;
            this.okValidationButton.Text = "OK";
            this.okValidationButton.UseVisualStyleBackColor = false;
            this.okValidationButton.Click += new System.EventHandler(this.okValidationButton_Click);
            // 
            // Validation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 182);
            this.Controls.Add(this.okValidationButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pinValidNumUpDown);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Validation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validation";
            this.Load += new System.EventHandler(this.Validation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pinValidNumUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown pinValidNumUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button validationCloseButton;
        private System.Windows.Forms.Button okValidationButton;
    }
}