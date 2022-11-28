using Microsoft.Reporting.WinForms;
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
    public partial class Sales : Form
    {
        private bool flag;
        private DataTable dt_cutomers = new DataTable();
        private  DataTable dt_drugs = new DataTable();
        private int custID = 0;
        private DataTable dt_view = new DataTable();
        private decimal totalMony = 0;
        private decimal reqMony = 0;
        private decimal payidMony = 0;
        private decimal oneDprice = 0;
        Color backgroundcontainers;
        Color buttonshover;
        Color buttonsbackground;
        Color fontColer;

        public Sales()
        {
            InitializeComponent();
            this.txtCustomerPhone.KeyPress += TxtCustomerPhone_KeyPress;



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

                this.ForeColor = fontColer;

                lblPharmaNme.Text = Properties.Settings.Default.marketName;

                panel2.BackColor = panel1.BackColor = groupBox1.BackColor = groupBox2.BackColor = backgroundcontainers;

                btnSaveBill.BackColor = btnSaveAndPrint.BackColor = btnDelete.BackColor = btnAddtobill.BackColor = buttonsbackground;

            }
            catch
            {

            }

            //this.lblCheckQuntity.ForeColor = MyCustomColors.m_fontRedColor;
            //// lblDate.ForeColor = MyCustomColors.m_fontColwite;
            //// lblPharmaNme.ForeColor = MyCustomColors.m_fontColwite;
            //// lblCurrentUser.ForeColor= MyCustomColors.m_fontColwite;
            //lblErrorsMessage.ForeColor = MyCustomColors.m_fontRedColor;

            //panel3.BackColor = MyCustomColors.m_back4;
            //panel3.ForeColor = MyCustomColors.m_fontColwite;
            //panel2.BackColor = MyCustomColors.m_back2;
            //dataGridView1.BackgroundColor = MyCustomColors.m_backPgry;
            //dataGridView1.GridColor = MyCustomColors.m_hover3;
            //this.BackColor = MyCustomColors.m_back3;
            //btnAddtobill.BackColor= MyCustomColors.m_back2;
            //btnDelete.BackColor= MyCustomColors.m_back2;
            //btnSaveAndPrint.BackColor= MyCustomColors.m_back2;
            //btnSaveBill.BackColor= MyCustomColors.m_back2;


        }

        private void TxtCustomerPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = flag;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sales_Load(object sender, EventArgs e)
        {
            this.lblCurrentUser.Text = CurrentUser.userName;
           // this.lblDate.Text = DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss");
            this.lblErrorsMessage.ForeColor = Color.Red;
            this.lblErrorsMessage.Text = "";

            using(DataBaseHelper dbh=new DataBaseHelper())
            {
                dt_cutomers = dbh.Getcustomers();
                dt_drugs = dbh.GetAllDrugsDetails();
                cbCustomerName.DataSource = dt_cutomers;
                cbDrugName.DataSource = dt_drugs;
                cbCustomerName.DisplayMember = "اسم_العميل";
                cbCustomerName.ValueMember = "cust_id";
                cbDrugName.DisplayMember = "الصنف";
                cbDrugName.ValueMember = "drug_id";
            }
         


            
        
            dt_view.Columns.Add("drug_id", typeof(long));
            dt_view.Columns.Add("العميل", typeof(string));
            dt_view.Columns.Add("الصنف", typeof(string));
            dt_view.Columns.Add("النوع", typeof(string));
            dt_view.Columns.Add("الشركة ", typeof(string));
            dt_view.Columns.Add("الكمية", typeof(int));
            dt_view.Columns.Add("السعر", typeof(decimal));
            dt_view.Columns.Add("الاجمالي ", typeof(decimal));
          

        }
        private void GetCats()
        {
            using (DataBaseHelper dbh = new DataBaseHelper())
            {
                dt_drugs = dbh.GetAllDrugsDetails();       
                cbDrugName.DataSource = dt_drugs;
                cbDrugName.DisplayMember = "الصنف";
                cbDrugName.ValueMember = "drug_id";
            }

        }
        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtCustomerPhone_KeyDown(object sender, KeyEventArgs e)
        {

            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) || e.KeyCode == Keys.Back)
            {
                flag = false;
            }
            //if(e.KeyCode==Keys.Enter || e.KeyCode == Keys.Left || e.KeyCode == Keys.Tab)
            //{
            //    txtCustomerAddress.Focus();
            //}
            //if(e.KeyCode == Keys.Right)
            //{
            //    cbCustomerName.Focus();
            //}
            else
            {
                flag = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss");

        }
        
        private void cbCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCustomerAddress.Text= dt_cutomers.Rows[cbCustomerName.SelectedIndex]["العنوان"].ToString();
            txtCustomerPhone.Text = dt_cutomers.Rows[cbCustomerName.SelectedIndex]["تلفون"].ToString();
        }
      
        
       int dcount = 0;
        private void cbDrugName_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            cbCompany.Text = dt_drugs.Rows[cbDrugName.SelectedIndex]["الشركة"].ToString();
            cbDrugType.Text = dt_drugs.Rows[cbDrugName.SelectedIndex]["النوع"].ToString();
            oneDprice =(decimal) dt_drugs.Rows[cbDrugName.SelectedIndex]["السعر"];
            dcount = (int)(dt_drugs.Rows[cbDrugName.SelectedIndex]["الكمية"]);
            txtTotal.Text =(oneDprice * nudCounts.Value).ToString();
            
            nudCounts.Maximum = dcount;

        }

        private void nupCounts_ValueChanged(object sender, EventArgs e)
        {
            if (nudCounts.Value == dcount)
            {
                lblCheckQuntity.Text = "هذا مقدار الكمية الموجودة";
            }
            txtTotal.Text = (nudCounts.Value * oneDprice).ToString();
           
        }

        private void txtReduction_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty( txtReduction.Text)||txtReduction.Text==".0" || txtReduction.Text == ".")
                {
                    txtDueMoney.Text = (reqMony - 0).ToString();                }
                else
                {
                    txtDueMoney.Text = (reqMony - decimal.Parse(txtReduction.Text)).ToString();
                }
            }
            catch
            {

            }
           
        }


        //decimal redict = 0;
        private void btnAddtobill_Click(object sender, EventArgs e)
        {
            //select drug_id, drug_name "اسم الصنف",drug_type "النوع",companyName "الشركة",drug_quantity "الكمية",drug_sale_price "سعر الوحدة"

          

            if (cbDrugName.SelectedIndex == -1|| txtCustomerPhone.Text.Trim().Length==0 || cbCustomerName.SelectedValue == null)
            {
                
                    lblErrorsMessage.Text = "فضلا احفظ بيانات الزبون";
                return;

                //lblErrorsMessage.Text = "الصنف غير موجود";
            }
            if (cbCustomerName.SelectedIndex != -1 )
            {
                custID = (int)cbCustomerName.SelectedValue;
            }
            
            if (cbDrugName.SelectedValue==null||cbDrugName.SelectedIndex == -1 || cbCompany.Text.Trim().Length==0|| cbDrugType.Text.Trim().Length == 0)
            {
                lblErrorsMessage.Text = "الصنف غير موجود او ان  البيانات خطا";
                return;
            }

            if (nudCounts.Value==0 || nudCounts.Value>dcount)
            {

                lblErrorsMessage.Text = "خطا في الكمية";
                return;

            }
            if (cbCustomerName.SelectedIndex!=0)
            {
                try
                {
                    custID = (int)cbCustomerName.SelectedValue;
                }
                catch
                {
                    ///
                }
               

              
            }

          
            totalMony = (oneDprice * nudCounts.Value);
            txtTotal.Text = totalMony.ToString();
            reqMony += totalMony;
            txtDueMoney.Text = reqMony.ToString();
           // MessageBox.Show(cbDrugName.SelectedValue.ToString());
            int rind = cbDrugName.SelectedIndex;
            if (rind == -1)
            {
                lblErrorsMessage.Text = "خطأ";
                return;
            }
            int cou = (int)nudCounts.Value;
            int remd = dcount - cou;
            dt_drugs.Rows[rind]["الكمية"] = remd;
            dt_view.Rows.Add((long)cbDrugName.SelectedValue, cbCustomerName.Text, cbDrugName.Text, cbDrugType.Text, cbCompany.Text, int.Parse(nudCounts.Value.ToString()), oneDprice, oneDprice * nudCounts.Value);

            dataGridView1.DataSource = dt_view;
            dataGridView1.Columns["drug_id"].Visible = false;


            this.txtReduction.ReadOnly = false;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txtCustomerPhone.Text.Trim().Length != 0 && cbCustomerName.Text.Trim().Length!=0)
            {

                using(DataBaseHelper dbh=new DataBaseHelper())
                {
                    //try
                    //{
                        custID = dbh.AddCustomer(cbCustomerName.Text, txtCustomerPhone.Text, txtCustomerAddress.Text);
                        pictureBox2.Visible = false;
                        pictureBox3.Visible = true;
                    //}
                    //catch
                    //{
                    //    custID = 1;
                    //}
                }
                using (DataBaseHelper dbh = new DataBaseHelper())
                {
                    dt_cutomers = dbh.Getcustomers();                  
                    cbCustomerName.DataSource = dt_cutomers;
                    cbCustomerName.ValueMember = "cust_id";
                    cbCustomerName.DisplayMember = "اسم_العميل";
                    cbCustomerName.SelectedValue = custID;
                }
                    return;
                
            }
            lblErrorsMessage.Text = "البيانات ناقصة";
        }
        long salBillId = 0;
        string billType = "";
        private void btnSaveBill_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
            if (dataGridView1.Rows.Count == 0)
            {
                lblErrorsMessage.Text = "الفاتورة فارغة";
                return;
            }
            if (rbtnCash.Checked ==false && rbtnDebt.Checked == false)
            {
                lblErrorsMessage.Text = "اختر نوع الفاتورة";
                return;
            }
            if (decimal.Parse(txtReduction.Text) > decimal.Parse(txtTotal.Text))
            {
                lblErrorsMessage.Text = "التخفيض اكبر من القيمة";
                return;
            }
           
                try
                {
                    using (DataBaseHelper dbh = new DataBaseHelper())
                    {
                        salBillId = dbh.GetLastSalillID() + 1;
                    }
                }


                catch
                {
                    salBillId = 1;
                }
            
           
            totalMony = 0;
            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
              totalMony+=  (int.Parse(dataGridView1.Rows[row].Cells[5].Value.ToString()) * decimal.Parse(dataGridView1.Rows[row].Cells[6].Value.ToString()));

            }

                billType = (rbtnCash.Checked == true) ? "cash" : "notcash";

                decimal paidm = (billType == "cash") ? totalMony : decimal.Parse(txtPaidMony.Text);
                try
                {
               
                   // MessageBox.Show(salBillId.ToString());
                    using (DataBaseHelper dbh = new DataBaseHelper())
                    {
                        int ss = dbh.AddSaleBill(DateTime.Now.ToString(), totalMony,
                            decimal.Parse(txtReduction.Text), custID, billType, CurrentUser.userID, paidm);
                     
                      
                   
                        for (int row = 0; row < dataGridView1.Rows.Count; row++)
                        {
                        
                            int d = dbh.AddSaleBillDetails(salBillId, long.Parse(dataGridView1.Rows[row].Cells[0].Value.ToString()), dataGridView1.Rows[row].Cells[3].Value.ToString(), int.Parse(dataGridView1.Rows[row].Cells[5].Value.ToString()), decimal.Parse(dataGridView1.Rows[row].Cells[6].Value.ToString()));

                        }
                    }

                reqMony = 0;
                totalMony = 0;
                dt_view.Rows.Clear();
                txtReduction.Text = "0";
                GetCats();
               
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);


                }
            


            }

        private void rbtnDebt_CheckedChanged(object sender, EventArgs e)
        {
            this.txtPaidMony.ReadOnly = (txtPaidMony.ReadOnly == true) ? false : true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("هل تريد حقاً الغاء الفاتورة", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                dt_view.Rows.Clear();
                dataGridView1.DataSource = dt_view;
                dataGridView1.Columns["drug_id"].Visible=false;
            }
            else
            {
                return;
            }
         
        }

        private void btnSaveAlteration_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnSaveAndPrint_Click(object sender, EventArgs e)
        {

            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
            if (dataGridView1.Rows.Count == 0)
            {
                lblErrorsMessage.Text = "الفاتورة فارغة";
                return;
            }
            if (rbtnCash.Checked == false && rbtnDebt.Checked == false)
            {
                lblErrorsMessage.Text = "اختر نوع الفاتورة";
                return;
            }
            if (decimal.Parse(txtReduction.Text) > decimal.Parse(txtTotal.Text))
            {
                lblErrorsMessage.Text = "التخفيض اكبر من القيمة";
                return;
            }

            try
            {
                using (DataBaseHelper dbh = new DataBaseHelper())
                {
                    salBillId = dbh.GetLastSalillID() + 1;
                }
            }


            catch
            {
                salBillId = 1;
            }


            totalMony = 0;
            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                totalMony += (int.Parse(dataGridView1.Rows[row].Cells[5].Value.ToString()) * decimal.Parse(dataGridView1.Rows[row].Cells[6].Value.ToString()));

            }

            billType = (rbtnCash.Checked == true) ? "cash" : "notcash";

            decimal paidm = (billType == "cash") ? totalMony : decimal.Parse(txtPaidMony.Text);
            try
            {

                // MessageBox.Show(salBillId.ToString());
                using (DataBaseHelper dbh = new DataBaseHelper())
                {
                    int ss = dbh.AddSaleBill(DateTime.Now.ToString(), totalMony,
                        decimal.Parse(txtReduction.Text), custID, billType, CurrentUser.userID, paidm);



                    for (int row = 0; row < dataGridView1.Rows.Count; row++)
                    {

                        int d = dbh.AddSaleBillDetails(salBillId, long.Parse(dataGridView1.Rows[row].Cells[0].Value.ToString()), dataGridView1.Rows[row].Cells[3].Value.ToString(), int.Parse(dataGridView1.Rows[row].Cells[5].Value.ToString()), decimal.Parse(dataGridView1.Rows[row].Cells[6].Value.ToString()));

                    }
                }

                DataTable dt_report = new DataTable();
                foreach(DataGridViewColumn col in dataGridView1.Columns)
                {
                    dt_report.Columns.Add(col.Name);
                }
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    DataRow drow =dt_report.NewRow();
                        foreach(DataGridViewCell cell in row.Cells)
                    {
                        drow[cell.ColumnIndex] = cell.Value;
                    }
                    dt_report.Rows.Add(drow);

                }

                
                SaleBillPrint sbp = new SaleBillPrint();
                ReportDataSource rds = new ReportDataSource("DataSet1",dt_report);
                ReportParameter rp_total = new ReportParameter("saleTotal", totalMony.ToString());
                ReportParameter rp_salerName = new ReportParameter("salerName", CurrentUser.userName);
                ReportParameter rp_remaindMoney = new ReportParameter("remaindMony", (totalMony - paidm).ToString());
                ReportParameter rp_PaidMony = new ReportParameter("paidMony", paidm.ToString());
                ReportParameter rp_CustomerName = new ReportParameter("SalebillCostomer", cbCustomerName.Text);
                ReportParameter rp_date = new ReportParameter("ReportSallBillDate", lblDate.Text);
                sbp.reportViewer1.LocalReport.DataSources.Clear();
                sbp.reportViewer1.LocalReport.DataSources.Add(rds);
                sbp.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp_CustomerName, rp_date, rp_PaidMony, rp_remaindMoney, rp_salerName, rp_total });
                sbp.reportViewer1.RefreshReport();
                ///  sbp.reportViewer1.LocalReport.Refresh();
                sbp.Show();
                reqMony = 0;
                totalMony = 0;
                txtReduction.Text = "0";
                dt_view.Rows.Clear();
                GetCats();

                //sbp.Show();

            }
            catch (Exception ex){

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnAddtobill_Enter(object sender, EventArgs e)
        {
            
            Control c = (sender as Control);
            c.BackColor =buttonshover;
        }

        private void btnAddtobill_Leave(object sender, EventArgs e)
        {

            Control c = (sender as Control);
            c.BackColor = buttonsbackground;
        }



        private void cbDrugName_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbCustomerName_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void cbCustomerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                cbDrugName.Focus();
            }
            else if (e.KeyCode == Keys.Left||e.KeyCode==Keys.Tab)
            {
                txtCustomerPhone.Focus();
            }
        }

        private void txtCustomerAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Tab || e.KeyCode == Keys.Left)
            {
                pictureBox2.Focus();
            }
        }

        private void cbDrugName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left || e.KeyCode == Keys.Tab)
            {
               nudCounts.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                cbCustomerName.Focus();
            }
        }

        private void cbCompany_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Tab)
            {
                nudCounts.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                cbDrugType.Focus();
            }
        }

        private void nudCounts_MouseDown(object sender, MouseEventArgs e)
        {
            

        }

        private void nudCounts_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Enter|| e.KeyCode == Keys.Tab || e.KeyCode == Keys.Left) { }
            {
                btnAddtobill.Focus();
            }
            if (e.KeyCode == Keys.Down )
            {
                nudCounts.Value -= 1;
            }
            if (e.KeyCode == Keys.Up)
            {
                nudCounts.Value += 1;
            }
            if (e.KeyCode == Keys.Right)
            {
                cbDrugName.Focus();
            }
        }

        private void cbDrugType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                cbDrugName.Focus();
            }
            else if (e.KeyCode == Keys.Left|| e.KeyCode == Keys.Right)
            {
                cbCompany.Focus();
            }
        }

        private void btnAddtobill_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left|| e.KeyCode == Keys.Tab)
            {
                btnSaveBill.Focus();
            }
           else if (e.KeyCode == Keys.Right|| e.KeyCode == Keys.Up)
            {
                cbDrugName.Focus();
            }
        }

        private void btnSaveBill_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Tab)
            {
               btnSaveAndPrint.Focus();
            }
            else if (e.KeyCode == Keys.Right )
            {
                btnAddtobill.Focus();
            }
        }

        private void btnSaveAndPrint_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Tab)
            {
                btnDelete.Focus();
            }
            else if (e.KeyCode == Keys.Right )
            {
                btnSaveBill.Focus();
            }

        }

        private void btnDelete_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Tab)
            {
                cbDrugName.Focus();
            }
            else if (e.KeyCode == Keys.Right )
            {
                btnSaveAndPrint.Focus();
            }
        }

        private void txtCustomerPhone_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = flag;
        }
    }
}
