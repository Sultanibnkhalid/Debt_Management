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
    public partial class Notes : Form
    {
        public Notes()
        {
            InitializeComponent();
        }

        private void Notes_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'pharmacyADataSet4.getNotes' table. You can move, or remove it, as needed.
           

            using(DataBaseHelper dbh=new DataBaseHelper())
            {
                dataGridView1.DataSource = dbh.GetNotes();
                dataGridView1.Columns["note_id"].Visible = false;
            }
            this.Size=new Size(856, 522);
            panel1.Size=new Size(856,488);
            label2.Text = CurrentUser.userName;
            textBox1.Visible = false;
            btnAdd.Visible = false;
            label1.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Visible == false)
            {
                panel1.Size = new Size(612, 488);
                textBox1.Visible = true;
                btnAdd.Visible = true;
                label1.Visible = true;

            }
            else
            {
                textBox1.Visible = false;
                btnAdd.Visible = false;
                label1.Visible = false;
                panel1.Size = new Size(856, 488);
            }

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length == 0)
            {
                label1.ForeColor = Color.Red;
                label1.Text = "لا يمكن اضافة ملاحظة فارغة";
                return;
            }
            using (DataBaseHelper dbh = new DataBaseHelper())

            {
               
                int c = dbh.AddNote(CurrentUser.userID, DateTime.Now.ToString(), textBox1.Text);
                label1.ForeColor = Color.Aqua;
                label1.Text = "تم";

              

            }
            using (DataBaseHelper dbh = new DataBaseHelper())
            {
                dataGridView1.DataSource = dbh.GetNotes();
                dataGridView1.Columns["note_id"].Visible = false;
            }
        }
    }
}
