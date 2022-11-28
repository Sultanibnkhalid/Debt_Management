namespace PharmaceyManagament.Reports
{
    partial class StoreDetails
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
            this.components = new System.ComponentModel.Container();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPharmaNme = new System.Windows.Forms.Label();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pannalss = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDrugExpDate = new System.Windows.Forms.TextBox();
            this.txtDrugSalePrice = new System.Windows.Forms.TextBox();
            this.txtDrugQuantiy = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.cbDrugCompany = new System.Windows.Forms.ComboBox();
            this.cbDrugNames = new System.Windows.Forms.ComboBox();
            this.cbDrugeType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveAlteration = new System.Windows.Forms.Button();
            this.btnSaveAndPrint = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pannalss.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblCurrentUser);
            this.panel3.Controls.Add(this.lblDate);
            this.panel3.Controls.Add(this.lblPharmaNme);
            this.panel3.Controls.Add(this.pbMinimize);
            this.panel3.Controls.Add(this.pbBack);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1296, 47);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUser.Location = new System.Drawing.Point(914, 9);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(70, 24);
            this.lblCurrentUser.TabIndex = 6;
            this.lblCurrentUser.Text = "label11";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(270, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(70, 24);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "label11";
            // 
            // lblPharmaNme
            // 
            this.lblPharmaNme.AutoSize = true;
            this.lblPharmaNme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPharmaNme.Location = new System.Drawing.Point(611, 9);
            this.lblPharmaNme.Name = "lblPharmaNme";
            this.lblPharmaNme.Size = new System.Drawing.Size(70, 24);
            this.lblPharmaNme.TabIndex = 4;
            this.lblPharmaNme.Text = "label11";
            // 
            // pbMinimize
            // 
            this.pbMinimize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbMinimize.Image = global::PharmaceyManagament.Properties.Resources.icons8_down__1_;
            this.pbMinimize.Location = new System.Drawing.Point(47, 0);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(48, 44);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMinimize.TabIndex = 3;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            // 
            // pbBack
            // 
            this.pbBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbBack.Image = global::PharmaceyManagament.Properties.Resources.icons8_delete_48px_1;
            this.pbBack.Location = new System.Drawing.Point(-1, -1);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(48, 44);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBack.TabIndex = 2;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pannalss);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1296, 583);
            this.panel1.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 310);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1296, 273);
            this.panel4.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.Aquamarine;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1296, 273);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pannalss
            // 
            this.pannalss.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.pannalss.Controls.Add(this.label5);
            this.pannalss.Controls.Add(this.txtDrugExpDate);
            this.pannalss.Controls.Add(this.txtDrugSalePrice);
            this.pannalss.Controls.Add(this.txtDrugQuantiy);
            this.pannalss.Controls.Add(this.lblError);
            this.pannalss.Controls.Add(this.cbDrugCompany);
            this.pannalss.Controls.Add(this.cbDrugNames);
            this.pannalss.Controls.Add(this.cbDrugeType);
            this.pannalss.Controls.Add(this.label8);
            this.pannalss.Controls.Add(this.label7);
            this.pannalss.Controls.Add(this.label6);
            this.pannalss.Controls.Add(this.label3);
            this.pannalss.Controls.Add(this.label2);
            this.pannalss.Controls.Add(this.label1);
            this.pannalss.Controls.Add(this.btnDelete);
            this.pannalss.Controls.Add(this.btnSaveAlteration);
            this.pannalss.Controls.Add(this.btnSaveAndPrint);
            this.pannalss.Dock = System.Windows.Forms.DockStyle.Top;
            this.pannalss.Location = new System.Drawing.Point(0, 0);
            this.pannalss.Name = "pannalss";
            this.pannalss.Size = new System.Drawing.Size(1296, 310);
            this.pannalss.TabIndex = 0;
            this.pannalss.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1199, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "كل الاصناف";
            // 
            // txtDrugExpDate
            // 
            this.txtDrugExpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrugExpDate.Location = new System.Drawing.Point(350, 141);
            this.txtDrugExpDate.Name = "txtDrugExpDate";
            this.txtDrugExpDate.Size = new System.Drawing.Size(355, 29);
            this.txtDrugExpDate.TabIndex = 5;
            this.txtDrugExpDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDrugSalePrice
            // 
            this.txtDrugSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrugSalePrice.Location = new System.Drawing.Point(350, 83);
            this.txtDrugSalePrice.Name = "txtDrugSalePrice";
            this.txtDrugSalePrice.Size = new System.Drawing.Size(355, 29);
            this.txtDrugSalePrice.TabIndex = 4;
            this.txtDrugSalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDrugSalePrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDrugQuantiy_KeyDown);
            this.txtDrugSalePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDrugQuantiy_KeyPress);
            // 
            // txtDrugQuantiy
            // 
            this.txtDrugQuantiy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrugQuantiy.Location = new System.Drawing.Point(350, 25);
            this.txtDrugQuantiy.Name = "txtDrugQuantiy";
            this.txtDrugQuantiy.Size = new System.Drawing.Size(355, 29);
            this.txtDrugQuantiy.TabIndex = 3;
            this.txtDrugQuantiy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDrugQuantiy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDrugQuantiy_KeyDown);
            this.txtDrugQuantiy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDrugQuantiy_KeyPress);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(208, 126);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(60, 24);
            this.lblError.TabIndex = 28;
            this.lblError.Text = "label5";
            // 
            // cbDrugCompany
            // 
            this.cbDrugCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDrugCompany.FormattingEnabled = true;
            this.cbDrugCompany.Location = new System.Drawing.Point(840, 137);
            this.cbDrugCompany.Name = "cbDrugCompany";
            this.cbDrugCompany.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbDrugCompany.Size = new System.Drawing.Size(354, 32);
            this.cbDrugCompany.TabIndex = 2;
            // 
            // cbDrugNames
            // 
            this.cbDrugNames.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbDrugNames.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbDrugNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDrugNames.FormattingEnabled = true;
            this.cbDrugNames.Location = new System.Drawing.Point(840, 22);
            this.cbDrugNames.Name = "cbDrugNames";
            this.cbDrugNames.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbDrugNames.Size = new System.Drawing.Size(354, 32);
            this.cbDrugNames.TabIndex = 0;
            this.cbDrugNames.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbDrugNames_KeyDown);
            // 
            // cbDrugeType
            // 
            this.cbDrugeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDrugeType.FormattingEnabled = true;
            this.cbDrugeType.Location = new System.Drawing.Point(840, 82);
            this.cbDrugeType.Name = "cbDrugeType";
            this.cbDrugeType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbDrugeType.Size = new System.Drawing.Size(354, 32);
            this.cbDrugeType.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(711, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 24);
            this.label8.TabIndex = 26;
            this.label8.Text = "تاريخ الانتهاء";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(726, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 24);
            this.label7.TabIndex = 26;
            this.label7.Text = "سعر البيع";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1214, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 24);
            this.label6.TabIndex = 26;
            this.label6.Text = "الشركة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(749, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "الكمية";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1200, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "نوع الصنف";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1202, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "اسم الصنف";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::PharmaceyManagament.Properties.Resources.icons8_cancel_48px;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(684, 221);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 81);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.Enter += new System.EventHandler(this.btnDelete_MouseHover);
            this.btnDelete.Leave += new System.EventHandler(this.btnDelete_MouseLeave);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
            this.btnDelete.MouseHover += new System.EventHandler(this.btnDelete_MouseHover);
            // 
            // btnSaveAlteration
            // 
            this.btnSaveAlteration.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnSaveAlteration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSaveAlteration.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveAlteration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAlteration.Image = global::PharmaceyManagament.Properties.Resources.icons8_refresh_48px_1;
            this.btnSaveAlteration.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaveAlteration.Location = new System.Drawing.Point(1067, 221);
            this.btnSaveAlteration.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSaveAlteration.Name = "btnSaveAlteration";
            this.btnSaveAlteration.Size = new System.Drawing.Size(116, 81);
            this.btnSaveAlteration.TabIndex = 6;
            this.btnSaveAlteration.Text = "حفظ التعديل";
            this.btnSaveAlteration.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaveAlteration.UseVisualStyleBackColor = false;
            this.btnSaveAlteration.Click += new System.EventHandler(this.btnSaveAlteration_Click);
            this.btnSaveAlteration.Enter += new System.EventHandler(this.btnSaveAlteration_MouseHover);
            this.btnSaveAlteration.Leave += new System.EventHandler(this.btnSaveAlteration_MouseLeave);
            this.btnSaveAlteration.MouseLeave += new System.EventHandler(this.btnSaveAlteration_MouseLeave);
            this.btnSaveAlteration.MouseHover += new System.EventHandler(this.btnSaveAlteration_MouseHover);
            // 
            // btnSaveAndPrint
            // 
            this.btnSaveAndPrint.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnSaveAndPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSaveAndPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveAndPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAndPrint.Image = global::PharmaceyManagament.Properties.Resources.icons8_receipt_48px;
            this.btnSaveAndPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaveAndPrint.Location = new System.Drawing.Point(301, 221);
            this.btnSaveAndPrint.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSaveAndPrint.Name = "btnSaveAndPrint";
            this.btnSaveAndPrint.Size = new System.Drawing.Size(116, 81);
            this.btnSaveAndPrint.TabIndex = 8;
            this.btnSaveAndPrint.Text = " طباعة";
            this.btnSaveAndPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaveAndPrint.UseVisualStyleBackColor = false;
            this.btnSaveAndPrint.Click += new System.EventHandler(this.btnSaveAndPrint_Click);
            this.btnSaveAndPrint.Enter += new System.EventHandler(this.btnSaveAndPrint_MouseHover);
            this.btnSaveAndPrint.Leave += new System.EventHandler(this.btnSaveAndPrint_MouseLeave);
            this.btnSaveAndPrint.MouseLeave += new System.EventHandler(this.btnSaveAndPrint_MouseLeave);
            this.btnSaveAndPrint.MouseHover += new System.EventHandler(this.btnSaveAndPrint_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StoreDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 630);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "StoreDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StoreDetails";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StoreDetails_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pannalss.ResumeLayout(false);
            this.pannalss.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPharmaNme;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pannalss;
        private System.Windows.Forms.Button btnSaveAlteration;
        private System.Windows.Forms.Button btnSaveAndPrint;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDrugExpDate;
        private System.Windows.Forms.TextBox txtDrugSalePrice;
        private System.Windows.Forms.TextBox txtDrugQuantiy;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ComboBox cbDrugCompany;
        private System.Windows.Forms.ComboBox cbDrugNames;
        private System.Windows.Forms.ComboBox cbDrugeType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
    }
}