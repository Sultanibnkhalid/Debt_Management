using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmaceyManagament.Helpers;
namespace PharmaceyManagament
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            lblErrors.ForeColor = Color.Red;
            this.BackColor =Color.WhiteSmoke;
            btnLogoin.BackColor = MyCustomColors.m_fontCol2;

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
         pbHidePassWord.Image =  Image.FromFile("hidden.png");
            using (DataBaseHelper dbh=new DataBaseHelper())
            {
                try
                {
                    CurrentUser.logoiD = dbh.GetLastLogoID() + 1;
                }
                catch
                {
                    CurrentUser.logoiD = 1;
                }

            }
            using(DataBaseHelper dbh=new DataBaseHelper())
            {
                DataTable dt = new DataTable();
                dt = dbh.GetUsers();
                if(dt.Rows.Count > 0)
                {
                    cbUserName.DataSource = dt;
                    cbUserName.DisplayMember = "user_name";
                    cbUserName.ValueMember = "user_id";
                    cbUserName.SelectedIndex = 0;

                }
                else
                {
                    Registring registring = new Registring();
                    this.Hide();
                    registring.ShowDialog();
                }
            }

           

        }

        private void btnExit_Click(object sender, EventArgs e)
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

        private void pbHidePassWord_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '#')
            {
                txtPassword.PasswordChar = '\0';
                pbHidePassWord.Image = Image.FromFile("visible.png");
            }
            else
            {

                txtPassword.PasswordChar = '#';
                pbHidePassWord.Image = Image.FromFile("hidden.png");
            }
        }

        private void lblForgetPassword_Click(object sender, EventArgs e)
        {
            try {
                if (MessageBox.Show("هل تريد استعادة كلمة المرور من خلال رمز التعريفي", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    DataTable dt1 = new DataTable();

                    using (DataBaseHelper dbh = new DataBaseHelper())
                    {
                        dt1 = dbh.getPassWord((int)cbUserName.SelectedValue);
                    }
                    string st1 = dt1.Rows[0]["user_password"].ToString();
                    MessageBox.Show(st1+"رمزك التعريفي هو", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ForgetPassword fp = new ForgetPassword();
                    ForgetPassword.passtext = st1;
                    fp.ShowDialog();
                }
                else
                {
                    return;
                }
            }
            catch
            {
                ////
            }
        }

        private void btnLogoin_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (txtPassword.Text.Trim().Length == 0)
            {
                lblErrors.Text = "كلمة المرور فارغة";
                return;
            }
   try
            {
                using (DataBaseHelper dbh = new DataBaseHelper())
                {

                    //MessageBox.Show(cbUserName..ToString());
                    string pass = PasswordEncription(txtPassword.Text);

                    dt = dbh.ValidatUser((int)cbUserName.SelectedValue, pass);
                }
                    if (dt.Rows.Count == 0)
                    {
                        lblErrors.Text = "كلمة المرور خاطئة";
                        return;
                    }
                    else
                    {
                        this.Cursor = Cursors.WaitCursor;
                        foreach (DataRow row in dt.Rows)
                        {
                            
                            CurrentUser.userID = (int)row["user_id"];
                            CurrentUser.userName = row["user_name"].ToString();
                          if(row["user_masterType"].ToString()== "مدير")
                            {
                                CurrentUser.userType = 1;
                            }
                        }
                    using (DataBaseHelper dbh = new DataBaseHelper())
                    {
                        int d = dbh.AddLogoDate(CurrentUser.userID, DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss"));
                    }
                    Form1 f1 = new Form1();
                        this.Hide();
                        f1.Show();
                    }
                    
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Application.Exit();
                }
                
            //using(DataBaseHelper dbh=new DataBaseHelper())
            //{
            //    int d = dbh.AddLogoDate(CurrentUser.userID, DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss"));
            //}
            //this.Hide();
            //Form1 frm1 = new Form1();
            //frm1.Show();
        }

        private void cbUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Tab || e.KeyCode == Keys.Left)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Tab )
            {
                btnLogoin.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                btnLogoin_Click(btnLogoin,new EventArgs());
            }
        }

        private void btnLogoin_Enter(object sender, EventArgs e)
        {
            btnLogoin.BackColor = MyCustomColors.m_hover1;
        }

        private void btnLogoin_Leave(object sender, EventArgs e)
        {
            btnLogoin.BackColor = MyCustomColors.m_fontCol2;
        }

        private string PasswordEncription(string t)
        {
            int xx;
            char ch;
            string text1 = "";
            for (int i = 0; i < t.Length; i++)
            {
                xx = (int)t[i];
                xx += 3;
                xx %= 127;
                ch = (char)xx;
                text1 += ch.ToString();
            }


            return text1;
        }
    }
}
