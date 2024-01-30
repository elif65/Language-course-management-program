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
    public partial class OgrenciYazdir : Form
    {
        public OgrenciYazdir()
        {
            InitializeComponent();
        }
        Microsoft.Data.SqlClient.SqlConnection baglanti = new Microsoft.Data.SqlClient.SqlConnection(@"Data Source=DESKTOP-88US3VI\SQLEXPRESS;Initial Catalog=KursDb;Integrated Security=True;TrustServerCertificate=True;");

        private void OgrenciYazdir_Load(object sender, EventArgs e)
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
            yazdırDgv.DataSource = ds.Tables[0];
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
            yazdırDgv.DataSource = ds.Tables[0];

            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uyeler();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objBmp = new Bitmap(this.yazdırDgv.Width, this.yazdırDgv.Height);
            yazdırDgv.DrawToBitmap(objBmp, new Rectangle(0, 0, this.yazdırDgv.Width, this.yazdırDgv.Height));
            e.Graphics.DrawImage(objBmp, 18, 150);
            // e.Graphics.DrawString(label1.Text, new Font("Verdana",20,FontStyle.Bold) ,Brushes.Black,new (300,30));
            this.yazdırDgv.Columns["OgrenciId"].Visible = false;
        }
    }
}
