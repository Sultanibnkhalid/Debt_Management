namespace PharmaceyManagament.SalesAndPurchases
{
    partial class Drugs
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbSupliers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCompany = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddNewSuppleir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblErrors = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveBill = new System.Windows.Forms.Button();
            this.btnAddtobill = new System.Windows.Forms.Button();
            this.pnlNewSupplier = new System.Windows.Forms.Panel();
            this.lblAddSupplierErrortext = new System.Windows.Forms.Label();
            this.txtSuppleirAddres = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnddNewSupplier = new System.Windows.Forms.Button();
            this.txtNewSuplierPhone = new System.Windows.Forms.TextBox();
            this.txtNewspplierName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOnePrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.dtpExpDate = new System.Windows.Forms.DateTimePicker();
            this.cbDrugType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDrugName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPharmaNme = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.datagrideView = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlNewSupplier.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrideView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1187, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "بيانات الموردين";
            // 
            // cbSupliers
            // 
            this.cbSupliers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSupliers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbSupliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSupliers.FormattingEnabled = true;
            this.cbSupliers.Location = new System.Drawing.Point(858, 54);
            this.cbSupliers.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbSupliers.Name = "cbSupliers";
            this.cbSupliers.Size = new System.Drawing.Size(323, 32);
            this.cbSupliers.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(730, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "الشركة المصنعة";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbCompany
            // 
            this.cbCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCompany.FormattingEnabled = true;
            this.cbCompany.Location = new System.Drawing.Point(412, 51);
            this.cbCompany.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbCompany.Name = "cbCompany";
            this.cbCompany.Size = new System.Drawing.Size(314, 32);
            this.cbCompany.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1187, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "اسم المورد";
            // 
            // btnAddNewSuppleir
            // 
            this.btnAddNewSuppleir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNewSuppleir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewSuppleir.Location = new System.Drawing.Point(290, 3);
            this.btnAddNewSuppleir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddNewSuppleir.Name = "btnAddNewSuppleir";
            this.btnAddNewSuppleir.Size = new System.Drawing.Size(85, 42);
            this.btnAddNewSuppleir.TabIndex = 12;
            this.btnAddNewSuppleir.Text = "مورد جديد";
            this.btnAddNewSuppleir.UseVisualStyleBackColor = true;
            this.btnAddNewSuppleir.Click += new System.EventHandler(this.btnAddNewSuppleir_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblErrors);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtSalePrice);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnSaveBill);
            this.panel2.Controls.Add(this.btnAddtobill);
            this.panel2.Controls.Add(this.pnlNewSupplier);
            this.panel2.Controls.Add(this.txtOnePrice);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnAddNewSuppleir);
            this.panel2.Controls.Add(this.cbCompany);
            this.panel2.Controls.Add(this.txtQuantity);
            this.panel2.Controls.Add(this.cbSupliers);
            this.panel2.Controls.Add(this.dtpExpDate);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cbDrugType);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cbDrugName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1301, 578);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::PharmaceyManagament.Properties.Resources.icons8_checked_checkbox_48px_1;
            this.pictureBox1.Location = new System.Drawing.Point(678, 238);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // lblErrors
            // 
            this.lblErrors.AutoSize = true;
            this.lblErrors.Location = new System.Drawing.Point(366, 210);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(10, 13);
            this.lblErrors.TabIndex = 23;
            this.lblErrors.Text = " ";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(492, 173);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 24);
            this.label13.TabIndex = 22;
            this.label13.Text = "سعر البيع";
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalePrice.Location = new System.Drawing.Point(339, 173);
            this.txtSalePrice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(149, 29);
            this.txtSalePrice.TabIndex = 8;
            this.txtSalePrice.Text = "0.00";
            this.txtSalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Lavender;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::PharmaceyManagament.Properties.Resources.icons8_cancel_48px;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(479, 238);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(169, 80);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSaveBill
            // 
            this.btnSaveBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveBill.BackColor = System.Drawing.Color.Lavender;
            this.btnSaveBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSaveBill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveBill.Image = global::PharmaceyManagament.Properties.Resources.icons8_save_as_48px;
            this.btnSaveBill.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaveBill.Location = new System.Drawing.Point(738, 238);
            this.btnSaveBill.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSaveBill.Name = "btnSaveBill";
            this.btnSaveBill.Size = new System.Drawing.Size(165, 80);
            this.btnSaveBill.TabIndex = 10;
            this.btnSaveBill.Text = "حفظ";
            this.btnSaveBill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaveBill.UseVisualStyleBackColor = false;
            this.btnSaveBill.Click += new System.EventHandler(this.btnSaveBill_Click);
            // 
            // btnAddtobill
            // 
            this.btnAddtobill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddtobill.BackColor = System.Drawing.Color.Lavender;
            this.btnAddtobill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddtobill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddtobill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtobill.Image = global::PharmaceyManagament.Properties.Resources.icons8_insert_row_48px;
            this.btnAddtobill.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddtobill.Location = new System.Drawing.Point(1011, 238);
            this.btnAddtobill.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddtobill.Name = "btnAddtobill";
            this.btnAddtobill.Size = new System.Drawing.Size(165, 80);
            this.btnAddtobill.TabIndex = 9;
            this.btnAddtobill.Text = "اضافة";
            this.btnAddtobill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddtobill.UseVisualStyleBackColor = false;
            this.btnAddtobill.Click += new System.EventHandler(this.btnAddtobill_Click);
            // 
            // pnlNewSupplier
            // 
            this.pnlNewSupplier.BackColor = System.Drawing.Color.Azure;
            this.pnlNewSupplier.Controls.Add(this.lblAddSupplierErrortext);
            this.pnlNewSupplier.Controls.Add(this.txtSuppleirAddres);
            this.pnlNewSupplier.Controls.Add(this.btnCancel);
            this.pnlNewSupplier.Controls.Add(this.btnddNewSupplier);
            this.pnlNewSupplier.Controls.Add(this.txtNewSuplierPhone);
            this.pnlNewSupplier.Controls.Add(this.txtNewspplierName);
            this.pnlNewSupplier.Controls.Add(this.label12);
            this.pnlNewSupplier.Controls.Add(this.label11);
            this.pnlNewSupplier.Controls.Add(this.label10);
            this.pnlNewSupplier.Location = new System.Drawing.Point(0, 0);
            this.pnlNewSupplier.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlNewSupplier.Name = "pnlNewSupplier";
            this.pnlNewSupplier.Size = new System.Drawing.Size(286, 318);
            this.pnlNewSupplier.TabIndex = 0;
            this.pnlNewSupplier.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlNewSupplier_Paint);
            // 
            // lblAddSupplierErrortext
            // 
            this.lblAddSupplierErrortext.AutoSize = true;
            this.lblAddSupplierErrortext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSupplierErrortext.Location = new System.Drawing.Point(63, 244);
            this.lblAddSupplierErrortext.Name = "lblAddSupplierErrortext";
            this.lblAddSupplierErrortext.Size = new System.Drawing.Size(70, 24);
            this.lblAddSupplierErrortext.TabIndex = 11;
            this.lblAddSupplierErrortext.Text = "label14";
            // 
            // txtSuppleirAddres
            // 
            this.txtSuppleirAddres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuppleirAddres.Location = new System.Drawing.Point(11, 112);
            this.txtSuppleirAddres.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSuppleirAddres.Multiline = true;
            this.txtSuppleirAddres.Name = "txtSuppleirAddres";
            this.txtSuppleirAddres.Size = new System.Drawing.Size(188, 47);
            this.txtSuppleirAddres.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(23, 165);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(74, 36);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "الغاء";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnddNewSupplier
            // 
            this.btnddNewSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnddNewSupplier.Location = new System.Drawing.Point(124, 165);
            this.btnddNewSupplier.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnddNewSupplier.Name = "btnddNewSupplier";
            this.btnddNewSupplier.Size = new System.Drawing.Size(74, 36);
            this.btnddNewSupplier.TabIndex = 3;
            this.btnddNewSupplier.Text = "حفظ";
            this.btnddNewSupplier.UseVisualStyleBackColor = true;
            this.btnddNewSupplier.Click += new System.EventHandler(this.btnddNewSupplier_Click);
            // 
            // txtNewSuplierPhone
            // 
            this.txtNewSuplierPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewSuplierPhone.Location = new System.Drawing.Point(11, 68);
            this.txtNewSuplierPhone.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNewSuplierPhone.Name = "txtNewSuplierPhone";
            this.txtNewSuplierPhone.Size = new System.Drawing.Size(188, 29);
            this.txtNewSuplierPhone.TabIndex = 1;
            this.txtNewSuplierPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyDown);
            this.txtNewSuplierPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // txtNewspplierName
            // 
            this.txtNewspplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewspplierName.Location = new System.Drawing.Point(11, 27);
            this.txtNewspplierName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNewspplierName.Name = "txtNewspplierName";
            this.txtNewspplierName.Size = new System.Drawing.Size(188, 29);
            this.txtNewspplierName.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(220, 110);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 24);
            this.label12.TabIndex = 8;
            this.label12.Text = "العنوان";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(223, 63);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 24);
            this.label11.TabIndex = 8;
            this.label11.Text = "الهاتف";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(229, 30);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 24);
            this.label10.TabIndex = 5;
            this.label10.Text = "الاسم";
            // 
            // txtOnePrice
            // 
            this.txtOnePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOnePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOnePrice.Location = new System.Drawing.Point(589, 173);
            this.txtOnePrice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtOnePrice.Name = "txtOnePrice";
            this.txtOnePrice.Size = new System.Drawing.Size(197, 29);
            this.txtOnePrice.TabIndex = 7;
            this.txtOnePrice.Text = "0.00";
            this.txtOnePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOnePrice.TextChanged += new System.EventHandler(this.txtOnePrice_TextChanged);
            this.txtOnePrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyDown);
            this.txtOnePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(924, 173);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(259, 29);
            this.txtQuantity.TabIndex = 6;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyDown);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // dtpExpDate
            // 
            this.dtpExpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpExpDate.Location = new System.Drawing.Point(325, 125);
            this.dtpExpDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpExpDate.Name = "dtpExpDate";
            this.dtpExpDate.Size = new System.Drawing.Size(163, 20);
            this.dtpExpDate.TabIndex = 5;
            // 
            // cbDrugType
            // 
            this.cbDrugType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDrugType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDrugType.FormattingEnabled = true;
            this.cbDrugType.Location = new System.Drawing.Point(589, 128);
            this.cbDrugType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbDrugType.Name = "cbDrugType";
            this.cbDrugType.Size = new System.Drawing.Size(196, 32);
            this.cbDrugType.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(492, 126);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 24);
            this.label9.TabIndex = 21;
            this.label9.Text = "تاريخ الإنتهاء";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(816, 129);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 24);
            this.label8.TabIndex = 23;
            this.label8.Text = "النوع";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1200, 131);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "الصنف";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1206, 177);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 24);
            this.label7.TabIndex = 23;
            this.label7.Text = "الكمية";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(790, 173);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = "سعر الوحدة";
            // 
            // cbDrugName
            // 
            this.cbDrugName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDrugName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDrugName.FormattingEnabled = true;
            this.cbDrugName.Location = new System.Drawing.Point(883, 128);
            this.cbDrugName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbDrugName.Name = "cbDrugName";
            this.cbDrugName.Size = new System.Drawing.Size(300, 32);
            this.cbDrugName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1187, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "بيانات الاصناف";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pbBack);
            this.panel1.Controls.Add(this.pbMinimize);
            this.panel1.Controls.Add(this.lblCurrentUser);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblPharmaNme);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1301, 47);
            this.panel1.TabIndex = 1;
            // 
            // pbBack
            // 
            this.pbBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbBack.Image = global::PharmaceyManagament.Properties.Resources.icons8_delete_48px_1;
            this.pbBack.Location = new System.Drawing.Point(0, 1);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(48, 44);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBack.TabIndex = 11;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // pbMinimize
            // 
            this.pbMinimize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbMinimize.Image = global::PharmaceyManagament.Properties.Resources.icons8_down__1_;
            this.pbMinimize.Location = new System.Drawing.Point(47, 1);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(48, 44);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMinimize.TabIndex = 10;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUser.Location = new System.Drawing.Point(893, 12);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(70, 24);
            this.lblCurrentUser.TabIndex = 0;
            this.lblCurrentUser.Text = "label11";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(169, 12);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(70, 24);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "label11";
            // 
            // lblPharmaNme
            // 
            this.lblPharmaNme.AutoSize = true;
            this.lblPharmaNme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPharmaNme.Location = new System.Drawing.Point(528, 9);
            this.lblPharmaNme.Name = "lblPharmaNme";
            this.lblPharmaNme.Size = new System.Drawing.Size(70, 24);
            this.lblPharmaNme.TabIndex = 0;
            this.lblPharmaNme.Text = "label11";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.datagrideView);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 377);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1301, 248);
            this.panel3.TabIndex = 5;
            // 
            // datagrideView
            // 
            this.datagrideView.AllowUserToAddRows = false;
            this.datagrideView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrideView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrideView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagrideView.Location = new System.Drawing.Point(0, 0);
            this.datagrideView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.datagrideView.Name = "datagrideView";
            this.datagrideView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.datagrideView.Size = new System.Drawing.Size(1301, 248);
            this.datagrideView.TabIndex = 0;
            this.datagrideView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrideView_CellContentClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Drugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 625);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Drugs";
            this.Text = "المشتريات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Drugs_FormClosing);
            this.Load += new System.EventHandler(this.Drugs_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlNewSupplier.ResumeLayout(false);
            this.pnlNewSupplier.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrideView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddNewSuppleir;
        private System.Windows.Forms.ComboBox cbCompany;
        private System.Windows.Forms.ComboBox cbSupliers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOnePrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.DateTimePicker dtpExpDate;
        private System.Windows.Forms.ComboBox cbDrugType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDrugName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlNewSupplier;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnddNewSupplier;
        private System.Windows.Forms.TextBox txtNewSuplierPhone;
        private System.Windows.Forms.TextBox txtNewspplierName;
        private System.Windows.Forms.Button btnSaveBill;
        private System.Windows.Forms.Button btnAddtobill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView datagrideView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPharmaNme;
        private System.Windows.Forms.TextBox txtSuppleirAddres;
        private System.Windows.Forms.Label lblAddSupplierErrortext;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblErrors;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}