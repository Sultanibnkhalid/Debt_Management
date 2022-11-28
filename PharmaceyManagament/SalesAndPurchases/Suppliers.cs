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
    public partial class Suppliers : Form
    {
        private bool flag;
        private int supID = 0;
        Color backgroundcontainers;
        Color buttonshover;
        Color buttonsbackground;
        Color fontColer;
        public Suppliers()
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

                this.ForeColor = fontColer;



                panel2.BackColor = panel1.BackColor = backgroundcontainers;

                btnDelet.BackColor = btnSave.BackColor = btnSaveAlter.BackColor = buttonsbackground;

            }
            catch
            {

            }
            //lblErrorsMessage.ForeColor = MyCustomColors.m_fontRedColor;
            //panel3.BackColor = MyCustomColors.m_back4;
            //panel3.ForeColor = MyCustomColors.m_fontColwite;
            //panel2.BackColor = MyCustomColors.m_backLightblack;

            //btnSave.BackColor = MyCustomColors.m_backLightblack;
            //btnDelet.BackColor = MyCustomColors.m_backLightblack;
            //btnSaveAlter.BackColor = MyCustomColors.m_backLightblack;

            //dataGridView1.BackgroundColor = MyCustomColors.m_backPgry;
            //dataGridView1.GridColor = MyCustomColors.m_hover2;
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtSuppleirPhne_KeyDown(object sender, KeyEventArgs e)
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

        private void txtSuppleirPhne_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = flag;
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            this.lblCurrentUser.Text = CurrentUser.userName;
            this.lblDate.Text = DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss");
            this.lblErrorsMessage.ForeColor = Color.Red;
            this.lblErrorsMessage.Text = "";
            this.pbDone.Visible = false;
            btnSaveAlter.Enabled = false;
            btnDelet.Enabled = false;
            using (DataBaseHelper dbh=new DataBaseHelper())
            {
                dataGridView1.DataSource = dbh.GetSupliersDetails();
                dataGridView1.Columns["sup_id"].Visible = false;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtSuppleirName.Text.Trim().Length==0)
            {
                lblErrorsMessage.Text = "اسم غير صيح";
                return;
            }
            if (txtSuppleirPhne.Text.Trim().Length == 0)
            {
                lblErrorsMessage.Text = "رقم هاتف غير صيح";
                return;
            }
            if (txtSuppleirPhne.Text.Trim().Length == 0)
            {
                lblErrorsMessage.Text = "عنوان غير صيح";
                return;
            }
            using(DataBaseHelper dbh=new DataBaseHelper())
            {
                int c = dbh.AddSupplier(txtSuppleirName.Text, txtSuppleirPhne.Text, txtSupplierAdress.Text);
            }
            using(DataBaseHelper dbh=new DataBaseHelper())
            {
                dataGridView1.DataSource = dbh.GetSupliersDetails();
                dataGridView1.Columns["sup_id"].Visible = false;
            }

        }

        private void btnSaveAlter_Click(object sender, EventArgs e)
        {
            if (txtSuppleirName.Text.Trim().Length == 0)
            {
                lblErrorsMessage.Text = "اسم غير صيح";
                return;
            }
            if (txtSuppleirPhne.Text.Trim().Length == 0)
            {
                lblErrorsMessage.Text = "رقم هاتف غير صيح";
                return;
            }
            if (txtSuppleirPhne.Text.Trim().Length == 0)
            {
                lblErrorsMessage.Text = "عنوان غير صيح";
                return;
            }

            using (DataBaseHelper dbh = new DataBaseHelper())
            {
                int c = dbh.AlterSupplierData(supID,txtSuppleirName.Text, txtSuppleirPhne.Text, txtSupplierAdress.Text);
            }
            using (DataBaseHelper dbh = new DataBaseHelper())
            {
                dataGridView1.DataSource = dbh.GetSupliersDetails();
                dataGridView1.Columns["sup_id"].Visible = false;
            }

            btnDelet.Enabled = false;
            btnSaveAlter.Enabled = false;
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حقاً الغاء العملية", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                txtSuppleirName.Text = txtSuppleirPhne.Text = txtSupplierAdress.Text = "";
                btnSaveAlter.Enabled = false;
                btnDelet.Enabled = false; 
            }
            else
            {
                return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss");

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Enter(object sender, EventArgs e)
        {

            Control c = (sender as Control);
            c.BackColor =buttonshover;
        }

        private void btnSave_Leave(object sender, EventArgs e)
        {
            Control c = (sender as Control);
            c.BackColor = buttonsbackground;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowIndex = e.RowIndex;
            if (rowIndex > -1)
            {
                supID =(int) dataGridView1.Rows[rowIndex].Cells["sup_id"].Value;
                txtSuppleirName.Text= dataGridView1.Rows[rowIndex].Cells["الاسم"].Value.ToString();
                txtSuppleirPhne.Text= dataGridView1.Rows[rowIndex].Cells["تلفون"].Value.ToString();
                txtSupplierAdress.Text= dataGridView1.Rows[rowIndex].Cells["العنوان"].Value.ToString();
                btnSaveAlter.Enabled = true;
                btnDelet.Enabled = true;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblCurrentUser_Click(object sender, EventArgs e)
        {

        }
    }
}
