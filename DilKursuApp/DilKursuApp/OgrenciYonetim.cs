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
    public partial class OgrenciYonetim : Form
    {
        public OgrenciYonetim()
        {
            InitializeComponent();
        }
        Microsoft.Data.SqlClient.SqlConnection baglanti = new Microsoft.Data.SqlClient.SqlConnection(@"Data Source=DESKTOP-88US3VI\SQLEXPRESS;Initial Catalog=KursDb;Integrated Security=True;TrustServerCertificate=True;");

        private void OgrenciYonetim_Load(object sender, EventArgs e)
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
            YonetimDgv.DataSource = ds.Tables[0];
            baglanti.Close();

        }

        int OgrKey;
        private void button3_Click(object sender, EventArgs e)
        {
            if (AdSoyadTb.Text == "" || TelefonTb.Text == "" || ResimTb.Text == "" || CinsiyetCb.Text == "" || AdresTb.Text == "")
            {
                MessageBox.Show("Silinecek öğrenciyi seçiniz.");

            }
            else
            {
                try
                {
                    OgrKey = Convert.ToInt32(value: YonetimDgv.SelectedRows[0].Cells[0].Value.ToString());
                    baglanti.Open();
                    string query = "delete from OgrenciTbl where ogrenciId=" + OgrKey + "";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Öğrenci başarıyla silindi.");
                    baglanti.Close();
                    uyeler();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void YonetimDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
              OgrKey = Convert.ToInt32(value: YonetimDgv.SelectedRows[0].Cells[0].Value.ToString());

            AdSoyadTb.Text = YonetimDgv.SelectedRows[0].Cells[1].Value.ToString();
            TelefonTb.Text = YonetimDgv.SelectedRows[0].Cells[2].Value.ToString();
            DogumTrhTb.Text = YonetimDgv.SelectedRows[0].Cells[3].Value.ToString();
            CinsiyetCb.Text = YonetimDgv.SelectedRows[0].Cells[4].Value.ToString();
            ResimTb.Text = YonetimDgv.SelectedRows[0].Cells[5].Value.ToString();
            AdresTb.Text = YonetimDgv.SelectedRows[0].Cells[6].Value.ToString();
            YonetimPb.ImageLocation = YonetimDgv.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void YonetimPb_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (AdSoyadTb.Text == "" || TelefonTb.Text == "" || ResimTb.Text == "" || CinsiyetCb.Text == "" || AdresTb.Text == "")
            {
                MessageBox.Show("Eksik Bilgi.");

            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "update OgrenciTbl set AdSoyad='" + AdSoyadTb.Text + "',Telefon='" + TelefonTb.Text + "',DogumTrh='" + DogumTrhTb.Text + "',Cinsiyet='" + CinsiyetCb.Text + "',Resim='" + ResimTb.Text + "',Adres='" + AdresTb.Text + "' where OgrenciId=" + OgrKey + ";";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Öğrenci Başarıyla Güncellendi.");
                    baglanti.Close();
                    uyeler();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            YonetimPb.ImageLocation = openFileDialog1.FileName;
            ResimTb.Text = openFileDialog1.FileName;
        }


        //reset butonu
        private void button2_Click(object sender, EventArgs e)
        {

            AdSoyadTb.Text = "";
            TelefonTb.Text = "";
            CinsiyetCb.Text = "";
            ResimTb.Text = "";
            AdresTb.Text = "";
            YonetimPb.ImageLocation = "";
        }


        //Ara Butonu
        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM OgrenciTbl WHERE AdSoyad LIKE @FilterText", baglanti);
            komut.Parameters.AddWithValue("@FilterText", "%" + FilterTb.Text + "%");

            SqlDataAdapter sda = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            YonetimDgv.DataSource = ds.Tables[0];

            baglanti.Close();
        }

        //Yenile butonu
        private void button6_Click(object sender, EventArgs e)
        {
            uyeler();
        }
    }
}
