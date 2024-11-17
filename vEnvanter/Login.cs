using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vEnvanter
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            if (textBox1.Text == "admin" & textBox2.Text == "admin")
            {
               
               MessageBox.Show("Giriş Bilgileri Doğru!", "Hoşgeldiniz!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Giriş Bilgilerinizde Hata Var! Tekrar Deneyin!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
    }
}
