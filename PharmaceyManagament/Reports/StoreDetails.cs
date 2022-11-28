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
    public partial class StoreDetails : Form
    {
        private bool flag;
        Color backgroundcontainers;
        Color buttonshover;
        Color buttonsbackground;
        Color fontColer;
        public StoreDetails()
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
                lblPharmaNme.Text = Properties.Settings.Default.marketName;

                panel1.BackColor = panel4.BackColor = backgroundcontainers;
                pannalss.BackColor= backgroundcontainers;
                btnDelete.BackColor = btnSaveAlteration.BackColor = btnSaveAndPrint.BackColor = buttonsbackground;


            }
            catch
            {

            }


            //this.lblDate.ForeColor = MyCustomColors.m_fontColwite;
            //this.lblCurrentUser.ForeColor= MyCustomColors.m_fontColwite;
            //this.lblPharmaNme.ForeColor= MyCustomColors.m_fontColwite;
            //this.lblError.ForeColor = MyCustomColors.m_fontRedColor;
            //this.panel3.BackColor = MyCustomColors.m_back4;
            //this.pannalss.BackColor = MyCustomColors.m_backLightblack;
            //this.BackColor = MyCustomColors.m_back3;
            //this.btnDelete.BackColor = MyCustomColors.m_backLightblack;
            //this.btnSaveAlteration.BackColor = MyCustomColors.m_backLightblack;
            //this.btnSaveAndPrint.BackColor = MyCustomColors.m_backLightblack;
            //dataGridView1.BackgroundColor = MyCustomColors.m_back3;
            //dataGridView1.GridColor = MyCustomColors.m_hover3;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حقاً الالغاء", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                txtDrugExpDate.Text = "";
                txtDrugQuantiy.Text = "";
                txtDrugSalePrice.Text = "";
                cbDrugCompany.Text = "";
                cbDrugeType.Text = "";
                cbDrugNames.Text = "";
                  //      /// 
            }
            else
            {
                return;
            }
        }

        private void btnSaveAlteration_Click(object sender, EventArgs e)
        {
            if(txtDrugSalePrice.Text.Trim().Length == 0 ||txtDrugQuantiy.Text.Trim().Length == 0||txtDrugExpDate.Text.Trim().Length == 0||
                cbDrugCompany.Text.Trim().Length == 0||cbDrugNames.Text.Trim().Length == 0||
                cbDrugeType.Text.Trim().Length == 0 ||cbDrugNames.SelectedIndex==-1 || cbDrugNames.SelectedValue == null)
            {
                lblError.Text = "هناك بعض الاخطاء";
                return;
            }
            else
            {
                try
                {
                    long id =(long) cbDrugNames.SelectedValue;
                    using(DataBaseHelper dbh=new DataBaseHelper())
                    {
                        int resu = dbh.UpdateDData(id, cbDrugNames.Text, cbDrugeType.Text, cbDrugCompany.Text, int.Parse(txtDrugQuantiy.Text), decimal.Parse(txtDrugSalePrice.Text), txtDrugExpDate.Text);
                        if (resu > 0)
                        {
                            lblError.Text = "تم التعديل";
                        }
                        else
                        {
                            lblError.Text = "لم يتم التعديل";
                        }
                    }
                }
                catch
                {
                    lblError.Text = "حصل خطا اثناءالتعديل";
                }
            }
        }

        private void btnSaveAndPrint_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                DataTable dt_report = new DataTable();
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    dt_report.Columns.Add(col.Name);
                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    DataRow drow = dt_report.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        drow[cell.ColumnIndex] = cell.Value;
                    }
                    dt_report.Rows.Add(drow);

                }


                //////////

                SaleBillPrint sbp = new SaleBillPrint();
                ReportDataSource rds = new ReportDataSource("DataSet1", dt_report);
                sbp.reportViewer1.Reset();

                //ReportParameter rp_total = new ReportParameter("saleTotal", totalMony.ToString());
                //ReportParameter rp_salerName = new ReportParameter("salerName", CurrentUser.userName);
                //ReportParameter rp_remaindMoney = new ReportParameter("remaindMony", (totalMony - paidm).ToString());
                //ReportParameter rp_PaidMony = new ReportParameter("paidMony", paidm.ToString());
                //ReportParameter rp_CustomerName = new ReportParameter("SalebillCostomer", cbCustomerName.Text);
                ReportParameter rp_date = new ReportParameter("rDate", lblDate.Text);
                sbp.reportViewer1.LocalReport.ReportEmbeddedResource = "PharmaceyManagament.reportStoredetails.rdlc";
                sbp.reportViewer1.LocalReport.DataSources.Clear();
                sbp.reportViewer1.LocalReport.DataSources.Add(rds);
                sbp.reportViewer1.LocalReport.SetParameters(new ReportParameter[] {rp_date});
                sbp.reportViewer1.RefreshReport();
                sbp.Show();
            }
        }

        private void btnSaveBill_Click(object sender, EventArgs e)
        {

        }

        private void StoreDetails_Load(object sender, EventArgs e)
        {
            //this.lblDate.Text = DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss");
            this.lblError.ForeColor = Color.Red;
            this.lblError.Text = "";
            this.lblCurrentUser.Text = CurrentUser.userName;
            using(DataBaseHelper dbh=new DataBaseHelper())
            {
                DataTable dt = new DataTable();
                dt = dbh.GetAllDrugsDetails();
                dataGridView1.DataSource =dt;
                cbDrugNames.DataSource = dt;
                cbDrugNames.DisplayMember = "الصنف";
                cbDrugNames.ValueMember = "drug_id";
                dataGridView1.Columns["drug_id"].Visible = false;
            }
            
        }

//select drug_id, drug_name "اسم الصنف",drug_type "النوع",companyName "الشركة",drug_quantity "الكمية",drug_sale_price "سعر الوحدة"
        
        //private void ShowIdatGView(int x)
        //{
        //    if (x == 0)
        //    {
        //        using(DataBaseHelper dbh=new DataBaseHelper)
        //        {
        //            dataGridView1.data
        //        }
        //    }
        //}
        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss");

        }

        private void cbDrugNames_KeyDown(object sender, KeyEventArgs e)
        {
            string sf = cbDrugNames.Text.Trim();
            if(e.KeyCode==Keys.Space || e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(cbDrugNames.Text))
                {

                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                }
                else
                {
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter
                        = string.Format("اسم الصنف like '%{0}%'", sf);
                }
            }
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                try
                {
                    int rindex = e.RowIndex;

                    txtDrugExpDate.Text = dataGridView1.Rows[rindex].Cells["تاريخ_الاتهاء"].Value.ToString();
                    txtDrugQuantiy.Text = dataGridView1.Rows[rindex].Cells["الكمية"].Value.ToString();
                    txtDrugSalePrice.Text = dataGridView1.Rows[rindex].Cells["السعر"].Value.ToString();
                    cbDrugCompany.Text = dataGridView1.Rows[rindex].Cells["الشركة"].Value.ToString();
                    cbDrugNames.SelectedValue = dataGridView1.Rows[rindex].Cells["drug_id"].Value;
                    cbDrugNames.Text = dataGridView1.Rows[rindex].Cells["الصنف"].Value.ToString();
                    cbDrugeType.Text = dataGridView1.Rows[rindex].Cells["النوع"].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtDrugQuantiy_KeyDown(object sender, KeyEventArgs e)
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

        private void txtDrugQuantiy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = flag;
        }

        private void btnSaveAlteration_MouseHover(object sender, EventArgs e)
        {
            btnSaveAlteration.BackColor = buttonshover;
        }

        private void btnSaveAlteration_MouseLeave(object sender, EventArgs e)
        {
            
            btnSaveAlteration.BackColor =buttonsbackground;
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            btnDelete.BackColor = buttonshover;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
           btnDelete.BackColor= buttonsbackground;
        }

        private void btnSaveAndPrint_MouseHover(object sender, EventArgs e)
        {
            btnSaveAndPrint.BackColor =buttonshover;
        }

        private void btnSaveAndPrint_MouseLeave(object sender, EventArgs e)
        {
            btnSaveAndPrint.BackColor=buttonsbackground;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
