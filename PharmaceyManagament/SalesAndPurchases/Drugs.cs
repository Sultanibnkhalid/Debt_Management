using PharmaceyManagament.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaceyManagament.SalesAndPurchases
{
    public partial class Drugs : Form
    {
        private long mbillID = 1;
        private double billTotal = 0;
        private DataTable dt_data = new DataTable();
        private DataTable dt_bill = new DataTable();
        private bool flag;
        private string typesString;
        Color backgroundcontainers;
        Color buttonshover;
        Color buttonsbackground;
        Color fontColer;
        public Drugs()
        {
            InitializeComponent();
            flag = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            CheckForIllegalCrossThreadCalls = false;
            try
            {

                //Color backgroundcontainers;
                //Color buttonshover;
                //Color buttonsbackground;
                //Color fontColer;


                backgroundcontainers = Properties.Settings.Default.containerscolor;
                fontColer = Properties.Settings.Default.fontcolors;

                var bb = Properties.Settings.Default.buttonscolors;
                var bh = Properties.Settings.Default.buttonshover;
                buttonshover = System.Drawing.ColorTranslator.FromHtml(bh);
                buttonsbackground = System.Drawing.ColorTranslator.FromHtml(bb);

                panel3.BackColor = panel2.BackColor = backgroundcontainers;
                btnCancel.BackColor = btnAddtobill.BackColor = btnAddNewSuppleir.BackColor = btnddNewSupplier.BackColor = btnDelete.BackColor = btnSaveBill.BackColor = buttonsbackground;

                this.ForeColor = fontColer;

                lblPharmaNme.Text = Properties.Settings.Default.marketName;

            }
            catch
            {

            }



        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {

            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) || e.KeyCode == Keys.Back)
            {
                flag = false;
            }
            else
            {
                flag = true;
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = flag;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Drugs_Load(object sender, EventArgs e)
        {
            AddTypesToCombobox();
            
            this.pnlNewSupplier.Visible = false;
            this.lblCurrentUser.Text = CurrentUser.userName;
            //this.lblDate.Text = DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss");


            dt_data.Columns.Add("اسم الصنف", typeof(string));
            dt_data.Columns.Add("نوع الصنف", typeof(string));
            dt_data.Columns.Add("الشركة ", typeof(string));
            dt_data.Columns.Add("تاريخ الانتهاء ", typeof(string));
            dt_data.Columns.Add("اسم المورد ", typeof(string));
            dt_data.Columns.Add("الكمية", typeof(string));
            dt_data.Columns.Add("سعر الوحدة ", typeof(string));
            dt_data.Columns.Add("الاجمالي ", typeof(string));
            dt_data.Columns.Add("سعر البيع ", typeof(string));


            AddCopsData("company");
            AddCopsData("sup");
            AddCopsData("drug");
            
          
        }
        private void AddCopsData(string checkfiled)
        {
            using (DataBaseHelper dbh = new DataBaseHelper())
            {
                if (checkfiled == "company")
                {
                    cbCompany.DataSource = dbh.GetCompNames();
                    cbCompany.DisplayMember = "comp_name";
                    cbCompany.ValueMember = "comp_id";
                }
               else if (checkfiled == "sup")
                {
                    cbSupliers.DataSource = dbh.GetSuppliers();
                    cbSupliers.DisplayMember = "sup_name";
                    cbSupliers.ValueMember = "sup_id";
                }

               else if (checkfiled == "drug")
                {
                    cbDrugName.DataSource = dbh.GetDrugs();
                    cbDrugName.DisplayMember = "drug_name";
                    cbDrugName.ValueMember = "drug_id";
                }

               
            }
        }
        private void btnAddNewSuppleir_Click(object sender, EventArgs e)
        {
           
            this.pnlNewSupplier.Visible = (this.pnlNewSupplier.Visible == true)?false:true ;

        }

        private void btnddNewSupplier_Click(object sender, EventArgs e)
        {
            if (txtNewspplierName.Text.Trim().Length == 0)
            {
                lblAddSupplierErrortext.Text = "اسم غير صيح";
                return;
            }
            if (txtNewSuplierPhone.Text.Trim().Length == 0)
            {
                lblAddSupplierErrortext.Text = "رقم هاتف غير صيح";
                return;
            }
            if (txtSuppleirAddres.Text.Trim().Length == 0)
            {
                lblAddSupplierErrortext.Text = "عنوان غير صيح";
                return;
            }
            AddToDataBase("sup");
            AddCopsData("sup");
            pnlNewSupplier.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.pnlNewSupplier.Visible = false;
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss");

        }

        private void AddToDataBase(string checkfiled)
        {
            using(DataBaseHelper dbh=new DataBaseHelper())
            {
                try
                {
                    if (checkfiled == "company")
                    {
                        int c = dbh.AddCompName(cbCompany.Text);
                    }
                    else if (checkfiled == "sup")
                    {
                        int s = dbh.AddSupplier(txtNewspplierName.Text, txtNewSuplierPhone.Text, txtSuppleirAddres.Text);
                    }

                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "message");
                }
            }
         
        }
        private string companytext = "1..";
     //   private string suppliertext = "111";
        private void btnAddtobill_Click(object sender, EventArgs e)
        {
            
          
       
            if (cbCompany.SelectedIndex == -1 )
            {
                if (cbCompany.Text.Trim().Length == 0)
                {
                    lblErrors.Text = "اسم الشركة فاضي";
                }
                else
                {
                    AddToDataBase("company");
                    companytext = cbCompany.Text;
                }

            }
            if (cbCompany.SelectedIndex != 1)
            {
                companytext = cbCompany.Text;
            }
            if (cbSupliers.SelectedIndex == -1|| cbSupliers.Text.Trim().Length==0)
            {

                lblErrors.Text = "يرجى اضافة بيانات المورد اولاً ";
               cbSupliers.Focus();
                return;
            }
            if (dtpExpDate.Value == DateTime.Now)
            {
                lblErrors.Text = "حدد تاريخ الانتهاء";
                dtpExpDate.Focus();
                return;
            }
            if (txtQuantity.Text.Trim().Length == 0)
            {
                lblErrors.Text = " الكمية غير محددة";
                txtQuantity.Focus();
                return;
            }
           

            if (txtOnePrice.Text.Trim().Length == 0)
            {
                lblErrors.Text = "السعر غير محدد";
                txtOnePrice.Focus();
                return;
            }
            
            AddToDataGridView();
            try
            {
                if (!typesString.Contains(cbDrugType.Text.Trim()))
                {
                    string xx = cbDrugType.Text.Trim();
                    xx.Insert(0, "_");
                    typesString.Insert(0, xx);
                }
            }
            catch
            {

            }
        }
     
        private void AddToDataGridView()
        {
            double total = double.Parse(txtOnePrice.Text) * double.Parse(txtQuantity.Text);
            billTotal += total;
            
            dt_data.Rows.Add(cbDrugName.Text, cbDrugType.Text,companytext,dtpExpDate.Value.ToString("yyyy-MM-dd"), cbSupliers.Text, txtQuantity.Text,txtOnePrice.Text, total.ToString(), txtSalePrice.Text);
            datagrideView.DataSource = dt_data;
            datagrideView.Columns["سعر البيع "].Visible = false;
        }
        private void txtOnePrice_TextChanged(object sender, EventArgs e)
        {
            txtSalePrice.Text = txtOnePrice.Text;
        }

        private void btnSaveBill_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(ShowSuccess);
            th.Start();
            if (datagrideView.RowCount > 0)
            {

                try
                {
                   
                    using (DataBaseHelper dbh = new DataBaseHelper())
                    {
                        try
                        {
                            mbillID = dbh.GetLastPurchabillID() + 1;
                        }
                        catch
                        {
                            mbillID = 1;
                        }
                    }
                    using (DataBaseHelper dbh = new DataBaseHelper())
                    {
                    int q = 0;
                    double xx = 0;
                    double sm = 0;
                    for (int row = 0; row < datagrideView.Rows.Count; row++)
                    {
                        q = int.Parse(datagrideView.Rows[row].Cells[5].Value.ToString());
                        xx = double.Parse(datagrideView.Rows[row].Cells[6].Value.ToString());
                        sm = q * xx;
                        billTotal += sm;
                    }
                    int dd = dbh.AddPurchasesBill(DateTime.Now.ToString(), billTotal, int.Parse(cbSupliers.SelectedValue.ToString()));

                    }
                    using (DataBaseHelper dbh = new DataBaseHelper())
                    {
                        for (int row = 0; row < datagrideView.Rows.Count; row++)
                        {

                        // MessageBox.Show(datagrideView.Rows[row].Cells[0].Value.ToString());
                        int d = dbh.AddPurchasesDetals(mbillID, datagrideView.Rows[row].Cells[0].Value.ToString(), datagrideView.Rows[row].Cells[1].Value.ToString(), datagrideView.Rows[row].Cells[2].Value.ToString(), datagrideView.Rows[row].Cells[3].Value.ToString(), int.Parse(datagrideView.Rows[row].Cells[5].Value.ToString()), double.Parse(datagrideView.Rows[row].Cells[6].Value.ToString()), double.Parse(datagrideView.Rows[row].Cells[8].Value.ToString()));
                    }


                      

                    }

                }
              
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "msg");
                }
                dt_data.Rows.Clear();
            }
        }

        private void ShowSuccess()
        {
            pictureBox1.Visible = true;
            Thread.Sleep(3000);
           // pictureBox1.Visible = false;

        }

        private void pnlNewSupplier_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حقاً الغاء الفاتورة", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                dt_data.Rows.Clear();
                datagrideView.DataSource = dt_data;
             
            }
            else
            {
                return;
            }
        }

      private void AddTypesToCombobox()
        {
            try
            {
                typesString = Properties.Settings.Default.dtyps;
                string[] dtypes = typesString.Split('_');
                foreach(string s in dtypes)
                {
                    string dd = s.Trim('_');
                    cbDrugType.Items.Add(dd);
                }
                

            }
            catch
            {

            }
           
        }

        private void SaveDTypes()
        {
            try
            {
                Properties.Settings.Default.dtyps = typesString;
                Properties.Settings.Default.Save();
            }
            catch
            {

            }
        }
        private void datagrideView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Drugs_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveDTypes();
        }
    }
}
