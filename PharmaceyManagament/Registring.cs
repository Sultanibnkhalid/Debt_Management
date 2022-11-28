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
    public partial class Registring : Form
    {
        private bool flag;

        Color backgroundcontainers;
        Color buttonshover;
        Color buttonsbackground;
        Color fontColer;

        public Registring()
        {
            InitializeComponent();

            txtPhone.KeyDown += TxtPhone_KeyDown;
            txtPhone.KeyPress += TxtPhone_KeyPress;
            txtPhone.MaxLength = 14;
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
                this.BackColor = backgroundcontainers;
                this.ForeColor = fontColer;
                btAllUsers.BackColor = btnAdd.BackColor = btnAlter.BackColor =btnCancel.BackColor= buttonsbackground;

            }
            catch
            {

            }



        }

        private void TxtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = flag;
        }

        private void TxtPhone_KeyDown(object sender, KeyEventArgs e)
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

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void Registring_Load(object sender, EventArgs e)
        {


            if (CurrentUser.userName != "")
            {
                lblCurrentUser.Text = CurrentUser.userName;
            }


            this.panel1.Size = new Size(539, 649);
            rbtnSaler.Checked = true;
            lblEqualPassword.Text = "";
            lblStrongPassword.Text = "";
            pbGoodPaswod.Visible = false;
            lblStrongPassword.ForeColor = Color.Red;
            lblEqualPassword.ForeColor = Color.Red;
            pbHideAndShowPasword.Image = Image.FromFile("hidden.png");
            this.lblDate.Text = DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss");
           

            this.panel1.Visible = false;
        }

        private void pbHideAndShowPasword_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.UseSystemPasswordChar==true)
                {
                    pbHideAndShowPasword.Visible = false;
                    pbHideAndShowPasword.Image = Image.FromFile("visible.png");
                    pbHideAndShowPasword.Visible = true;
                    txtPassword.UseSystemPasswordChar = false;
                    txtRetypePassword.UseSystemPasswordChar = false;
                    //txtRetypePassword.PasswordChar = '\0';
                    //txtPassword.PasswordChar = '\0';
                }
                else 
                {
                    pbHideAndShowPasword.Visible = false;
                    pbHideAndShowPasword.Image = Image.FromFile("hidden.png");
                    pbHideAndShowPasword.Visible = true;

                    txtPassword.UseSystemPasswordChar = true;
                    txtRetypePassword.UseSystemPasswordChar = true;
                    //txtRetypePassword.PasswordChar = '*';
                    //txtPassword.PasswordChar = '*';

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "message");
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim().Length < 8)
            {
                
                lblStrongPassword.Text = "week password";
            }
            else
            {
                pbGoodPaswod.Visible = true;
                lblStrongPassword.ForeColor = Color.Aqua;
                lblStrongPassword.Text = "good password";

            }
        }

        private void txtRetypePassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtRetypePassword.Text)
            {
                lblEqualPassword.Text = "يجب ان يكون متساوي";
            }
            else
            {
                lblEqualPassword.Text = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string usertype = "مستخدم" ;
            if (txtName.Text.Trim().Length==0)
            {
                txtName.Focus();
                lblEqualPassword.Text = "اسم فارغ";
                return ;
            }
            if (txtPhone.Text.Trim().Length <9)
            {
                txtPhone.Focus();
                lblEqualPassword.Text = "رقم هاتف غير صحيح";
                return;
            }
             if (txtPassword.Text.Trim().Length < 8 )
            {
                txtPassword.Focus();
                lblEqualPassword.Text = "كلمة مرور ضعيفة";
                return;
            }
            if (txtPassword.Text!=txtRetypePassword.Text)
            {
                txtPassword.Focus();
                lblEqualPassword.Text = "كلمة مرور مختلفة";
                return;
            }
            if (rbtnManager.Checked ==false && rbtnSaler.Checked == false)
            {
                lblEqualPassword.Text = "يرجى تحديد صلحيات المستخدم";
                return;
            }
            if (rbtnManager.Checked == true) {
                usertype = "مدير";
                    }
            string sex = (rbtnFamele.Checked == true) ? "انثى" : "ذكر";
            string pass = PasswordEncription(txtPassword.Text);
            using(DataBaseHelper dbh=new DataBaseHelper())
            {
                int x = dbh.AddUser(txtName.Text, txtPhone.Text, pass, txtAdrdress.Text,sex, usertype);
            }
            AddToDataGridView();
            txtName.Text = "";
            txtPassword.Text = "";
            txtPhone.Text = "";
            txtRetypePassword.Text = "";
            lblStrongPassword.Text = "";
            pbGoodPaswod.Visible = false;
            this.DialogResult = DialogResult.OK;
            this.Close();
              }


        private void AddToDataGridView()
        {
            using (DataBaseHelper dbh=new DataBaseHelper())
            {
                dataGridView1.DataSource = dbh.GetUersInfo();
                dataGridView1.Columns["user_id"].Visible = false;
            }
        }
        private void btAllUsers_Click(object sender, EventArgs e)
        {

            AddToDataGridView();
            if (CurrentUser.userName == "" || CurrentUser.userType==0)
            {
                lblEqualPassword.Text = " لست مخولاً لذلك ";
                pbAppPic.Visible = false;
            }
            if (panel1.Visible==true)
            {
                //10; 649

                panel1.Visible = false;
                this.panel1.Size = new Size(10,649);
                pbAppPic.Visible = true;


            }
            else
            {
               
                this.panel1.Visible = true;
                this.panel1.Size = new Size(539, 649);
                this.pbAppPic.Visible = false;

            }
        }

        private void Registring_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void Registring_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Form1 frm1 = new Form1();
            //frm1.Show();
            //this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnAlter_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Leave(object sender, EventArgs e)
        {
            Control c = (sender as Control);
            c.BackColor = buttonsbackground;
        }

        private void btnAdd_Enter(object sender, EventArgs e)
        {
            Control c = (sender as Control);
            c.BackColor = buttonshover;
        }

        private string PasswordEncription(string t)
        {
            int xx;
            char ch;
            string text1 = "";
            for(int i = 0; i < t.Length; i++)
            {
                 xx = (int)t[i];
                xx += 3;
                xx %= 127;
                ch = (char)xx;
                text1 += ch.ToString();
            }


            return text1;
        }

        private void txtName_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPhone.Focus();
            }
        }

        private void txtPhone_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAdrdress.Focus();
            }
        }

        private void txtAdrdress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtRetypePassword.Focus();
            }
        }
    }
}
