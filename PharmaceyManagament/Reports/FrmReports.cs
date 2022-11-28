using Microsoft.Reporting.WinForms;
using PharmaceyManagament.Helpers;
using PharmaceyManagament.SalesAndPurchases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaceyManagament.Reports
{
    public partial class FrmReports : Form
    {
        Color backgroundcontainers;
        Color buttonshover;
        Color buttonsbackground;
        Color fontColer;

        private string billType = "";
        private DataTable dt_sales = new DataTable();
        private DataTable dt_purchases = new DataTable();
        private int indexOfBill = 1;
        public FrmReports()
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
                buttonsbackground = System.Drawing.ColorTranslator.FromHtml(bh);
                lblPharmaNme.Text = Properties.Settings.Default.marketName;

            }
            catch
            {

            }


            this.ForeColor = fontColer;
            panel1.BackColor = panel2.BackColor = panel4.BackColor = backgroundcontainers;
            btnAlterBill.BackColor = btnOrderByDate.BackColor = btnSaveAndPrint.BackColor = btnSearchByBiilNumber.BackColor = buttonsbackground;

            //panel3.BackColor = MyCustomColors.m_back4;
            //panel3.ForeColor = MyCustomColors.m_fontColwite;

            //panel2.BackColor = MyCustomColors.m_backLightblack;
            //dgvbills.BackgroundColor = MyCustomColors.m_backPgry;
            //dgvDetails.BackgroundColor= MyCustomColors.m_backPgry;
            //dgvDetails.GridColor = MyCustomColors.m_hover2;
            //dgvbills.GridColor = MyCustomColors.m_hover2;

            //btnSaveAndPrint.BackColor= MyCustomColors.m_backLightblack;
            //btnSearchByBiilNumber.BackColor= MyCustomColors.m_backLightblack;
            //btnOrderByDate.BackColor= MyCustomColors.m_backLightblack; 
            
        }

        private void GetPurchases()
        {
            using(DataBaseHelper dbh=new DataBaseHelper())
            {
                dt_purchases = dbh.GetPurchasesBills();
                dgvbills.DataSource = dt_purchases;
                dgvbills.Columns["bill_id"].Visible = false;
            }
        }
        private void GetSales()
        {
            using(DataBaseHelper dbh=new DataBaseHelper())
            {
                dt_sales = dbh.GetSalesBills();
                dgvbills.DataSource = dt_sales;
                dgvbills.Columns["bill_id"].Visible = false;

            }
        }
        private void GetPurchDetails(long bid)
        {
            using (DataBaseHelper dbh = new DataBaseHelper())
            {
                dgvDetails.DataSource = dbh.GetPurhasesDetailes(bid);
                dgvDetails.Columns["detail_id"].Visible = false;
                dgvDetails.Columns["drug_id"].Visible = false;
            }
        }
        private void GetSalesDetails(long bid)
        {
            using (DataBaseHelper dbh = new DataBaseHelper())
            {
                dgvDetails.DataSource = dbh.GetSalesBillDetails(bid);
                dgvDetails.Columns["sDetail_id"].Visible = false;
                dgvDetails.Columns["drug_id"].Visible = false;
            }
        }
        private void btnSaveAndPrint_Click(object sender, EventArgs e)
        {
            if (dgvDetails.RowCount==0)
            {
                this.lblError.Text = "لا يوجد بيانات للطباعة";
                return;
            }
            if (rbtnPurchases.Checked == true)
            {


                DataTable dt_report = new DataTable();
                foreach (DataGridViewColumn col in dgvDetails.Columns)
                {
                    dt_report.Columns.Add(col.Name);
                }
                foreach (DataGridViewRow row in dgvDetails.Rows)
                {
                    DataRow drow = dt_report.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        drow[cell.ColumnIndex] = cell.Value;
                    }
                    dt_report.Rows.Add(drow);

                }

                decimal totalMony = (decimal)dgvbills.Rows[indexOfBill].Cells["المبلغ المطلوب"].Value;
                decimal  paidm= (decimal)dgvbills.Rows[indexOfBill].Cells["المبغ المدفوع"].Value;
               string  cname= dgvbills.Rows[indexOfBill].Cells["العميل"].Value.ToString();
                string bdate= dgvbills.Rows[indexOfBill].Cells["تاريخ"].Value.ToString();
                SaleBillPrint sbp = new SaleBillPrint();
                ReportDataSource rds = new ReportDataSource("DataSet1", dt_report);
                ReportParameter rp_total = new ReportParameter("saleTotal", totalMony.ToString());
                ReportParameter rp_salerName = new ReportParameter("salerName", CurrentUser.userName);
                ReportParameter rp_remaindMoney = new ReportParameter("remaindMony", (totalMony - paidm).ToString());
                ReportParameter rp_PaidMony = new ReportParameter("paidMony", paidm.ToString());
                ReportParameter rp_CustomerName = new ReportParameter("SalebillCostomer",cname);
                ReportParameter rp_date = new ReportParameter("ReportSallBillDate", bdate);
                sbp.reportViewer1.LocalReport.DataSources.Clear();
                sbp.reportViewer1.LocalReport.DataSources.Add(rds);
                sbp.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp_CustomerName, rp_date, rp_PaidMony, rp_remaindMoney, rp_salerName, rp_total });
                sbp.reportViewer1.RefreshReport();
                sbp.Show();
            }
            if (rbtnSales.Checked == true)
            {
               

                    DataTable dt_report = new DataTable();
                    foreach (DataGridViewColumn col in dgvDetails.Columns)
                    {
                        dt_report.Columns.Add(col.Name);
                    }
                    foreach (DataGridViewRow row in dgvDetails.Rows)
                    {
                        DataRow drow = dt_report.NewRow();
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            drow[cell.ColumnIndex] = cell.Value;
                        }
                        dt_report.Rows.Add(drow);

                    }

                decimal totalMony = (decimal)dgvbills.Rows[indexOfBill].Cells["المجموع"].Value;
                    string supname = dgvbills.Rows[indexOfBill].Cells["المورد"].Value.ToString();
                    string bdate = dgvbills.Rows[indexOfBill].Cells["التاريخ"].Value.ToString();
                    SaleBillPrint sbp = new SaleBillPrint();               
                    ReportDataSource rds = new ReportDataSource("DataSet1", dt_report);
                    ReportParameter rp_total = new ReportParameter("rtotal", totalMony.ToString());                 
                    //ReportParameter rp_remaindMoney = new ReportParameter("remaindMony", (totalMony - paidm).ToString());
                    //ReportParameter rp_PaidMony = new ReportParameter("paidMony", paidm.ToString());
                    ReportParameter rp_suppName = new ReportParameter("rSupplier", supname);
                    ReportParameter rp_date = new ReportParameter("rdate", bdate);
                sbp.reportViewer1.LocalReport.ReportEmbeddedResource = "PharmaceyManagament.ReportPurchasesBill.rdlc";
                sbp.reportViewer1.LocalReport.DataSources.Clear();
                    sbp.reportViewer1.LocalReport.DataSources.Add(rds);
                    sbp.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp_suppName, rp_date, rp_total });
                    sbp.reportViewer1.RefreshReport();
                sbp.Show();

                }

            }

        private void FrmReports_Load(object sender, EventArgs e)
        {
            this.lblCurrentUser.Text = CurrentUser.userName;
          //  this.lblDate.Text = DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss");
            this.lblError.Text = "";
            this.lblError.ForeColor = Color.Red;
            billType = "purchas";
            btnAlterBill.Visible = false;
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

        private void dgvDetails_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void rbtnSales_CheckedChanged(object sender, EventArgs e)
        {
            billType = (rbtnPurchases.Checked == false) ? "purchas" : "sales";
            if(billType== "purchas")
            {
                GetPurchases();
            }
            else
            {
                GetSales();
            }
        }

        private void dgvbills_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (billType == "purchas")
                {
                    long bid = (long)dt_purchases.Rows[e.RowIndex]["bill_id"];
                    GetPurchDetails(bid);

                }
                else
                {
                    long bid = (long)dt_sales.Rows[e.RowIndex]["bill_id"];
                    GetSalesDetails(bid);
                }

                indexOfBill = e.RowIndex;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnOrderByDate_Click(object sender, EventArgs e)
        {
            try
            {
                if (billType == "purchas")
                {


                    DataTable dt_fiter = dt_purchases.Select().Where(p => (Convert.ToDateTime(p["تاريخ"])) >= dtpFromDate.Value && (Convert.ToDateTime(p["تاريخ"]) <= dtpForDate.Value)).CopyToDataTable();
                    dgvbills.DataSource = dt_fiter;
                    dgvbills.Columns["bill_id"].Visible = false;

                }
                else
                {
                    DataTable dt_fiter = dt_sales.Select().Where(p => (Convert.ToDateTime(p["تاريخ"])) >= dtpFromDate.Value && (Convert.ToDateTime(p["تاريخ"]) <= dtpForDate.Value)).CopyToDataTable();
                    dgvbills.DataSource = dt_fiter;
                    dgvbills.Columns["bill_id"].Visible = false;

                }
            }
            catch
            {
                dgvbills.DataSource = null;
            }
        }

        private void txtbillNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbillNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                btnSearchByBiilNumber.Focus();

            }
            if (e.KeyCode == Keys.Tab)
            {
                dgvbills.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
               btnOrderByDate.Focus();
            }
            if (rbtnPurchases.Checked == true && dt_sales.Rows.Count > 0)
            {
                string sf = txtbillNumber.Text.Trim();
                if (string.IsNullOrEmpty(txtbillNumber.Text))
                {

                    (dgvbills.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                }
                else
                {
                    (dgvbills.DataSource as DataTable).DefaultView.RowFilter
                        = string.Format("المورد like '%{0}%'", sf);
                }
            }
            else if (rbtnSales.Checked==true && dt_purchases.Rows.Count > 0) { }
            {
                string sf = txtbillNumber.Text.Trim();
                if (string.IsNullOrEmpty(txtbillNumber.Text))
                {

                    (dgvbills.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                }
                else
                {
                    (dgvbills.DataSource as DataTable).DefaultView.RowFilter
                        = string.Format("العميل  like '%{0}%'", sf);
                }
            }
        }

        private void dgvbills_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSearchByBiilNumber_Click(object sender, EventArgs e)
        {
            if(rbtnPurchases.Checked==true && dt_sales.Rows.Count > 0)
            {

                string sf =txtbillNumber.Text.Trim();
                
                    if (string.IsNullOrEmpty(sf))
                    {

                        (dgvbills.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                    }
                    else
                    {
                        (dgvbills.DataSource as DataTable).DefaultView.RowFilter
                            = string.Format("المورد like '%{0}%'", sf);
                    }
                
            }
            else if (rbtnSales.Checked == true && dt_purchases.Rows.Count > 0) { }
            {
                string sf = txtbillNumber.Text.Trim();
                if (string.IsNullOrEmpty(txtbillNumber.Text))
                {

                    (dgvbills.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                }
                else
                {
                    (dgvbills.DataSource as DataTable).DefaultView.RowFilter
                        = string.Format("العميل like '%{0}%'", sf);
                }
            }
        }

        private void btnOrderByDate_Enter(object sender, EventArgs e)
        {
            Control c = (sender as Control);
            c.BackColor = buttonshover;
        }

        private void btnOrderByDate_Leave(object sender, EventArgs e)
        {
            Control c = (sender as Control);
            c.BackColor = buttonsbackground; ;
        }

        private void btnOrderByDate_MouseHover(object sender, EventArgs e)
        {
            Control c = (sender as Control);
            c.BackColor = buttonshover;
        }

        private void btnOrderByDate_MouseLeave(object sender, EventArgs e)
        {
            Control c = (sender as Control);
            c.BackColor = buttonsbackground;
        }

        private void rbtnSales_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                rbtnPurchases.Focus();

            }
            if(e.KeyCode == Keys.Tab)
            {
                dgvbills.Focus();
            }
        }

        private void rbtnPurchases_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                dtpFromDate.Focus();

            }
            if (e.KeyCode == Keys.Tab)
            {
                dgvbills.Focus();
            }
            if (e.KeyCode == Keys.Up) 
            {
                rbtnSales.Focus();
            }
        }

        private void btnOrderByDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtbillNumber.Focus();

            }
           else if (e.KeyCode == Keys.Tab)
            {
                dgvbills.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                dtpForDate.Focus();
            }
        }

        private void btnSaveAndPrint_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
               rbtnSales.Focus();

            }
            else if (e.KeyCode == Keys.Tab)
            {
                dgvbills.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                btnSearchByBiilNumber.Focus();
            }
        }
    }
}
