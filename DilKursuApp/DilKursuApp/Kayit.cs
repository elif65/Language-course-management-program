using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace DilKursuApp
{
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }
        Microsoft.Data.SqlClient.SqlConnection baglanti = new Microsoft.Data.SqlClient.SqlConnection(@"Data Source=DESKTOP-88US3VI\SQLEXPRESS;Initial Catalog=KursDb;Integrated Security=True;TrustServerCertificate=True;");


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Kayit_Load(object sender, EventArgs e)
        {
            uyeler();
        }
        private void uyeler()
        {
            baglanti.Open();
            string query = "select  * from OgrenciTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder bilder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            OgrenciDgv.DataSource = ds.Tables[0];
            baglanti.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            OgrenciPb.ImageLocation = openFileDialog1.FileName;
            OgrenciResimTb.Text = openFileDialog1.FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (OgrenciAdTb.Text == "" || OgrenciTelefonTb.Text == "" || OgrenciResimTb.Text == "" || OgrenciCinsCb.Text == "" || AdresTb.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");

            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "insert into OgrenciTbl values ('" + OgrenciAdTb.Text + "','" + OgrenciTelefonTb.Text + "','" + OgrenciDogumTarih.Text + "','" + OgrenciCinsCb.Text + "','" + OgrenciResimTb + "','" + AdresTb.Text + "')";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Öğrenci başarıyla eklendi.");
                    baglanti.Close();
                    uyeler();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OgrenciAdTb.Text = "";
            OgrenciTelefonTb.Text = "";
            OgrenciCinsCb.Text = "";
            OgrenciResimTb.Text = "";
            AdresTb.Text = "";

        }

        private void label8_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            this.Hide();
        }
    }
}
