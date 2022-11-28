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
using System.IO;

namespace PharmaceyManagament
{
    public partial class SettingsForm : Form
    {
        string hovertex = "";
        string backtext = "";
        Color backgroundcontainers;
        Color buttonshover;
        Color buttonsbackground;
        Color fontColer;
        public SettingsForm()
        {
            InitializeComponent();


            try
            {

                backgroundcontainers = Properties.Settings.Default.containerscolor;
                fontColer = Properties.Settings.Default.fontcolors;

                var bb = Properties.Settings.Default.buttonscolors;
                var bh = Properties.Settings.Default.buttonshover;
                buttonshover = System.Drawing.ColorTranslator.FromHtml(bh);
                buttonsbackground = System.Drawing.ColorTranslator.FromHtml(bb);
                btnChoosebackcolor.BackColor = buttonsbackground;
                this.ForeColor = fontColer;
                btnFontColor.BackColor = fontColer;
                backtext = bb;
                hovertex = bh;
                txtMarketName.Text = Properties.Settings.Default.marketName;
                btnsaveColors.BackColor = btnBackUp.BackColor = btnDbRefresh.BackColor = btnRestorDb.BackColor = buttonsbackground;



                btnblue.BackColor = MyCustomColors.m_hover1;
                rbtnColor1.BackColor = rbtnmaqua.BackColor = MyCustomColors.m_hover3;
                rbtnmaqua.BackColor = rbtnColor1.BackColor = MyCustomColors.m_hoverP200;
                rbtncolor2.BackColor = rbtnmlastcolor.BackColor = MyCustomColors.m_hover2;
                rbtnred.BackColor = MyCustomColors.m_fontRedColor;
            }
            catch
            {

            }




        }

        private async void btnRestorDb_Click(object sender, EventArgs e)
        {
            try { 

            FolderBrowserDialog fl = new FolderBrowserDialog();
            var result = fl.ShowDialog();
            string pathBackUp = fl.SelectedPath;
            if (result == DialogResult.OK)
            {

               
                this.Cursor = Cursors.AppStarting;
                using (DataBaseHelper dbh = new DataBaseHelper())
                {
                    var re = await Task.Run(() => dbh.BackUpDB(fl));
                    if (re == true)
                    {
                        //panel1.Visible = false;
                        if (MessageBox.Show("تم النسـخ الاحتياطي بنجاح", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                        {
                            this.Opacity = 1.00;
                            this.Cursor = Cursors.Default;
                        }
                    }
                    else
                    {
                        MessageBox.Show("فشلت عملية النسخ الاحتياطي");
                      //  panel1.Visible = false;
                        this.Opacity = 1.00;
                        this.Cursor = Cursors.Default;
                    }
                }

               // panel1.Visible = false;
                this.Opacity = 1.00;
                this.Cursor = Cursors.Default;
            }
            else
            {
              //  panel1.Visible = false;
                this.Opacity = 1.00;
                this.Cursor = Cursors.Default;
            }
        }
            catch
            {
              //  panel1.Visible = false;
                MessageBox.Show(" فشلت عملية النسخ الاحتياطي تأكد من تشغيل البرنامج كمسؤول", "فـشل", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Opacity = 1.00;
            }
}

        private void SettingsForm_Load(object sender, EventArgs e)
        {

            if (CurrentUser.userID == 0)
            {
                btnBackUp.Enabled = false;
                btnDbRefresh.Enabled = false;
                btnRestorDb.Enabled = false;
            }
            lblprogramerName.Text = "المهندس سلطان الشجيفي\n 777850592";
            lblProductNme.Text= string.Format("Product Name :{0}", Application.ProductName);
            lblProductVerion.Text= string.Format("Version : {0}", Application.ProductVersion);
           
            lblCopyrights.Text= "Copyright ©  2022 by Sultan Alshojify";
            try
            {
                MemoryStream ma;
                var mb = Convert.FromBase64String(Properties.Settings.Default.marketPicter);
                ma = new MemoryStream(mb);
                pbMarketPic.Image = Image.FromStream(ma);

            }
            catch
            {

            }
        }

        private async void btnBackUp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل توفق على الحصول على البيانات من نسخة احتياطة ", "تنبية", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {


                try
                {


                    using (OpenFileDialog fl = new OpenFileDialog() { Filter = "DataBase |*.bak" })
                    {
                        var result = fl.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            //panel1.Visible = true;
                            this.Opacity = 0.76;
                            this.Cursor = Cursors.AppStarting;
                            using (DataBaseHelper db = new DataBaseHelper())
                            {
                                var re = await Task.Run(() => db.RestoreDB(fl));
                                if (re == true)
                                {
                                    //  panel1.Visible = false;
                                    if (MessageBox.Show("تم استعادة النسخة الاحتياطي بنجاح وسيتم اعدة تشغيل  البرنامج", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                                    {
                                        this.Opacity = 1.00;
                                        this.Cursor = Cursors.Default;
                                    }
                                    Application.Restart();
                                }
                                else
                                {
                                    MessageBox.Show("فشلت عملية استعادة النسخ الاحتياطي");
                                    //  panel1.Visible = false;
                                    this.Opacity = 1.00;
                                    this.Cursor = Cursors.Default;
                                }
                            }

                            // panel1.Visible = false;
                            this.Opacity = 1.00;
                            this.Cursor = Cursors.Default;
                        }
                        else
                        {
                            //  panel1.Visible = false;

                            this.Opacity = 1.00;
                            this.Cursor = Cursors.Default;
                        }
                    }

                }
                catch
                {
                    // panel1.Visible = false;
                    MessageBox.Show(" فشلت عملية استعادة النسخ الاحتياطي تأكد من تشغيل البرنامج كمسؤول", "فـشل", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Opacity = 1.00;
                }
            }
            else
            {
                return;
            }

        }

        private async void btnDbRefresh_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("هل انت موافق على تهيئة قاعدة اليانات \n  حذف كل البيانات المخزنة واعادة تشغيل البرنامج في قاعدة البيانات سيؤدي ذلك الى ", "تنبية", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                using (DataBaseHelper dbh = new DataBaseHelper())
                {

                    var res = await Task.Run(() => dbh.ClearDB());
                    if (res > 0)
                    {
                        MessageBox.Show("تمت التهية");
                        Application.Restart();

                    }
                    else
                    {
                        MessageBox.Show("فشلت  التهية");
                        Application.Restart();
                    }
               
                }
            }
            else
            {
                return ;
            }


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnChoosebackcolor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnChoosebackcolor.BackColor = colorDialog1.Color;
            }
        }

        private void btnFontColor_Click(object sender, EventArgs e)
        {

            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
               btnFontColor.BackColor = colorDialog2.Color;
            }
        }

        private async void btnsaveColors_Click(object sender, EventArgs e)
        {
            if (txtMarketName.Text.Trim().Length == 0)
            {
                MessageBox.Show("لا يمكن ان يكون اسم المحل فارغ ");
                return;
            }
            int x =await Task.Run(() => SaveDefaults());
            if (x > 0)
            {
                MessageBox.Show("تم الحفظ");
                Application.Restart();
            }
            else
            {
                MessageBox.Show("لم بتم حفظ الاعدادات");

            }



        }
        //public static Color m_hover1 = System.Drawing.ColorTranslator.FromHtml("#82B4AF");
        //public static Color m_hover2 = System.Drawing.ColorTranslator.FromHtml("#C395FC");
        //public static Color m_hover3 = System.Drawing.ColorTranslator.FromHtml("#A476DD");
        //public static Color m_aquhover = System.Drawing.ColorTranslator.FromHtml("#03C0AD");

        //public static Color m_hoverP200 = System.Drawing.ColorTranslator.FromHtml("#BB86FC");
        //public static Color m_backSecondery900 = System.Drawing.ColorTranslator.FromHtml("#00B3A6");


        //public static Color m_back1 = System.Drawing.ColorTranslator.FromHtml("#E6E6E6");
        //public static Color m_back2 = System.Drawing.ColorTranslator.FromHtml("#9F9F9F");
        //public static Color m_back3 = System.Drawing.ColorTranslator.FromHtml("#F5F5F5");
        //public static Color m_back4 = System.Drawing.ColorTranslator.FromHtml("#222222");
        //public static Color m_back5 = System.Drawing.ColorTranslator.FromHtml("#302341");
        //public static Color m_back6 = System.Drawing.ColorTranslator.FromHtml("#005457");

        //public static Color m_backlightaqua = System.Drawing.ColorTranslator.FromHtml("#BB86FC");


        //public static Color m_backLightblack = System.Drawing.ColorTranslator.FromHtml("#8F8F8F");

        /// <summary>
        /// 
        /// secondery200 #03DAC5
        /// secondery50   #C8FFF4
        /// 
        ///         prupel200  #F2E7FE
        ///    primary    #BB86FC
        /// </summary>
        private void rbtnred_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void btnblue_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbtnred_Click(object sender, EventArgs e)
        {
            backtext = "#FF1644";
        }

        private void btnblue_Click(object sender, EventArgs e)
        {
            backtext = "#BB86FC";
        }

        private void rbtnColor1_Click(object sender, EventArgs e)
        {
            backtext = "#C8FFF4";

        }

        private void radicolor2_Click(object sender, EventArgs e)
        {
            backtext = "#03C0AD";

        }

        private void rbtnmpnk_Click(object sender, EventArgs e)
        {
            hovertex = "#A476DD";
        }

        private void rbtnmblue_Click(object sender, EventArgs e)
        {
            hovertex = "#BB86FC";

        }

        private void rbtnmaqua_Click(object sender, EventArgs e)
        {
            hovertex = "#C8FFF4";

        }

        private void rbtnmlastcolor_Click(object sender, EventArgs e)
        {
            hovertex = "#BB86FC";

        }

     private   int SaveDefaults()
        {
            try
            {
                Properties.Settings.Default.buttonscolors = backtext;
                Properties.Settings.Default.buttonshover = hovertex;
                Properties.Settings.Default.fontcolors = btnFontColor.BackColor;
                Properties.Settings.Default.containerscolor = btnChoosebackcolor.BackColor;
                Properties.Settings.Default.marketName = txtMarketName.Text;

                MemoryStream ma = new MemoryStream();
                pbMarketPic.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Png);
                Properties.Settings.Default.marketPicter = Convert.ToBase64String(ma.ToArray());
                Properties.Settings.Default.Save();
                return 1;
            }
            catch
            {
                return 0;
            }

        }

        private void pbMarketPic_DoubleClick(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "picture|*.png", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pbMarketPic.Image =Image.FromFile(ofd.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
