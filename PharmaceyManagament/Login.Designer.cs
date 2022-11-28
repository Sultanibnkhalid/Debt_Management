namespace PharmaceyManagament
{
    partial class Login
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
            this.lblForgetPassword = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbUserName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblErrors = new System.Windows.Forms.Label();
            this.btnLogoin = new System.Windows.Forms.Button();
            this.pbHidePassWord = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbHidePassWord)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "كلمة المرور";
            // 
            // lblForgetPassword
            // 
            this.lblForgetPassword.AutoSize = true;
            this.lblForgetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgetPassword.ForeColor = System.Drawing.Color.Blue;
            this.lblForgetPassword.Location = new System.Drawing.Point(319, 255);
            this.lblForgetPassword.Name = "lblForgetPassword";
            this.lblForgetPassword.Size = new System.Drawing.Size(90, 17);
            this.lblForgetPassword.TabIndex = 4;
            this.lblForgetPassword.Text = "نسيت كلمة المرور";
            this.lblForgetPassword.Click += new System.EventHandler(this.lblForgetPassword_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "الاسم";
            // 
            // cbUserName
            // 
            this.cbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUserName.FormattingEnabled = true;
            this.cbUserName.Location = new System.Drawing.Point(99, 136);
            this.cbUserName.Name = "cbUserName";
            this.cbUserName.Size = new System.Drawing.Size(322, 33);
            this.cbUserName.TabIndex = 1;
            this.cbUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbUserName_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(204, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "تسجيل الدخول";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(109, 209);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '#';
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassword.Size = new System.Drawing.Size(312, 31);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "00000000";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(1, 568);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(158, 42);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "خروج وانهاء";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblErrors
            // 
            this.lblErrors.AutoSize = true;
            this.lblErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrors.Location = new System.Drawing.Point(167, 243);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(18, 25);
            this.lblErrors.TabIndex = 6;
            this.lblErrors.Text = " ";
            // 
            // btnLogoin
            // 
            this.btnLogoin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoin.Image = global::PharmaceyManagament.Properties.Resources.icons8_left_48px;
            this.btnLogoin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogoin.Location = new System.Drawing.Point(172, 326);
            this.btnLogoin.Name = "btnLogoin";
            this.btnLogoin.Size = new System.Drawing.Size(201, 50);
            this.btnLogoin.TabIndex = 3;
            this.btnLogoin.Text = "دخول";
            this.btnLogoin.UseVisualStyleBackColor = true;
            this.btnLogoin.Click += new System.EventHandler(this.btnLogoin_Click);
            this.btnLogoin.Enter += new System.EventHandler(this.btnLogoin_Enter);
            this.btnLogoin.Leave += new System.EventHandler(this.btnLogoin_Leave);
            this.btnLogoin.MouseLeave += new System.EventHandler(this.btnLogoin_Leave);
            this.btnLogoin.MouseHover += new System.EventHandler(this.btnLogoin_Enter);
            // 
            // pbHidePassWord
            // 
            this.pbHidePassWord.Location = new System.Drawing.Point(443, 215);
            this.pbHidePassWord.Name = "pbHidePassWord";
            this.pbHidePassWord.Size = new System.Drawing.Size(31, 17);
            this.pbHidePassWord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHidePassWord.TabIndex = 3;
            this.pbHidePassWord.TabStop = false;
            this.pbHidePassWord.Click += new System.EventHandler(this.pbHidePassWord_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(529, 610);
            this.Controls.Add(this.lblErrors);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogoin);
            this.Controls.Add(this.pbHidePassWord);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.cbUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblForgetPassword);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(529, 610);
            this.MinimumSize = new System.Drawing.Size(529, 610);
            this.Name = "Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHidePassWord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox pbHidePassWord;
        private System.Windows.Forms.Button btnLogoin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblErrors;
        private System.Windows.Forms.Label lblForgetPassword;
    }
}