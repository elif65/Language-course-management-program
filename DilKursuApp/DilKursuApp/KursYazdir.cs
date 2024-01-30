using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DilKursuApp
{
    public partial class KursYazdir : Form
    {
        public KursYazdir()
        {
            InitializeComponent();
        }
        Microsoft.Data.SqlClient.SqlConnection baglanti = new Microsoft.Data.SqlClient.SqlConnection(@"Data Source=DESKTOP-88US3VI\SQLEXPRESS;Initial Catalog=KursDb;Integrated Security=True;TrustServerCertificate=True;");

        private void KursYazdir_Load(object sender, EventArgs e)
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
            KYonetimDgv.DataSource = ds.Tables[0];
            baglanti.Close();

        }

        private void label8_Click(object sender, EventArgs e)
        {

            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            this.Hide();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM OgrenciTbl WHERE AdSoyad LIKE @FilterText", baglanti);
            komut.Parameters.AddWithValue("@FilterText", "%" + FilterTb.Text + "%");

            SqlDataAdapter sda = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            KYonetimDgv.DataSource = ds.Tables[0];

            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uyeler();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(this.KYonetimDgv.Width, this.KYonetimDgv.Height);
            KYonetimDgv.DrawToBitmap(bmp, new Rectangle(0, 0, KYonetimDgv.Width, KYonetimDgv.Height));
            e.Graphics.DrawImage(bmp, 20, 150);
            e.Graphics.DrawString(label1.Text, new Font("Verdana ", 20, FontStyle.Bold), Brushes.Black, new Point(300, 30));
            this.KYonetimDgv.Columns["KurdId"].Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
