using Microsoft.Data.SqlClient;
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
    public partial class YeniPuan : Form
    {
        public YeniPuan()
        {
            InitializeComponent();
        }
        Microsoft.Data.SqlClient.SqlConnection baglanti = new Microsoft.Data.SqlClient.SqlConnection(@"Data Source=DESKTOP-88US3VI\SQLEXPRESS;Initial Catalog=KursDb;Integrated Security=True;TrustServerCertificate=True;");
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void YeniPuan_Load(object sender, EventArgs e)
        {
            uyeler();
            puanlar();
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

        private void puanlar()
        {

            baglanti.Open();
            string query = "select  * from PuanTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder bilder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PuanDgv.DataSource = ds.Tables[0];
            baglanti.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (OgrenciİdTb.Text == "" || PuanTb.Text == "" || KursSecCb.Text == "" || AciklamaTb.Text == "")
            {
                MessageBox.Show("Eksik Bilgi.");

            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "insert into PuanTbl values(" + OgrenciİdTb.Text + ",'" + PuanTb.Text + "','" + KursSecCb.Text + "','" + AciklamaTb.Text + "')";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Puan başarıyla eklendi.");
                    baglanti.Close();
                    puanlar();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OgrenciİdTb.Text = "";
            PuanTb.Text = "";
            KursSecCb.Text = "";
            AciklamaTb.Text = "";
        }

        private void label8_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            this.Hide();

        }
    }
}
