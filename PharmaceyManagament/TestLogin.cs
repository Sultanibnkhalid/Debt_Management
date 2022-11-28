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
using System.Threading;

namespace PharmaceyManagament
{
    public partial class TestLogin : Form
    {
        public TestLogin()
        {
            InitializeComponent();
        }

        private async void TestLogin_Load(object sender, EventArgs e)
        {
            await Task.Run(() => Thread.Sleep(500));
            progressBar1.Maximum = 0;
            progressBar1.Maximum = 100;
            for (int i = 0; i < 100; i++)
            {
                progressBar1.Value = i;
                Thread.Sleep(1);
            }
            int res = await Task.Run(() => testFromDatabase());
            if (res == 0)
            {
                MessageBox.Show("حـدث خـطاء في الاتصال بقاعدة البيانات الرجاءالتاكد من مسار الاتصال", "خـطاء في الاتصال", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                Application.Exit();
            }
            else if (res == 2)
            {
                Registring rfrm = new Registring();

                rfrm.btAllUsers.Visible = false;
                this.Hide();
                var dd = rfrm.ShowDialog();
                if (dd == DialogResult.OK)
                {
                    Application.Restart();

                }
                else
                { Application.Exit(); }

            }
            else if(res==1)
            {
                Login fl = new Login();
                fl.Show();
                this.Hide();
            }


        }

       private int testFromDatabase()
        {
            DataTable dt = new DataTable();

            try
            {
                using(DataBaseHelper dbh=new DataBaseHelper())
                {
                    dt = dbh.GetUsers();
                    
                }
                if (dt.Rows.Count > 0)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }

            }
            catch
            {
                return 0;
            }
         
            
        }
    }
}
