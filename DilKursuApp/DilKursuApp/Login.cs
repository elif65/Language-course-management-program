using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DilKursuApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (KullaniciTb.Text == "" || SifreTb.Text == "")
            {
                MessageBox.Show("Ekaik Bilgi.");
            }
            else if (KullaniciTb.Text == "Admin" && SifreTb.Text == "1234")
            {
                AnaSayfa ana = new AnaSayfa();
                ana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı yada şifre");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
