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
    public partial class PuanYazdir : Form
    {
        public PuanYazdir()
        {
            InitializeComponent();
        }
        Microsoft.Data.SqlClient.SqlConnection baglanti = new Microsoft.Data.SqlClient.SqlConnection(@"Data Source=DESKTOP-88US3VI\SQLEXPRESS;Initial Catalog=KursDb;Integrated Security=True;TrustServerCertificate=True;");

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
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void PuanYazdir_Load(object sender, EventArgs e)
        {
            puanlar();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            this.Hide();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap map = new Bitmap(this.PuanDgv.Width, this.PuanDgv.Height);
            PuanDgv.DrawToBitmap(map, new Rectangle(0, 0, this.PuanDgv.Width, this.PuanDgv.Height));
            e.Graphics.DrawImage(map, 70, 150);
        }
    }
}
