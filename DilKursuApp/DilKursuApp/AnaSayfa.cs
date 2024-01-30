namespace DilKursuApp
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
            PanelDesign();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PanelDesign()
        {
            panel_ogrenciMenü.Visible = false;
            panel_KursMenu.Visible = false;
            panel_puanMenu.Visible = false;

        }
        private void HideMenu()//saklayacak
        {
            if (panel_ogrenciMenü.Visible == true)
                panel_ogrenciMenü.Visible = false;
            if (panel_KursMenu.Visible == true)
                panel_KursMenu.Visible = false;
            if (panel_puanMenu.Visible == true)
                panel_puanMenu.Visible = false;

        }
        private void ShowMenu(Panel Menu)//gösterecek
        {
            if (Menu.Visible == false)
            {
                HideMenu();
                Menu.Visible = true;

            }
            else
            {
                Menu.Visible = false;
            }
        }

        private void button_ogrenciMenu_Click(object sender, EventArgs e)
        {
            ShowMenu(panel_ogrenciMenü);
        }

        private void button_ogrenciKayýt_Click(object sender, EventArgs e)
        {
            HideMenu();
            Kayit kyt = new Kayit();
            kyt.Show();
            this.Hide();
        }

        private void button_ogrenciYönetim_Click(object sender, EventArgs e)
        {
            HideMenu();
            OgrenciYonetim ogry = new OgrenciYonetim();
            ogry.Show();
            this.Hide();
        }

        private void button_ogrenciÝçerik_Click(object sender, EventArgs e)
        {
            HideMenu();
        }

        private void button_ogrenciYazdýr_Click(object sender, EventArgs e)
        {
            HideMenu();
            OgrenciYazdir yzd = new OgrenciYazdir();
            yzd.Show();
            this.Hide();
        }

        private void button_KursMenu_Click(object sender, EventArgs e)
        {
            ShowMenu(panel_KursMenu);
        }

        private void button_KursKayýt_Click(object sender, EventArgs e)
        {
            HideMenu();
            YeniKurs yni = new YeniKurs();
            yni.Show();
            this.Hide();
        }

        private void button_KursYönetim_Click(object sender, EventArgs e)
        {
            HideMenu();
            KayitYonetim kyt = new KayitYonetim();
            kyt.Show();
            this.Hide();
        }

        private void button_KursYazdýr_Click(object sender, EventArgs e)
        {
            HideMenu();
            KursYazdir KursY = new KursYazdir();
            KursY.Show();
            this.Hide();
        }

        private void button_puanlar_Click(object sender, EventArgs e)
        {
            ShowMenu(panel_puanMenu);
        }

        private void button_yeniPuan_Click(object sender, EventArgs e)
        {
            HideMenu();
            YeniPuan yni = new YeniPuan();
            yni.Show();
            this.Hide();
        }

        private void button_puanYönetim_Click(object sender, EventArgs e)
        {
            HideMenu();
            PuanYonetim PY = new PuanYonetim();
            PY.Show();
            this.Hide();
        }

        private void button_puanYazdýr_Click(object sender, EventArgs e)
        {
            HideMenu();
            PuanYazdir PuanYaz = new PuanYazdir();
            PuanYaz.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }



        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button_cýkýs_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}