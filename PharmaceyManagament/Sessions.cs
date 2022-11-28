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

namespace PharmaceyManagament
{
    public partial class Sessions : Form
    {

        Color backgroundcontainers;
        Color buttonshover;
        Color buttonsbackground;
        Color fontColer;
        DataTable dt = new DataTable();
        public Sessions()
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

                panel1.BackColor = panel2.BackColor = backgroundcontainers;
                btnfilter.BackColor = button2.BackColor = buttonsbackground;
                this.ForeColor = fontColer;
                this.BackColor = backgroundcontainers;
            }
            catch
            {

            }

            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sessions_Load(object sender, EventArgs e)
        {
            panel1.Size = new Size(898, 506);
            panel2.Visible = false;

            using(DataBaseHelper dbh=new DataBaseHelper())
            {

                dt = dbh.GetLogoInfo();

            }
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["log_id"].Visible = false;


            ///599; 493
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == true)
            {
                panel2.Visible =false;
                panel1.Size = new Size(898, 506);

            }
            else
            {
                panel1.Size = new Size(599, 506);
                panel2.Visible = true;

            }
        }

        private void btnfilter_Click(object sender, EventArgs e)
        {
            try {
                //DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss"
                string ldate = dateTimePicker1.Value.ToString("MM-dd-yyyy HH:mm:ss");
                ldate = ldate.Substring(0, 10);

                // (dgvbills.DataSource as DataTable).DefaultView.RowFilter
                //  = string.Format("من like '%{0}%'", sf);

                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("من like '{0}%'", ldate); }
            catch(Exception ex)
            {
                dataGridView1.DataSource = null;
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor = DefaultBackColor;
        }

        private void button2_Leave(object sender, EventArgs e)
        {
            Control c = (sender as Control);
            c.BackColor = buttonsbackground;
        }

        private void button2_Enter(object sender, EventArgs e)
        {
            Control c = (sender as Control);
            c.BackColor = buttonshover;
        }
    }
}
