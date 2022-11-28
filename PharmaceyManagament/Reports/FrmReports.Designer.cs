namespace PharmaceyManagament.Reports
{
    partial class FrmReports
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvbills = new System.Windows.Forms.DataGridView();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.dtpForDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.txtbillNumber = new System.Windows.Forms.TextBox();
            this.btnAlterBill = new System.Windows.Forms.Button();
            this.btnOrderByDate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchByBiilNumber = new System.Windows.Forms.Button();
            this.btnSaveAndPrint = new System.Windows.Forms.Button();
            this.rbtnPurchases = new System.Windows.Forms.RadioButton();
            this.rbtnSales = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1298, 47);
            this.panel3.TabIndex = 5;
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Location = new System.Drawing.Point(984, 11);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(70, 24);
            this.lblCurrentUser.TabIndex = 6;
            this.lblCurrentUser.Text = "label11";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(416, 11);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(70, 24);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "label11";
            // 
            // lblPharmaNme
            // 
            this.lblPharmaNme.AutoSize = true;
            this.lblPharmaNme.Location = new System.Drawing.Point(713, 11);
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
            this.pbBack.Location = new System.Drawing.Point(0, -1);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(48, 44);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBack.TabIndex = 2;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Plum;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1298, 616);
            this.panel1.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.PowderBlue;
            this.panel4.Controls.Add(this.splitContainer1);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1050, 616);
            this.panel4.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Purple;
            this.splitContainer1.Panel1.Controls.Add(this.dgvbills);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvDetails);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(1050, 616);
            this.splitContainer1.SplitterDistance = 269;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgvbills
            // 
            this.dgvbills.AllowUserToAddRows = false;
            this.dgvbills.AllowUserToDeleteRows = false;
            this.dgvbills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvbills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvbills.Location = new System.Drawing.Point(0, 0);
            this.dgvbills.Name = "dgvbills";
            this.dgvbills.ReadOnly = true;
            this.dgvbills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbills.Size = new System.Drawing.Size(1050, 269);
            this.dgvbills.TabIndex = 0;
            this.dgvbills.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbills_CellClick);
            this.dgvbills.SelectionChanged += new System.EventHandler(this.dgvbills_SelectionChanged);
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetails.Size = new System.Drawing.Size(1050, 343);
            this.dgvDetails.TabIndex = 0;
            this.dgvDetails.SelectionChanged += new System.EventHandler(this.dgvDetails_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.lblError);
            this.panel2.Controls.Add(this.dtpForDate);
            this.panel2.Controls.Add(this.dtpFromDate);
            this.panel2.Controls.Add(this.txtbillNumber);
            this.panel2.Controls.Add(this.btnAlterBill);
            this.panel2.Controls.Add(this.btnOrderByDate);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnSearchByBiilNumber);
            this.panel2.Controls.Add(this.btnSaveAndPrint);
            this.panel2.Controls.Add(this.rbtnPurchases);
            this.panel2.Controls.Add(this.rbtnSales);
            this.panel2.Location = new System.Drawing.Point(1051, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 616);
            this.panel2.TabIndex = 0;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(88, 524);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(60, 24);
            this.lblError.TabIndex = 27;
            this.lblError.Text = "label3";
            // 
            // dtpForDate
            // 
            this.dtpForDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpForDate.Location = new System.Drawing.Point(27, 199);
            this.dtpForDate.Name = "dtpForDate";
            this.dtpForDate.Size = new System.Drawing.Size(200, 29);
            this.dtpForDate.TabIndex = 3;
            this.dtpForDate.Enter += new System.EventHandler(this.btnOrderByDate_Enter);
            this.dtpForDate.Leave += new System.EventHandler(this.btnOrderByDate_Leave);
            this.dtpForDate.MouseLeave += new System.EventHandler(this.btnOrderByDate_MouseLeave);
            this.dtpForDate.MouseHover += new System.EventHandler(this.btnOrderByDate_MouseHover);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Location = new System.Drawing.Point(27, 126);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(200, 29);
            this.dtpFromDate.TabIndex = 2;
            this.dtpFromDate.Enter += new System.EventHandler(this.btnOrderByDate_Enter);
            this.dtpFromDate.Leave += new System.EventHandler(this.btnOrderByDate_Leave);
            this.dtpFromDate.MouseLeave += new System.EventHandler(this.btnOrderByDate_MouseLeave);
            this.dtpFromDate.MouseHover += new System.EventHandler(this.btnOrderByDate_MouseHover);
            // 
            // txtbillNumber
            // 
            this.txtbillNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbillNumber.Location = new System.Drawing.Point(5, 295);
            this.txtbillNumber.Name = "txtbillNumber";
            this.txtbillNumber.Size = new System.Drawing.Size(237, 29);
            this.txtbillNumber.TabIndex = 5;
            this.txtbillNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbillNumber.TextChanged += new System.EventHandler(this.txtbillNumber_TextChanged);
            this.txtbillNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbillNumber_KeyDown);
            // 
            // btnAlterBill
            // 
            this.btnAlterBill.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnAlterBill.BackgroundImage = global::PharmaceyManagament.Properties.Resources.icons8_edit_property_48px;
            this.btnAlterBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAlterBill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterBill.Location = new System.Drawing.Point(6, 448);
            this.btnAlterBill.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAlterBill.Name = "btnAlterBill";
            this.btnAlterBill.Size = new System.Drawing.Size(234, 47);
            this.btnAlterBill.TabIndex = 23;
            this.btnAlterBill.Text = "تعديل ";
            this.btnAlterBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterBill.UseVisualStyleBackColor = false;
            this.btnAlterBill.Enter += new System.EventHandler(this.btnOrderByDate_Enter);
            this.btnAlterBill.Leave += new System.EventHandler(this.btnOrderByDate_Leave);
            this.btnAlterBill.MouseLeave += new System.EventHandler(this.btnOrderByDate_MouseLeave);
            this.btnAlterBill.MouseHover += new System.EventHandler(this.btnOrderByDate_MouseHover);
            // 
            // btnOrderByDate
            // 
            this.btnOrderByDate.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnOrderByDate.BackgroundImage = global::PharmaceyManagament.Properties.Resources.icons8_to_do_48px_1;
            this.btnOrderByDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOrderByDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrderByDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderByDate.Location = new System.Drawing.Point(6, 238);
            this.btnOrderByDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnOrderByDate.Name = "btnOrderByDate";
            this.btnOrderByDate.Size = new System.Drawing.Size(237, 47);
            this.btnOrderByDate.TabIndex = 4;
            this.btnOrderByDate.Text = "فرز بحسب التاريخ";
            this.btnOrderByDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrderByDate.UseVisualStyleBackColor = false;
            this.btnOrderByDate.Click += new System.EventHandler(this.btnOrderByDate_Click);
            this.btnOrderByDate.Enter += new System.EventHandler(this.btnOrderByDate_Enter);
            this.btnOrderByDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnOrderByDate_KeyDown);
            this.btnOrderByDate.Leave += new System.EventHandler(this.btnOrderByDate_Leave);
            this.btnOrderByDate.MouseLeave += new System.EventHandler(this.btnOrderByDate_MouseLeave);
            this.btnOrderByDate.MouseHover += new System.EventHandler(this.btnOrderByDate_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "الى تاريخ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "من تاريخ";
            // 
            // btnSearchByBiilNumber
            // 
            this.btnSearchByBiilNumber.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnSearchByBiilNumber.BackgroundImage = global::PharmaceyManagament.Properties.Resources.icons8_bill_48px;
            this.btnSearchByBiilNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearchByBiilNumber.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchByBiilNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByBiilNumber.Location = new System.Drawing.Point(6, 334);
            this.btnSearchByBiilNumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearchByBiilNumber.Name = "btnSearchByBiilNumber";
            this.btnSearchByBiilNumber.Size = new System.Drawing.Size(235, 47);
            this.btnSearchByBiilNumber.TabIndex = 6;
            this.btnSearchByBiilNumber.Text = "بحث باسم العميل";
            this.btnSearchByBiilNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchByBiilNumber.UseVisualStyleBackColor = false;
            this.btnSearchByBiilNumber.Click += new System.EventHandler(this.btnSearchByBiilNumber_Click);
            this.btnSearchByBiilNumber.Enter += new System.EventHandler(this.btnOrderByDate_Enter);
            this.btnSearchByBiilNumber.Leave += new System.EventHandler(this.btnOrderByDate_Leave);
            this.btnSearchByBiilNumber.MouseLeave += new System.EventHandler(this.btnOrderByDate_MouseLeave);
            this.btnSearchByBiilNumber.MouseHover += new System.EventHandler(this.btnOrderByDate_MouseHover);
            // 
            // btnSaveAndPrint
            // 
            this.btnSaveAndPrint.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnSaveAndPrint.BackgroundImage = global::PharmaceyManagament.Properties.Resources.icons8_print_48px;
            this.btnSaveAndPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSaveAndPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveAndPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAndPrint.Location = new System.Drawing.Point(6, 391);
            this.btnSaveAndPrint.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSaveAndPrint.Name = "btnSaveAndPrint";
            this.btnSaveAndPrint.Size = new System.Drawing.Size(234, 47);
            this.btnSaveAndPrint.TabIndex = 7;
            this.btnSaveAndPrint.Text = " طباعة الفاتورة";
            this.btnSaveAndPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveAndPrint.UseVisualStyleBackColor = false;
            this.btnSaveAndPrint.Click += new System.EventHandler(this.btnSaveAndPrint_Click);
            this.btnSaveAndPrint.Enter += new System.EventHandler(this.btnOrderByDate_Enter);
            this.btnSaveAndPrint.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSaveAndPrint_KeyDown);
            this.btnSaveAndPrint.Leave += new System.EventHandler(this.btnOrderByDate_Leave);
            this.btnSaveAndPrint.MouseLeave += new System.EventHandler(this.btnOrderByDate_MouseLeave);
            this.btnSaveAndPrint.MouseHover += new System.EventHandler(this.btnOrderByDate_MouseHover);
            // 
            // rbtnPurchases
            // 
            this.rbtnPurchases.AutoSize = true;
            this.rbtnPurchases.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPurchases.Location = new System.Drawing.Point(128, 54);
            this.rbtnPurchases.Name = "rbtnPurchases";
            this.rbtnPurchases.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtnPurchases.Size = new System.Drawing.Size(78, 28);
            this.rbtnPurchases.TabIndex = 1;
            this.rbtnPurchases.TabStop = true;
            this.rbtnPurchases.Text = "المبيعات";
            this.rbtnPurchases.UseVisualStyleBackColor = true;
            this.rbtnPurchases.Enter += new System.EventHandler(this.btnOrderByDate_Enter);
            this.rbtnPurchases.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtnPurchases_KeyDown);
            this.rbtnPurchases.Leave += new System.EventHandler(this.btnOrderByDate_Leave);
            this.rbtnPurchases.MouseLeave += new System.EventHandler(this.btnOrderByDate_MouseLeave);
            this.rbtnPurchases.MouseHover += new System.EventHandler(this.btnOrderByDate_MouseHover);
            // 
            // rbtnSales
            // 
            this.rbtnSales.AutoSize = true;
            this.rbtnSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSales.Location = new System.Drawing.Point(110, 16);
            this.rbtnSales.Name = "rbtnSales";
            this.rbtnSales.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtnSales.Size = new System.Drawing.Size(96, 28);
            this.rbtnSales.TabIndex = 0;
            this.rbtnSales.Text = "الامشتريات";
            this.rbtnSales.UseVisualStyleBackColor = true;
            this.rbtnSales.CheckedChanged += new System.EventHandler(this.rbtnSales_CheckedChanged);
            this.rbtnSales.Enter += new System.EventHandler(this.btnOrderByDate_Enter);
            this.rbtnSales.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtnSales_KeyDown);
            this.rbtnSales.Leave += new System.EventHandler(this.btnOrderByDate_Leave);
            this.rbtnSales.MouseLeave += new System.EventHandler(this.btnOrderByDate_MouseLeave);
            this.rbtnSales.MouseHover += new System.EventHandler(this.btnOrderByDate_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 663);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReports";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReports_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rbtnPurchases;
        private System.Windows.Forms.RadioButton rbtnSales;
        private System.Windows.Forms.Button btnOrderByDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveAndPrint;
        private System.Windows.Forms.DateTimePicker dtpForDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.TextBox txtbillNumber;
        private System.Windows.Forms.Button btnAlterBill;
        private System.Windows.Forms.Button btnSearchByBiilNumber;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvbills;
        private System.Windows.Forms.DataGridView dgvDetails;
    }
}