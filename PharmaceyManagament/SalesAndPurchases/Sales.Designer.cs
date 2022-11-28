namespace PharmaceyManagament.SalesAndPurchases
{
    partial class Sales
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbCustomerName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPaidMony = new System.Windows.Forms.TextBox();
            this.lblCheckQuntity = new System.Windows.Forms.Label();
            this.lblErrorsMessage = new System.Windows.Forms.Label();
            this.btnSaveAndPrint = new System.Windows.Forms.Button();
            this.rbtnDebt = new System.Windows.Forms.RadioButton();
            this.rbtnCash = new System.Windows.Forms.RadioButton();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbDrugType = new System.Windows.Forms.ComboBox();
            this.btnSaveBill = new System.Windows.Forms.Button();
            this.btnAddtobill = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.nudCounts = new System.Windows.Forms.NumericUpDown();
            this.txtDueMoney = new System.Windows.Forms.TextBox();
            this.txtReduction = new System.Windows.Forms.TextBox();
            this.cbCompany = new System.Windows.Forms.ComboBox();
            this.cbDrugName = new System.Windows.Forms.ComboBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPharmaNme = new System.Windows.Forms.Label();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCounts)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 467);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 282);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(1370, 282);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel2.Controls.Add(this.cbCustomerName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 418);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cbCustomerName
            // 
            this.cbCustomerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbCustomerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCustomerName.FormattingEnabled = true;
            this.cbCustomerName.Location = new System.Drawing.Point(1003, 49);
            this.cbCustomerName.Name = "cbCustomerName";
            this.cbCustomerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbCustomerName.Size = new System.Drawing.Size(325, 32);
            this.cbCustomerName.TabIndex = 3;
            this.cbCustomerName.SelectedIndexChanged += new System.EventHandler(this.cbCustomerName_SelectedIndexChanged);
            this.cbCustomerName.Enter += new System.EventHandler(this.cbDrugName_Enter);
            this.cbCustomerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbCustomerName_KeyDown);
            this.cbCustomerName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cbCustomerName_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1279, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "الزبون";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCustomerPhone);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.txtCustomerAddress);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1370, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerPhone.Location = new System.Drawing.Point(688, 52);
            this.txtCustomerPhone.MaxLength = 14;
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCustomerPhone.Size = new System.Drawing.Size(257, 29);
            this.txtCustomerPhone.TabIndex = 0;
            this.txtCustomerPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCustomerPhone.Enter += new System.EventHandler(this.cbDrugName_Enter);
            this.txtCustomerPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomerPhone_KeyDown);
            this.txtCustomerPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerPhone_KeyPress_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PharmaceyManagament.Properties.Resources.icons8_apply_skin_type_7_48px;
            this.pictureBox3.Location = new System.Drawing.Point(164, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            this.pictureBox3.MouseLeave += new System.EventHandler(this.btnAddtobill_Leave);
            this.pictureBox3.MouseHover += new System.EventHandler(this.cbDrugName_Enter);
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerAddress.Location = new System.Drawing.Point(316, 49);
            this.txtCustomerAddress.Multiline = true;
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCustomerAddress.Size = new System.Drawing.Size(314, 49);
            this.txtCustomerAddress.TabIndex = 1;
            this.txtCustomerAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCustomerAddress.Enter += new System.EventHandler(this.cbDrugName_Enter);
            this.txtCustomerAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomerAddress_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(571, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "العنوان";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(888, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "التلفون";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PharmaceyManagament.Properties.Resources.icons8_add_user_male_48px;
            this.pictureBox2.Location = new System.Drawing.Point(218, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.btnAddtobill_Leave);
            this.pictureBox2.MouseHover += new System.EventHandler(this.btnAddtobill_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtPaidMony);
            this.groupBox2.Controls.Add(this.lblCheckQuntity);
            this.groupBox2.Controls.Add(this.lblErrorsMessage);
            this.groupBox2.Controls.Add(this.btnSaveAndPrint);
            this.groupBox2.Controls.Add(this.rbtnDebt);
            this.groupBox2.Controls.Add(this.rbtnCash);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.cbDrugType);
            this.groupBox2.Controls.Add(this.btnSaveBill);
            this.groupBox2.Controls.Add(this.btnAddtobill);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.nudCounts);
            this.groupBox2.Controls.Add(this.txtDueMoney);
            this.groupBox2.Controls.Add(this.txtReduction);
            this.groupBox2.Controls.Add(this.cbCompany);
            this.groupBox2.Controls.Add(this.cbDrugName);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(3, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1367, 309);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(393, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 24);
            this.label11.TabIndex = 25;
            this.label11.Text = "المبلغ المدفوع";
            // 
            // txtPaidMony
            // 
            this.txtPaidMony.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaidMony.Location = new System.Drawing.Point(311, 141);
            this.txtPaidMony.Name = "txtPaidMony";
            this.txtPaidMony.ReadOnly = true;
            this.txtPaidMony.Size = new System.Drawing.Size(184, 29);
            this.txtPaidMony.TabIndex = 7;
            this.txtPaidMony.Text = " 0";
            this.txtPaidMony.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPaidMony.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomerPhone_KeyDown);
            this.txtPaidMony.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCustomerPhone_KeyPress);
            // 
            // lblCheckQuntity
            // 
            this.lblCheckQuntity.AutoSize = true;
            this.lblCheckQuntity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckQuntity.ForeColor = System.Drawing.Color.Red;
            this.lblCheckQuntity.Location = new System.Drawing.Point(296, 87);
            this.lblCheckQuntity.Name = "lblCheckQuntity";
            this.lblCheckQuntity.Size = new System.Drawing.Size(15, 24);
            this.lblCheckQuntity.TabIndex = 23;
            this.lblCheckQuntity.Text = " ";
            // 
            // lblErrorsMessage
            // 
            this.lblErrorsMessage.AutoSize = true;
            this.lblErrorsMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorsMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorsMessage.Location = new System.Drawing.Point(104, 196);
            this.lblErrorsMessage.Name = "lblErrorsMessage";
            this.lblErrorsMessage.Size = new System.Drawing.Size(37, 24);
            this.lblErrorsMessage.TabIndex = 21;
            this.lblErrorsMessage.Text = "العدد";
            // 
            // btnSaveAndPrint
            // 
            this.btnSaveAndPrint.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnSaveAndPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSaveAndPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveAndPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAndPrint.Image = global::PharmaceyManagament.Properties.Resources.icons8_print_48px;
            this.btnSaveAndPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaveAndPrint.Location = new System.Drawing.Point(565, 205);
            this.btnSaveAndPrint.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSaveAndPrint.Name = "btnSaveAndPrint";
            this.btnSaveAndPrint.Size = new System.Drawing.Size(150, 84);
            this.btnSaveAndPrint.TabIndex = 10;
            this.btnSaveAndPrint.Text = "حفظ وطباعة";
            this.btnSaveAndPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaveAndPrint.UseVisualStyleBackColor = false;
            this.btnSaveAndPrint.Click += new System.EventHandler(this.btnSaveAndPrint_Click);
            this.btnSaveAndPrint.Enter += new System.EventHandler(this.btnAddtobill_Enter);
            this.btnSaveAndPrint.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSaveAndPrint_KeyDown);
            this.btnSaveAndPrint.Leave += new System.EventHandler(this.btnAddtobill_Leave);
            this.btnSaveAndPrint.MouseLeave += new System.EventHandler(this.btnAddtobill_Leave);
            this.btnSaveAndPrint.MouseHover += new System.EventHandler(this.btnAddtobill_Enter);
            // 
            // rbtnDebt
            // 
            this.rbtnDebt.AutoSize = true;
            this.rbtnDebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDebt.Location = new System.Drawing.Point(234, 133);
            this.rbtnDebt.Name = "rbtnDebt";
            this.rbtnDebt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtnDebt.Size = new System.Drawing.Size(53, 28);
            this.rbtnDebt.TabIndex = 12;
            this.rbtnDebt.TabStop = true;
            this.rbtnDebt.Text = "آجل";
            this.rbtnDebt.UseVisualStyleBackColor = true;
            this.rbtnDebt.CheckedChanged += new System.EventHandler(this.rbtnDebt_CheckedChanged);
            // 
            // rbtnCash
            // 
            this.rbtnCash.AutoSize = true;
            this.rbtnCash.BackColor = System.Drawing.Color.LavenderBlush;
            this.rbtnCash.Checked = true;
            this.rbtnCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCash.ForeColor = System.Drawing.Color.Black;
            this.rbtnCash.Location = new System.Drawing.Point(165, 131);
            this.rbtnCash.Name = "rbtnCash";
            this.rbtnCash.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtnCash.Size = new System.Drawing.Size(44, 28);
            this.rbtnCash.TabIndex = 9;
            this.rbtnCash.TabStop = true;
            this.rbtnCash.Text = "نقد";
            this.rbtnCash.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::PharmaceyManagament.Properties.Resources.icons8_cancel_48px;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(281, 205);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 84);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.Enter += new System.EventHandler(this.btnAddtobill_Enter);
            this.btnDelete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnDelete_KeyDown);
            this.btnDelete.Leave += new System.EventHandler(this.btnAddtobill_Leave);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnAddtobill_Leave);
            this.btnDelete.MouseHover += new System.EventHandler(this.btnAddtobill_Enter);
            // 
            // cbDrugType
            // 
            this.cbDrugType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDrugType.FormattingEnabled = true;
            this.cbDrugType.Location = new System.Drawing.Point(813, 47);
            this.cbDrugType.Name = "cbDrugType";
            this.cbDrugType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbDrugType.Size = new System.Drawing.Size(240, 32);
            this.cbDrugType.TabIndex = 1;
            this.cbDrugType.Enter += new System.EventHandler(this.cbDrugName_Enter);
            this.cbDrugType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbDrugType_KeyDown);
            // 
            // btnSaveBill
            // 
            this.btnSaveBill.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnSaveBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSaveBill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveBill.Image = global::PharmaceyManagament.Properties.Resources.icons8_save_as_48px;
            this.btnSaveBill.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaveBill.Location = new System.Drawing.Point(849, 205);
            this.btnSaveBill.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSaveBill.Name = "btnSaveBill";
            this.btnSaveBill.Size = new System.Drawing.Size(150, 84);
            this.btnSaveBill.TabIndex = 9;
            this.btnSaveBill.Text = "حفظ";
            this.btnSaveBill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaveBill.UseVisualStyleBackColor = false;
            this.btnSaveBill.Click += new System.EventHandler(this.btnSaveBill_Click);
            this.btnSaveBill.Enter += new System.EventHandler(this.btnAddtobill_Enter);
            this.btnSaveBill.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSaveBill_KeyDown);
            this.btnSaveBill.Leave += new System.EventHandler(this.btnAddtobill_Leave);
            this.btnSaveBill.MouseLeave += new System.EventHandler(this.btnAddtobill_Leave);
            this.btnSaveBill.MouseHover += new System.EventHandler(this.btnAddtobill_Enter);
            // 
            // btnAddtobill
            // 
            this.btnAddtobill.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnAddtobill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddtobill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddtobill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtobill.Image = global::PharmaceyManagament.Properties.Resources.icons8_insert_row_48px;
            this.btnAddtobill.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddtobill.Location = new System.Drawing.Point(1133, 205);
            this.btnAddtobill.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddtobill.Name = "btnAddtobill";
            this.btnAddtobill.Size = new System.Drawing.Size(150, 84);
            this.btnAddtobill.TabIndex = 8;
            this.btnAddtobill.Text = "اضافة";
            this.btnAddtobill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddtobill.UseVisualStyleBackColor = false;
            this.btnAddtobill.Click += new System.EventHandler(this.btnAddtobill_Click);
            this.btnAddtobill.Enter += new System.EventHandler(this.btnAddtobill_Enter);
            this.btnAddtobill.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnAddtobill_KeyDown);
            this.btnAddtobill.Leave += new System.EventHandler(this.btnAddtobill_Leave);
            this.btnAddtobill.MouseLeave += new System.EventHandler(this.btnAddtobill_Leave);
            this.btnAddtobill.MouseHover += new System.EventHandler(this.btnAddtobill_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1012, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 24);
            this.label10.TabIndex = 17;
            this.label10.Text = "النوع";
            // 
            // nudCounts
            // 
            this.nudCounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCounts.Location = new System.Drawing.Point(198, 46);
            this.nudCounts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCounts.Name = "nudCounts";
            this.nudCounts.Size = new System.Drawing.Size(282, 29);
            this.nudCounts.TabIndex = 3;
            this.nudCounts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCounts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCounts.ValueChanged += new System.EventHandler(this.nupCounts_ValueChanged);
            this.nudCounts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudCounts_KeyDown);
            this.nudCounts.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nudCounts_MouseDown);
            // 
            // txtDueMoney
            // 
            this.txtDueMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDueMoney.Location = new System.Drawing.Point(535, 141);
            this.txtDueMoney.Name = "txtDueMoney";
            this.txtDueMoney.ReadOnly = true;
            this.txtDueMoney.Size = new System.Drawing.Size(249, 29);
            this.txtDueMoney.TabIndex = 6;
            this.txtDueMoney.Text = " 0";
            this.txtDueMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtReduction
            // 
            this.txtReduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReduction.Location = new System.Drawing.Point(800, 141);
            this.txtReduction.Name = "txtReduction";
            this.txtReduction.ReadOnly = true;
            this.txtReduction.Size = new System.Drawing.Size(184, 29);
            this.txtReduction.TabIndex = 5;
            this.txtReduction.Text = " 0";
            this.txtReduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtReduction.TextChanged += new System.EventHandler(this.txtReduction_TextChanged);
            this.txtReduction.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomerPhone_KeyDown);
            this.txtReduction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCustomerPhone_KeyPress);
            // 
            // cbCompany
            // 
            this.cbCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCompany.FormattingEnabled = true;
            this.cbCompany.Location = new System.Drawing.Point(551, 45);
            this.cbCompany.Name = "cbCompany";
            this.cbCompany.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbCompany.Size = new System.Drawing.Size(241, 32);
            this.cbCompany.TabIndex = 2;
            this.cbCompany.Enter += new System.EventHandler(this.cbDrugName_Enter);
            this.cbCompany.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbCompany_KeyDown);
            // 
            // cbDrugName
            // 
            this.cbDrugName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbDrugName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbDrugName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDrugName.FormattingEnabled = true;
            this.cbDrugName.Location = new System.Drawing.Point(1108, 45);
            this.cbDrugName.Name = "cbDrugName";
            this.cbDrugName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbDrugName.Size = new System.Drawing.Size(220, 32);
            this.cbDrugName.TabIndex = 0;
            this.cbDrugName.SelectedIndexChanged += new System.EventHandler(this.cbDrugName_SelectedIndexChanged);
            this.cbDrugName.Enter += new System.EventHandler(this.cbDrugName_Enter);
            this.cbDrugName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbDrugName_KeyDown);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(1021, 141);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(151, 29);
            this.txtTotal.TabIndex = 4;
            this.txtTotal.Text = " 0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotal.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1271, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "الصنف";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1101, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "المجموع";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(443, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "العدد";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(741, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "الشركة";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(907, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 24);
            this.label9.TabIndex = 22;
            this.label9.Text = "التخفيض";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(657, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "المبلغ المستحق";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.lblCurrentUser);
            this.panel3.Controls.Add(this.lblDate);
            this.panel3.Controls.Add(this.lblPharmaNme);
            this.panel3.Controls.Add(this.pbMinimize);
            this.panel3.Controls.Add(this.pbBack);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1370, 47);
            this.panel3.TabIndex = 3;
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Location = new System.Drawing.Point(962, 9);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(70, 24);
            this.lblCurrentUser.TabIndex = 6;
            this.lblCurrentUser.Text = "label11";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(247, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(70, 24);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "label11";
            // 
            // lblPharmaNme
            // 
            this.lblPharmaNme.AutoSize = true;
            this.lblPharmaNme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPharmaNme.Location = new System.Drawing.Point(595, 9);
            this.lblPharmaNme.Name = "lblPharmaNme";
            this.lblPharmaNme.Size = new System.Drawing.Size(70, 24);
            this.lblPharmaNme.TabIndex = 4;
            this.lblPharmaNme.Text = "label11";
            // 
            // pbMinimize
            // 
            this.pbMinimize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbMinimize.Image = global::PharmaceyManagament.Properties.Resources.icons8_down__1_;
            this.pbMinimize.Location = new System.Drawing.Point(48, 1);
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
            this.pbBack.Location = new System.Drawing.Point(0, 1);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(48, 44);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBack.TabIndex = 2;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Sales";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "المبيعات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sales_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCounts)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbCustomerName;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbCompany;
        private System.Windows.Forms.ComboBox cbDrugName;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.NumericUpDown nudCounts;
        private System.Windows.Forms.TextBox txtDueMoney;
        private System.Windows.Forms.TextBox txtReduction;
        private System.Windows.Forms.ComboBox cbDrugType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rbtnDebt;
        private System.Windows.Forms.RadioButton rbtnCash;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSaveBill;
        private System.Windows.Forms.Button btnAddtobill;
        private System.Windows.Forms.Button btnSaveAndPrint;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPharmaNme;
        private System.Windows.Forms.Label lblErrorsMessage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblCheckQuntity;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPaidMony;
    }
}