namespace MobileBankApp
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.userCloseButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.changePhoneButton = new System.Windows.Forms.Button();
            this.switchCardLabel = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.profilePhoneLabel = new System.Windows.Forms.Label();
            this.profileEmailLabel = new System.Windows.Forms.Label();
            this.changeEmailButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // userCloseButton
            // 
            this.userCloseButton.BackColor = System.Drawing.Color.White;
            this.userCloseButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userCloseButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.userCloseButton.Location = new System.Drawing.Point(665, 12);
            this.userCloseButton.Name = "userCloseButton";
            this.userCloseButton.Size = new System.Drawing.Size(25, 25);
            this.userCloseButton.TabIndex = 27;
            this.userCloseButton.Text = "X";
            this.userCloseButton.UseVisualStyleBackColor = false;
            this.userCloseButton.Click += new System.EventHandler(this.userCloseButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.userCloseButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 51);
            this.panel1.TabIndex = 28;
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.BackColor = System.Drawing.Color.White;
            this.changePasswordButton.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.changePasswordButton.Location = new System.Drawing.Point(444, 162);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(226, 30);
            this.changePasswordButton.TabIndex = 31;
            this.changePasswordButton.Text = "Change password";
            this.changePasswordButton.UseVisualStyleBackColor = false;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // changePhoneButton
            // 
            this.changePhoneButton.BackColor = System.Drawing.Color.White;
            this.changePhoneButton.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePhoneButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.changePhoneButton.Location = new System.Drawing.Point(444, 223);
            this.changePhoneButton.Name = "changePhoneButton";
            this.changePhoneButton.Size = new System.Drawing.Size(226, 30);
            this.changePhoneButton.TabIndex = 32;
            this.changePhoneButton.Text = "Change phone number";
            this.changePhoneButton.UseVisualStyleBackColor = false;
            this.changePhoneButton.Click += new System.EventHandler(this.changePhoneButton_Click);
            // 
            // switchCardLabel
            // 
            this.switchCardLabel.AutoSize = true;
            this.switchCardLabel.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchCardLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.switchCardLabel.Location = new System.Drawing.Point(50, 77);
            this.switchCardLabel.Name = "switchCardLabel";
            this.switchCardLabel.Size = new System.Drawing.Size(131, 30);
            this.switchCardLabel.TabIndex = 33;
            this.switchCardLabel.Text = "User Profile";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.fullNameLabel.Location = new System.Drawing.Point(91, 167);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(0, 21);
            this.fullNameLabel.TabIndex = 34;
            // 
            // profilePhoneLabel
            // 
            this.profilePhoneLabel.AutoSize = true;
            this.profilePhoneLabel.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilePhoneLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.profilePhoneLabel.Location = new System.Drawing.Point(91, 228);
            this.profilePhoneLabel.Name = "profilePhoneLabel";
            this.profilePhoneLabel.Size = new System.Drawing.Size(0, 21);
            this.profilePhoneLabel.TabIndex = 35;
            // 
            // profileEmailLabel
            // 
            this.profileEmailLabel.AutoSize = true;
            this.profileEmailLabel.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileEmailLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.profileEmailLabel.Location = new System.Drawing.Point(91, 286);
            this.profileEmailLabel.Name = "profileEmailLabel";
            this.profileEmailLabel.Size = new System.Drawing.Size(0, 21);
            this.profileEmailLabel.TabIndex = 36;
            // 
            // changeEmailButton
            // 
            this.changeEmailButton.BackColor = System.Drawing.Color.White;
            this.changeEmailButton.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeEmailButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.changeEmailButton.Location = new System.Drawing.Point(444, 281);
            this.changeEmailButton.Name = "changeEmailButton";
            this.changeEmailButton.Size = new System.Drawing.Size(226, 30);
            this.changeEmailButton.TabIndex = 37;
            this.changeEmailButton.Text = "Change email adress";
            this.changeEmailButton.UseVisualStyleBackColor = false;
            this.changeEmailButton.Click += new System.EventHandler(this.changeEmailButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(55, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(55, 223);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(55, 281);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.refreshButton.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.ForeColor = System.Drawing.Color.White;
            this.refreshButton.Location = new System.Drawing.Point(564, 80);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(106, 30);
            this.refreshButton.TabIndex = 41;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 391);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.changeEmailButton);
            this.Controls.Add(this.profileEmailLabel);
            this.Controls.Add(this.profilePhoneLabel);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.switchCardLabel);
            this.Controls.Add(this.changePhoneButton);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button userCloseButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.Button changePhoneButton;
        private System.Windows.Forms.Label switchCardLabel;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label profilePhoneLabel;
        private System.Windows.Forms.Label profileEmailLabel;
        private System.Windows.Forms.Button changeEmailButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button refreshButton;
    }
}