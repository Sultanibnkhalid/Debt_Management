using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmaceyManagament.SalesAndPurchases;
using PharmaceyManagament.Reports;
using PharmaceyManagament.Helpers;
using System.IO;

namespace PharmaceyManagament
{
    public partial class Form1 : Form
    {
        Color backgroundcontainers;
        Color buttonshover;
        Color buttonsbackground;
        Color fontColer;
        public Form1()
        {
            InitializeComponent();

            try {

                 backgroundcontainers = Properties.Settings.Default.containerscolor;
                fontColer = Properties.Settings.Default.fontcolors;

                var bb = Properties.Settings.Default.buttonscolors;
                var bh = Properties.Settings.Default.buttonshover;
                buttonshover = System.Drawing.ColorTranslator.FromHtml(bh);
                buttonsbackground = System.Drawing.ColorTranslator.FromHtml(bb);
                lblPharmaNme.Text = Properties.Settings.Default.marketName;
                
                

            }
            catch
            {

            }

            panel1.BackColor = panel2.BackColor = backgroundcontainers;
            btnAbout.BackColor = btnAddDrugs.BackColor = btnAddnotification.BackColor = btnAddSuplier.BackColor = btnAddUser.BackColor = btnClose.BackColor = btnDataOfStore.BackColor = btnREports.BackColor = btnSaleDrugs.BackColor = btnSessions.BackColor = btnShowCustomersData.BackColor = btnSwitchUser.BackColor = buttonsbackground;
            this.ForeColor = fontColer;
            
            //    panel3.BackColor = MyCustomColors.m_back4;
            //    panel3.ForeColor = MyCustomColors.m_fontColwite;

            //    panel1.BackColor = MyCustomColors.m_backLightblack2;
            //    panel1.ForeColor = MyCustomColors.m_fontCol1;
            //    panel2.BackColor = MyCustomColors.m_backLightblack;
            //    splitContainer1.BackColor = MyCustomColors.m_backLightblack2;
            //    splitContainer2.BackColor = MyCustomColors.m_back5;

            //    groupBox1.BackColor = MyCustomColors.m_backlightaqua;
            //    groupBox2.BackColor = MyCustomColors.m_backlightaqua;
            //    groupBox1.ForeColor = Color.Black;
            //    groupBox2.ForeColor = Color.Black;

            //    btnAddDrugs.BackColor = MyCustomColors.m_backLightblack2;
            //    btnAddSuplier.BackColor = MyCustomColors.m_backLightblack2;
            //    btnAddUser.BackColor = MyCustomColors.m_backLightblack2;

            //    btnClose.BackColor = MyCustomColors.m_backLightblack2;
            //    btnDataOfStore.BackColor = MyCustomColors.m_backLightblack2;
            //    btnREports.BackColor = MyCustomColors.m_backLightblack2;
            //    btnSaleDrugs.BackColor = MyCustomColors.m_backLightblack2;
            //    btnShowCustomersData.BackColor = MyCustomColors.m_backLightblack2;
            //    btnSwitchUser.BackColor = MyCustomColors.m_backLightblack2;
            //    btnAddnotification.BackColor = MyCustomColors.m_backLightblack2;
            //    btnAbout.BackColor = MyCustomColors.m_backLightblack2;



            //    btnAddDrugs.ForeColor = MyCustomColors.m_fontColwite;
            //    btnAddSuplier.ForeColor = MyCustomColors.m_fontColwite;
            //    btnAddUser.ForeColor = MyCustomColors.m_fontColwite;

            //    btnClose.ForeColor = MyCustomColors.m_fontColwite;
            //    btnDataOfStore.ForeColor = MyCustomColors.m_fontColwite;
            //    btnREports.ForeColor = MyCustomColors.m_fontColwite;
            //    btnSaleDrugs.ForeColor = MyCustomColors.m_fontColwite;
            //    btnShowCustomersData.ForeColor = MyCustomColors.m_fontColwite;
            //    btnSwitchUser.ForeColor = MyCustomColors.m_fontColwite;
            //    btnAddnotification.ForeColor = MyCustomColors.m_fontColwite;
            //    btnAbout.ForeColor = ForeColor = MyCustomColors.m_fontColwite;
            //
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {

            Registring registring = new Registring();
            this.Hide();
            registring.ShowDialog();

        }

        private void btnAddnotification_Click(object sender, EventArgs e)
        {
            Notes n = new Notes();
            n.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("هل تريد حقاً الخروج", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                MemoryStream ma;
                var mb =Convert.FromBase64String(Properties.Settings.Default.marketPicter);
                 ma= new MemoryStream(mb);
                pbMaketPics.Image = Image.FromStream(ma);

            }
            catch
            {

            }

            //if (CurrentUser.userName == "")
            //{
            //    Login login = new Login();
            //    login.ShowDialog();
            //}

            this.lblCurrentUser.Text = CurrentUser.userName;
            this.btnSwitchUser.Text = CurrentUser.userName;
            //this.lblDate.Text = DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss");
            
            if (CurrentUser.userType == 1)
            {
                try {
                    using (DataBaseHelper dbh = new DataBaseHelper())
                    {
                        cbUsers.DataSource = dbh.GetUsers();
                        cbUsers.DisplayMember = "user_name";
                        cbUsers.ValueMember = "user_id";
                        cbUsers.SelectedValue = CurrentUser.userID;

                    }
                    getAllSalesTody();
                    getAllSalesTodyforUser(CurrentUser.userID);
                }
                catch
                {

                }
            }
            if (CurrentUser.userType == 0)
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                btnAddDrugs.Enabled = false;
                btnAddUser.Enabled = false;
                btnDataOfStore.Enabled = false;
                btnREports.Enabled = false;

                cbUsers.Text = CurrentUser.userName;
                getAllSalesTodyforUser(CurrentUser.userID);
            }










        }

        private void btnSwitchUser_Click(object sender, EventArgs e)
        {
           
            using (DataBaseHelper dbh = new DataBaseHelper())
            {
                int d = dbh.AddLogoutDate(CurrentUser.logoiD, DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss"));
            }
            Login login = new Login();
            login.ShowDialog();
        }

        private void btnAddDrugs_Click(object sender, EventArgs e)
        {

            SalesAndPurchases.Drugs drug = new SalesAndPurchases.Drugs();
            drug.ShowDialog();
        }

        private void btnAddSuplier_Click(object sender, EventArgs e)
        {
            SalesAndPurchases.Suppliers suppleir = new SalesAndPurchases.Suppliers();
            suppleir.ShowDialog();
        }

        private void btnDataOfStore_Click(object sender, EventArgs e)
        {
            Reports.StoreDetails storedeails = new Reports.StoreDetails();
            storedeails.ShowDialog();
        }

        private void btnSaleDrugs_Click(object sender, EventArgs e)
        {
            SalesAndPurchases.Sales sales = new SalesAndPurchases.Sales();
            sales.ShowDialog();
        }

        private void btnShowCustomersData_Click(object sender, EventArgs e)
        {
            SalesAndPurchases.Depts depts = new SalesAndPurchases.Depts();
            depts.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.FormOwnerClosing || e.CloseReason == CloseReason.UserClosing)
            {
                if(MessageBox.Show("هل تريد الاغلاق ", "رسالة", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
                else
                {
                    using (DataBaseHelper dbh = new DataBaseHelper())
                    {
                        int d = dbh.AddLogoutDate(CurrentUser.logoiD, DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss"));
                    }
                    e.Cancel = false;
                }
            }
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss");
        }

        private void btnREports_Click(object sender, EventArgs e)
        {
            Reports.FrmReports frmreport = new Reports.FrmReports();
            frmreport.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private  void btnBackUp_Click(object sender, EventArgs e)
        {

        }

        private void btnSaleDrugs_Enter(object sender, EventArgs e)
        {

            Control c = (sender as Control);
            c.BackColor =buttonshover;
        }

        private void btnSaleDrugs_Leave(object sender, EventArgs e)
        {

            Control c = (sender as Control);
            c.BackColor =buttonsbackground;
        }


        private void getAllSales()
        {
            try
            {
                DataTable dt = new DataTable();
                using (DataBaseHelper dbh = new DataBaseHelper())
                {
                    dt = dbh.GetTotalOfSales();
                }
                decimal total = (decimal)dt.Rows[0]["total"];
                decimal cash = (decimal)dt.Rows[0]["cash"];
                decimal debt = total - cash;
                if (debt < 0)
                {
                    debt = 0;
                }
                txtCasheSales.Text = cash.ToString();
                txtTatalSales.Text = total.ToString();
                txtDeptSales.Text = debt.ToString();

            }
            catch
            {
                txtCasheSales.Text = "";
                txtTatalSales.Text = "";
                txtDeptSales.Text = "";
            }

        }
        private void getAllSalesTody()
        {
            try
            {
                string sdate = DateTime.Now.ToShortDateString();
                DataTable dt = new DataTable();
                sdate = sdate.Substring(0, 10);
                using (DataBaseHelper dbh = new DataBaseHelper())
                {
                    dt = dbh.GetTotalOfSalesToday(sdate);
                }
                decimal total = (decimal)dt.Rows[0]["total"];
                decimal cash = (decimal)dt.Rows[0]["cash"];
                decimal debt = total - cash;
                if (debt < 0)
                {
                    debt = 0;
                }
                txtCasheSales.Text = cash.ToString();
                txtTatalSales.Text = total.ToString();
                txtDeptSales.Text = debt.ToString();

            }
            catch
            {
                
                txtCasheSales.Text = "";
                txtTatalSales.Text = "";
                txtDeptSales.Text = "";
            }
        }

        private void getAllSalesTodyforUser(int uid)
        {
            try
            {
                string sdate = DateTime.Now.ToShortDateString();
                DataTable dt = new DataTable();
                sdate = sdate.Substring(0, 10);
                using (DataBaseHelper dbh = new DataBaseHelper())
                {
                    dt = dbh.GetTotalOfSalesByUserTody(uid,sdate);
                }
                decimal total = (decimal)dt.Rows[0]["total"];
                decimal cash = (decimal)dt.Rows[0]["cash"];
                decimal debt = total - cash;

                txtUserCashSales.Text = cash.ToString();
                if (debt < 0)
                {
                    debt = 0;
                }
                txtUserDept.Text = debt.ToString();

            }
            catch
            {
                txtUserCashSales.Text = "";

                txtUserDept.Text = "";
            }
        }

        private void getAllSalesByUser(int uid)
        {
            try
            {
                string sdate = DateTime.Now.ToString();
                sdate = sdate.Substring(0, 10);
                DataTable dt = new DataTable();
                using (DataBaseHelper dbh = new DataBaseHelper())
                {
                    dt = dbh.GetTotalOfSalesByUser(uid);
                }
                decimal total = (decimal)dt.Rows[0]["total"];
                decimal cash = (decimal)dt.Rows[0]["cash"];
                decimal debt = total - cash;

                txtUserCashSales.Text = cash.ToString();
                if (debt < 0)
                {
                    debt = 0;
                }
                txtUserDept.Text = debt.ToString();

            }
            catch
            {
                txtUserDept.Text = "";
                txtUserCashSales.Text = "";
            }

        }

        private void rbtnUAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnUtody.Checked)
            {
                getAllSalesTodyforUser(int.Parse(cbUsers.SelectedValue.ToString()));
            }
            if (rbtnUAll.Checked == true)
            {
                getAllSalesByUser(int.Parse(cbUsers.SelectedValue.ToString()));
            }
        }

        private void rbtnAllDays_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAllDays.Checked == true)
            {
                getAllSales();
            }
            if (rbtnToday.Checked == true)
            {
                getAllSalesTody();
            }
        }

        private void cbUsers_SelectedValueChanged(object sender, EventArgs e)
        {
            try {
                if (rbtnUAll.Checked == true)
                {
                    getAllSalesByUser((int)cbUsers.SelectedValue);
                }
                if (rbtnUtody.Checked == true)
                {
                    getAllSalesTodyforUser(int.Parse(cbUsers.SelectedValue.ToString()));
                }
            }
            catch
            {
                //////
            }
        }

        private void pbBack_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("هل تريد حقاً الخروج", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                using (DataBaseHelper dbh = new DataBaseHelper())
                {
                    int d = dbh.AddLogoutDate(CurrentUser.logoiD, DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss"));
                }
                Application.Exit();
            }
            else
            {
                return;
            }

           
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            SettingsForm sfrm = new SettingsForm();
            sfrm.Show();

        }

        private void btnSessions_Click(object sender, EventArgs e)
        {
            Sessions sess = new Sessions();
            sess.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
