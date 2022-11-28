namespace PharmaceyManagament
{
    partial class Registring
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRetypePassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtnManager = new System.Windows.Forms.RadioButton();
            this.rbtnSaler = new System.Windows.Forms.RadioButton();
            this.lblStrongPassword = new System.Windows.Forms.Label();
            this.lblEqualPassword = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFamele = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.btnAlter = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btAllUsers = new System.Windows.Forms.Button();
            this.txtAdrdress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pbGoodPaswod = new System.Windows.Forms.PictureBox();
            this.pbHideAndShowPasword = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pbAppPic = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGoodPaswod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHideAndShowPasword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppPic)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(193, 91);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(345, 29);
            this.txtName.TabIndex = 0;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            this.txtName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtName_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "الاسم";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(193, 138);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(345, 29);
            this.txtPhone.TabIndex = 1;
            this.txtPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhone_KeyDown_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "التلفون";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(193, 232);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassword.Size = new System.Drawing.Size(345, 29);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WordWrap = false;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "كلمة المرور";
            // 
            // txtRetypePassword
            // 
            this.txtRetypePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetypePassword.Location = new System.Drawing.Point(192, 279);
            this.txtRetypePassword.Name = "txtRetypePassword";
            this.txtRetypePassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRetypePassword.Size = new System.Drawing.Size(345, 29);
            this.txtRetypePassword.TabIndex = 4;
            this.txtRetypePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRetypePassword.UseSystemPasswordChar = true;
            this.txtRetypePassword.WordWrap = false;
            this.txtRetypePassword.TextChanged += new System.EventHandler(this.txtRetypePassword_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(77, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = "اعد كلمة المرور";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(188, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "صلاحيات المستخدم";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // rbtnManager
            // 
            this.rbtnManager.AutoSize = true;
            this.rbtnManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnManager.Location = new System.Drawing.Point(213, 479);
            this.rbtnManager.Name = "rbtnManager";
            this.rbtnManager.Size = new System.Drawing.Size(55, 28);
            this.rbtnManager.TabIndex = 6;
            this.rbtnManager.TabStop = true;
            this.rbtnManager.Text = "مدير";
            this.rbtnManager.UseVisualStyleBackColor = true;
            // 
            // rbtnSaler
            // 
            this.rbtnSaler.AutoSize = true;
            this.rbtnSaler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSaler.Location = new System.Drawing.Point(353, 479);
            this.rbtnSaler.Name = "rbtnSaler";
            this.rbtnSaler.Size = new System.Drawing.Size(72, 28);
            this.rbtnSaler.TabIndex = 7;
            this.rbtnSaler.TabStop = true;
            this.rbtnSaler.Text = "مستخدم";
            this.rbtnSaler.UseVisualStyleBackColor = true;
            // 
            // lblStrongPassword
            // 
            this.lblStrongPassword.AutoSize = true;
            this.lblStrongPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrongPassword.Location = new System.Drawing.Point(346, 321);
            this.lblStrongPassword.Name = "lblStrongPassword";
            this.lblStrongPassword.Size = new System.Drawing.Size(24, 24);
            this.lblStrongPassword.TabIndex = 15;
            this.lblStrongPassword.Text = "la";
            // 
            // lblEqualPassword
            // 
            this.lblEqualPassword.AutoSize = true;
            this.lblEqualPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqualPassword.Location = new System.Drawing.Point(393, 435);
            this.lblEqualPassword.Name = "lblEqualPassword";
            this.lblEqualPassword.Size = new System.Drawing.Size(60, 24);
            this.lblEqualPassword.TabIndex = 14;
            this.lblEqualPassword.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(307, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "بيانات المستخدم";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnMale);
            this.groupBox1.Controls.Add(this.rbtnFamele);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(202, 343);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 70);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "نوع";
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(73, 19);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtnMale.Size = new System.Drawing.Size(50, 28);
            this.rbtnMale.TabIndex = 0;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "ذكر";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFamele
            // 
            this.rbtnFamele.AutoSize = true;
            this.rbtnFamele.Location = new System.Drawing.Point(6, 19);
            this.rbtnFamele.Name = "rbtnFamele";
            this.rbtnFamele.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtnFamele.Size = new System.Drawing.Size(53, 28);
            this.rbtnFamele.TabIndex = 1;
            this.rbtnFamele.TabStop = true;
            this.rbtnFamele.Text = "انثى";
            this.rbtnFamele.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblCurrentUser);
            this.panel1.Controls.Add(this.btnAlter);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(754, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 649);
            this.panel1.TabIndex = 12;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(71, 456);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 13);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "label7";
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Location = new System.Drawing.Point(253, 456);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(35, 13);
            this.lblCurrentUser.TabIndex = 1;
            this.lblCurrentUser.Text = "label7";
            // 
            // btnAlter
            // 
            this.btnAlter.Location = new System.Drawing.Point(449, 451);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(75, 23);
            this.btnAlter.TabIndex = 1;
            this.btnAlter.Text = "تعديل";
            this.btnAlter.UseVisualStyleBackColor = true;
            this.btnAlter.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 427);
            this.panel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(556, 427);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btAllUsers
            // 
            this.btAllUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAllUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAllUsers.Location = new System.Drawing.Point(584, 588);
            this.btAllUsers.Name = "btAllUsers";
            this.btAllUsers.Size = new System.Drawing.Size(164, 60);
            this.btAllUsers.TabIndex = 10;
            this.btAllUsers.Text = "كل المستخدمين";
            this.btAllUsers.UseVisualStyleBackColor = true;
            this.btAllUsers.Click += new System.EventHandler(this.btAllUsers_Click);
            this.btAllUsers.Enter += new System.EventHandler(this.btnAdd_Enter);
            this.btAllUsers.Leave += new System.EventHandler(this.btnAdd_Leave);
            this.btAllUsers.MouseEnter += new System.EventHandler(this.btnAdd_Enter);
            this.btAllUsers.MouseLeave += new System.EventHandler(this.btnAdd_Leave);
            // 
            // txtAdrdress
            // 
            this.txtAdrdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdrdress.Location = new System.Drawing.Point(192, 185);
            this.txtAdrdress.Name = "txtAdrdress";
            this.txtAdrdress.Size = new System.Drawing.Size(345, 29);
            this.txtAdrdress.TabIndex = 2;
            this.txtAdrdress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAdrdress_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(77, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "العنوان";
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::PharmaceyManagament.Properties.Resources.icons8_denied_48px;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(415, 551);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 64);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "الغاء";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.Enter += new System.EventHandler(this.btnAdd_Enter);
            this.btnCancel.Leave += new System.EventHandler(this.btnAdd_Leave);
            this.btnCancel.MouseEnter += new System.EventHandler(this.btnAdd_Enter);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnAdd_Leave);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::PharmaceyManagament.Properties.Resources.icons8_add_user_male_48px;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(192, 551);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 64);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "حفظ";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.Enter += new System.EventHandler(this.btnAdd_Enter);
            this.btnAdd.Leave += new System.EventHandler(this.btnAdd_Leave);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_Leave);
            this.btnAdd.MouseHover += new System.EventHandler(this.btnAdd_Enter);
            // 
            // pbGoodPaswod
            // 
            this.pbGoodPaswod.Image = global::PharmaceyManagament.Properties.Resources.icons8_good_pincode_48px;
            this.pbGoodPaswod.Location = new System.Drawing.Point(568, 321);
            this.pbGoodPaswod.Name = "pbGoodPaswod";
            this.pbGoodPaswod.Size = new System.Drawing.Size(30, 24);
            this.pbGoodPaswod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGoodPaswod.TabIndex = 6;
            this.pbGoodPaswod.TabStop = false;
            // 
            // pbHideAndShowPasword
            // 
            this.pbHideAndShowPasword.Location = new System.Drawing.Point(571, 238);
            this.pbHideAndShowPasword.Name = "pbHideAndShowPasword";
            this.pbHideAndShowPasword.Size = new System.Drawing.Size(27, 24);
            this.pbHideAndShowPasword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHideAndShowPasword.TabIndex = 5;
            this.pbHideAndShowPasword.TabStop = false;
            this.pbHideAndShowPasword.Click += new System.EventHandler(this.pbHideAndShowPasword_Click);
            // 
            // pbClose
            // 
            this.pbClose.Image = global::PharmaceyManagament.Properties.Resources.icons8_cancel_48px;
            this.pbClose.Location = new System.Drawing.Point(2, 3);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(48, 48);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbClose.TabIndex = 0;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // pbAppPic
            // 
            this.pbAppPic.Location = new System.Drawing.Point(763, 67);
            this.pbAppPic.Name = "pbAppPic";
            this.pbAppPic.Size = new System.Drawing.Size(442, 446);
            this.pbAppPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAppPic.TabIndex = 15;
            this.pbAppPic.TabStop = false;
            // 
            // Registring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1310, 649);
            this.Controls.Add(this.pbAppPic);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAdrdress);
            this.Controls.Add(this.btAllUsers);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblEqualPassword);
            this.Controls.Add(this.lblStrongPassword);
            this.Controls.Add(this.pbGoodPaswod);
            this.Controls.Add(this.pbHideAndShowPasword);
            this.Controls.Add(this.rbtnSaler);
            this.Controls.Add(this.rbtnManager);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRetypePassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.pbClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1310, 649);
            this.MinimumSize = new System.Drawing.Size(1310, 649);
            this.Name = "Registring";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الحساب";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registring_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registring_FormClosed);
            this.Load += new System.EventHandler(this.Registring_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGoodPaswod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHideAndShowPasword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRetypePassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtnManager;
        private System.Windows.Forms.RadioButton rbtnSaler;
        private System.Windows.Forms.PictureBox pbHideAndShowPasword;
        private System.Windows.Forms.PictureBox pbGoodPaswod;
        private System.Windows.Forms.Label lblStrongPassword;
        private System.Windows.Forms.Label lblEqualPassword;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFamele;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtAdrdress;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button btAllUsers;
        private System.Windows.Forms.PictureBox pbAppPic;
    }
}