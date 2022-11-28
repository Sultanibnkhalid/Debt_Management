using PharmaceyManagament.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaceyManagament.SalesAndPurchases
{
    public partial class Depts : Form
    {

        Color backgroundcontainers;
        Color buttonshover;
        Color buttonsbackground;
        Color fontColer;

        private bool flag;
        private DataTable dt_bills = new DataTable();
        private long billNo = 0;
        public Depts()
        {
            InitializeComponent();

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

                panel1.BackColor = panel2.BackColor =panel4.BackColor= backgroundcontainers;
                btnCancel.BackColor = btnSave.BackColor = buttonsbackground;
                lblPharmaNme.Text = Properties.Settings.Default.marketName;

                this.ForeColor = fontColer;
                

            }
            catch
            {

            }

            //panel3.BackColor = MyCustomColors.m_back4;
            //panel3.ForeColor = MyCustomColors.m_fontColwite;
            //panel2.BackColor = MyCustomColors.m_backLightblack;
            //panel4.BackColor = MyCustomColors.m_backLightblack;
            //btnSave.BackColor = MyCustomColors.m_backLightblack;
            //btnCancel.BackColor = MyCustomColors.m_backLightblack;

            //splitContainer1.BackColor = MyCustomColors.m_back2;

            //dataGridView1.BackgroundColor = MyCustomColors.m_backPgry;
            //dataGridView2.BackgroundColor = MyCustomColors.m_backPgry;

        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbillNumber_KeyDown(object sender, KeyEventArgs e)
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

        private void txtbillNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = flag;
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Depts_Load(object sender, EventArgs e)
        {
            //this.lblDate.Text = DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss");
            this.lblCurrentUser.Text = CurrentUser.userName;


            using (DataBaseHelper dbh=new DataBaseHelper())
            {
                dt_bills = dbh.GetNotCahSalesBill();
                dataGridView1.DataSource = dbh.GetNotCahSalesBill();
                dataGridView1.Columns["bill_id"].Visible = false;
            }
            AllDepts();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void cbCustomers_TextChanged(object sender, EventArgs e)
        {

            
            ////if (string.IsNullOrEmpty(cbCustomers.Text))
            ////{

            ////    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            ////}
            ////else
            ////{
            ////    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("العميل like N'%{0}%'", cbCustomers.Text);
            ////}
            //try
            //{
            //    DataView dv = dt_bills.DefaultView;
            //    string clname = "العميل";
            //    dv.RowFilter = String.Format("العميل like N'%{0}%'", cbCustomers.Text);
            //    dataGridView1.DataSource = dv.ToTable();
            //    dataGridView1.Columns["bill_id"].Visible = false;
            //    //DataTable dt_fiter = dt_bills.Select().Where(p => (p["العميل"])) >= dtpFromDate.Value && (Convert.ToDateTime(p["التاريخ"]) <= dtpForDate.Value)).CopyToDataTable();
            //    //dgvbills.DataSource = dt_fiter;
            //    //dgvbills.Columns["bill_id"].Visible = false
            //}
            //catch
            //{
            //    ////
            //}
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                billNo = (long)dataGridView1.Rows[e.RowIndex].Cells["bill_id"].Value ;
                using (DataBaseHelper dbh = new DataBaseHelper())
                {
                    dataGridView2.DataSource = dbh.GetSalesBillDetails(billNo);
                    dataGridView2.Columns["sDetail_id"].Visible = false;
                    dataGridView2.Columns["drug_id"].Visible = false;
                }
                int index = e.RowIndex;


                //            select SalesBill.bill_id,SalesBill.bill_Date "تاريخ",SalesBill.bill_total "المجموع",SalesBill.bill_rceiption "التخفيض",
                //bill_total - bill_rceiption "المبلغ المطلوب",SalesBill.payedMony "المبغ المدفوع",bill_total - bill_rceiption - SalesBill.payedMony "المبلغ المتبقي"
                //,Customers.cust_name "العميل",Customers.cust_name "تلفون العميل",Customers.cust_Address "عنوان العميل" ,Users.user_name "المستخدم"
                //  DataGridViewRow selected_row = dataGridView1.Rows[index];
                cbCustomers.Text = dt_bills.Rows[e.RowIndex]["العميل"].ToString();
                txtRemaindMony.Text = dt_bills.Rows[e.RowIndex]["المبلغ المتبقي"].ToString();
                txtTotalAmount.Text = dt_bills.Rows[e.RowIndex]["المبلغ المطلوب"].ToString();
                txtPaidAmount.Text = dt_bills.Rows[e.RowIndex]["المبغ المدفوع"].ToString();
            }

        }
         
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtbillNumber.Text = "";
            txtPaidAmount.Text = "";
            txtRemaindMony.Text = "";
            txtRemaindMony.Text = "";
            cbCustomers.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtbillNumber.Text.Trim().Length == 0)
            {
                lblError.Text = "المبلغ فارغ";
                return;
            }
            int suc = 0;
            using (DataBaseHelper dbh=new DataBaseHelper())
            {
                 suc = dbh.AddNotCashMony(billNo, decimal.Parse(txtbillNumber.Text));
                
            }
            if (suc > 0)
            {
                txtbillNumber.Text = "";
                txtPaidAmount.Text = "";
                txtRemaindMony.Text = "";
                txtRemaindMony.Text = "";
                cbCustomers.Text = "";
                using(DataBaseHelper dbh=new DataBaseHelper())
                {
                    dt_bills = dbh.GetNotCahSalesBill();
                    dataGridView1.DataSource = dt_bills;
                }
                lblError.Text = "تم بنجاح";
            }
        }

        private void cbCustomers_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void cbCustomers_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void cbCustomers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {

                string sf = cbCustomers.Text.Trim();
                if (string.IsNullOrEmpty(cbCustomers.Text))
                {

                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                }
                else
                {
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter 
                        = string.Format("العميل like '%{0}%'", sf);
                    AllDepts();
                }
            }
        }

        private void btnSave_Enter(object sender, EventArgs e)
        {
            Control c = (sender as Control);
            c.BackColor =buttonshover;
        }
        private void AllDepts()
        {
            if (dataGridView1.Rows.Count > 0) { }
            {
                decimal totalDept = 0;
                try
                {
                    foreach(DataGridViewRow row in dataGridView1.Rows)
                    {
                        totalDept +=(decimal)row.Cells["المبلغ المتبقي"].Value;
                    }
                    txtTotalDeptRemaind.Text = totalDept.ToString();
                }
                catch
                {

                }

            }
        }
        private void btnSave_Leave(object sender, EventArgs e)
        {
            Control c = (sender as Control);
            c.BackColor =buttonsbackground;
        }
    }
}
