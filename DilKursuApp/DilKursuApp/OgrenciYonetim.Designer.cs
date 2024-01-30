namespace DilKursuApp
{
    partial class OgrenciYonetim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciYonetim));
            YonetimDgv = new DataGridView();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            YonetimPb = new PictureBox();
            AdresTb = new TextBox();
            label5 = new Label();
            CinsiyetCb = new ComboBox();
            label4 = new Label();
            DogumTrhTb = new DateTimePicker();
            label3 = new Label();
            TelefonTb = new TextBox();
            label2 = new Label();
            AdSoyadTb = new TextBox();
            label1 = new Label();
            button4 = new Button();
            FilterTb = new TextBox();
            button5 = new Button();
            panel1 = new Panel();
            button6 = new Button();
            label8 = new Label();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            ResimTb = new TextBox();
            label7 = new Label();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)YonetimDgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)YonetimPb).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // YonetimDgv
            // 
            YonetimDgv.BackgroundColor = Color.White;
            YonetimDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            YonetimDgv.Location = new Point(-2, 58);
            YonetimDgv.Name = "YonetimDgv";
            YonetimDgv.RowTemplate.Height = 25;
            YonetimDgv.Size = new Size(904, 190);
            YonetimDgv.TabIndex = 0;
            YonetimDgv.CellClick += YonetimDgv_CellClick;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkCyan;
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(687, 448);
            button3.Name = "button3";
            button3.Size = new Size(169, 33);
            button3.TabIndex = 28;
            button3.Text = "SİL";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkOrange;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(337, 448);
            button2.Name = "button2";
            button2.Size = new Size(169, 33);
            button2.TabIndex = 27;
            button2.Text = "RESET";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(627, 326);
            button1.Name = "button1";
            button1.Size = new Size(44, 29);
            button1.TabIndex = 26;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // YonetimPb
            // 
            YonetimPb.Location = new Point(687, 254);
            YonetimPb.Name = "YonetimPb";
            YonetimPb.Size = new Size(169, 140);
            YonetimPb.SizeMode = PictureBoxSizeMode.Zoom;
            YonetimPb.TabIndex = 25;
            YonetimPb.TabStop = false;
            YonetimPb.Click += YonetimPb_Click;
            // 
            // AdresTb
            // 
            AdresTb.Location = new Point(153, 331);
            AdresTb.Multiline = true;
            AdresTb.Name = "AdresTb";
            AdresTb.Size = new Size(169, 88);
            AdresTb.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(90, 330);
            label5.Name = "label5";
            label5.Size = new Size(57, 19);
            label5.TabIndex = 23;
            label5.Text = "Adres:";
            // 
            // CinsiyetCb
            // 
            CinsiyetCb.FormattingEnabled = true;
            CinsiyetCb.Location = new Point(445, 294);
            CinsiyetCb.Name = "CinsiyetCb";
            CinsiyetCb.Size = new Size(176, 23);
            CinsiyetCb.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(356, 293);
            label4.Name = "label4";
            label4.Size = new Size(72, 19);
            label4.TabIndex = 21;
            label4.Text = "Cinsiyet:";
            // 
            // DogumTrhTb
            // 
            DogumTrhTb.Format = DateTimePickerFormat.Short;
            DogumTrhTb.Location = new Point(153, 294);
            DogumTrhTb.Name = "DogumTrhTb";
            DogumTrhTb.Size = new Size(169, 23);
            DogumTrhTb.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(31, 298);
            label3.Name = "label3";
            label3.Size = new Size(116, 19);
            label3.TabIndex = 19;
            label3.Text = "Doğum Tarihi:";
            // 
            // TelefonTb
            // 
            TelefonTb.Location = new Point(445, 254);
            TelefonTb.Name = "TelefonTb";
            TelefonTb.Size = new Size(176, 23);
            TelefonTb.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(360, 258);
            label2.Name = "label2";
            label2.Size = new Size(68, 19);
            label2.TabIndex = 17;
            label2.Text = "Telefon:";
            // 
            // AdSoyadTb
            // 
            AdSoyadTb.Location = new Point(153, 258);
            AdSoyadTb.Name = "AdSoyadTb";
            AdSoyadTb.Size = new Size(169, 23);
            AdSoyadTb.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(58, 258);
            label1.Name = "label1";
            label1.Size = new Size(89, 19);
            label1.TabIndex = 15;
            label1.Text = "Ad Soyad:";
            // 
            // button4
            // 
            button4.BackColor = Color.OrangeRed;
            button4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(512, 448);
            button4.Name = "button4";
            button4.Size = new Size(169, 33);
            button4.TabIndex = 29;
            button4.Text = "GÜNCELLE";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // FilterTb
            // 
            FilterTb.Location = new Point(557, 21);
            FilterTb.Name = "FilterTb";
            FilterTb.Size = new Size(176, 23);
            FilterTb.TabIndex = 30;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkOrange;
            button5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(739, 17);
            button5.Name = "button5";
            button5.Size = new Size(63, 31);
            button5.TabIndex = 31;
            button5.Text = "ARA";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(53, 141, 66);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(FilterTb);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(902, 57);
            panel1.TabIndex = 32;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkOrange;
            button6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(808, 17);
            button6.Name = "button6";
            button6.Size = new Size(82, 31);
            button6.TabIndex = 33;
            button6.Text = "YENİLE";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(12, 19);
            label8.Name = "label8";
            label8.Size = new Size(51, 25);
            label8.TabIndex = 32;
            label8.Text = "<<<";
            label8.Click += label8_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1511, -19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(91, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AllowDrop = true;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(331, 9);
            label6.Name = "label6";
            label6.Size = new Size(190, 25);
            label6.TabIndex = 16;
            label6.Text = "Öğrenci  Yönetim";
            // 
            // ResimTb
            // 
            ResimTb.Location = new Point(445, 330);
            ResimTb.Name = "ResimTb";
            ResimTb.Size = new Size(176, 23);
            ResimTb.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(370, 331);
            label7.Name = "label7";
            label7.Size = new Size(58, 19);
            label7.TabIndex = 33;
            label7.Text = "Resim:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // OgrenciYonetim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(902, 487);
            Controls.Add(ResimTb);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(YonetimPb);
            Controls.Add(AdresTb);
            Controls.Add(label5);
            Controls.Add(CinsiyetCb);
            Controls.Add(label4);
            Controls.Add(DogumTrhTb);
            Controls.Add(label3);
            Controls.Add(TelefonTb);
            Controls.Add(label2);
            Controls.Add(AdSoyadTb);
            Controls.Add(label1);
            Controls.Add(YonetimDgv);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "OgrenciYonetim";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OgrenciYonetim";
            Load += OgrenciYonetim_Load;
            ((System.ComponentModel.ISupportInitialize)YonetimDgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)YonetimPb).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView YonetimDgv;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox YonetimPb;
        private TextBox AdresTb;
        private Label label5;
        private ComboBox CinsiyetCb;
        private Label label4;
        private DateTimePicker DogumTrhTb;
        private Label label3;
        private TextBox TelefonTb;
        private Label label2;
        private TextBox AdSoyadTb;
        private Label label1;
        private Button button4;
        private TextBox FilterTb;
        private Button button5;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label6;
        private TextBox ResimTb;
        private Label label7;
        private Label label8;
        private OpenFileDialog openFileDialog1;
        private Button button6;
    }
}