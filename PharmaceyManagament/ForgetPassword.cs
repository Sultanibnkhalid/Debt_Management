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
    public partial class ForgetPassword : Form
    {
        public static string passtext = "";
        
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ForgetPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Restart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != passtext)
            {
                MessageBox.Show("النص غير صحيح", "خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else
            {
                string xx = PasswordEncription(textBox1.Text);

                label2.Text += " " + xx;


                    
            }
        }

        private string PasswordEncription(string t)
        {
            int xx;
            char ch;
            string text1 = "";
            for (int i = 0; i < t.Length; i++)
            {
                xx = (int)t[i];
                xx += 127;
                xx -= 3;
                xx %= 127;
                ch = (char)xx;
                text1 += ch.ToString();
            }


            return text1;
        }
    }
}
