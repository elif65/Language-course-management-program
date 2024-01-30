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
    public partial class PuanYonetim : Form
    {
        public PuanYonetim()
        {
            InitializeComponent();
        }
        Microsoft.Data.SqlClient.SqlConnection baglanti = new Microsoft.Data.SqlClient.SqlConnection(@"Data Source=DESKTOP-88US3VI\SQLEXPRESS;Initial Catalog=KursDb;Integrated Security=True;TrustServerCertificate=True;");

        private void PuanYonetim_Load(object sender, EventArgs e)
        {
            puanlar();
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
        int Pİd;
        private void button1_Click(object sender, EventArgs e)
        {
            if (OgrenciIdTb.Text == "" || PuanTb.Text == "" || KursSecCb.Text == "" || AciklamaTb.Text == "")
            {
                MessageBox.Show("Silinecek Puanı Seçiniz.");

            }
            else
            {
                try
                {
                    Pİd = Convert.ToInt32(PuanDgv.SelectedRows[0].Cells[0].Value.ToString());
                    baglanti.Open();
                    string query = "delete from PuanTbl where PuanId =" + Pİd + "";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Puan başarıyla silindi.");
                    baglanti.Close();
                    puanlar();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void PuanDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Pİd = Convert.ToInt32(PuanDgv.SelectedRows[0].Cells[0].Value.ToString());
            OgrenciIdTb.Text = PuanDgv.SelectedRows[0].Cells[1].Value.ToString();
            PuanTb.Text = PuanDgv.SelectedRows[0].Cells[2].Value.ToString();
            KursSecCb.Text = PuanDgv.SelectedRows[0].Cells[3].Value.ToString();
            AciklamaTb.Text = PuanDgv.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OgrenciIdTb.Text = "";
            PuanTb.Text = "";
            KursSecCb.Text = "";
            AciklamaTb.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (OgrenciIdTb.Text == "" || PuanTb.Text == "" || KursSecCb.Text == "" || AciklamaTb.Text == "")
            {
                MessageBox.Show("Eksik Bilgi.");

            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "update PuanTbl set OgrenciId=" + OgrenciIdTb.Text + ",Puan='" + PuanTb.Text + "',Kurs='" + KursSecCb.Text + "',Aciklama='" + AciklamaTb.Text + "' where PuanId=" + Pİd + ";";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Puan Başarıyla Gücellendi.");
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
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM PuanTbl WHERE OgrenciId LIKE @FilterText", baglanti);
            komut.Parameters.AddWithValue("@FilterText", "%" + FilterTb.Text + "%");

            SqlDataAdapter sda = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            PuanDgv.DataSource = ds.Tables[0];

            baglanti.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            puanlar();
        }
    }
}
