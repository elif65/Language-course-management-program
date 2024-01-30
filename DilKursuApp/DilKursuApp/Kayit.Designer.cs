namespace DilKursuApp
{
    partial class Kayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kayit));
            OgrenciDgv = new DataGridView();
            label1 = new Label();
            OgrenciAdTb = new TextBox();
            label2 = new Label();
            OgrenciTelefonTb = new TextBox();
            label3 = new Label();
            OgrenciDogumTarih = new DateTimePicker();
            label4 = new Label();
            OgrenciCinsCb = new ComboBox();
            label5 = new Label();
            AdresTb = new TextBox();
            OgrenciPb = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            label8 = new Label();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            OgrenciResimTb = new TextBox();
            label7 = new Label();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)OgrenciDgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OgrenciPb).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // OgrenciDgv
            // 
            OgrenciDgv.BackgroundColor = Color.White;
            OgrenciDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OgrenciDgv.Location = new Point(-3, 52);
            OgrenciDgv.Name = "OgrenciDgv";
            OgrenciDgv.RowTemplate.Height = 25;
            OgrenciDgv.Size = new Size(902, 201);
            OgrenciDgv.TabIndex = 0;
            OgrenciDgv.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(45, 280);
            label1.Name = "label1";
            label1.Size = new Size(89, 19);
            label1.TabIndex = 1;
            label1.Text = "Ad Soyad:";
            // 
            // OgrenciAdTb
            // 
            OgrenciAdTb.Location = new Point(140, 280);
            OgrenciAdTb.Name = "OgrenciAdTb";
            OgrenciAdTb.Size = new Size(169, 23);
            OgrenciAdTb.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(347, 280);
            label2.Name = "label2";
            label2.Size = new Size(68, 19);
            label2.TabIndex = 3;
            label2.Text = "Telefon:";
            // 
            // OgrenciTelefonTb
            // 
            OgrenciTelefonTb.Location = new Point(432, 276);
            OgrenciTelefonTb.Name = "OgrenciTelefonTb";
            OgrenciTelefonTb.Size = new Size(176, 23);
            OgrenciTelefonTb.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(18, 320);
            label3.Name = "label3";
            label3.Size = new Size(116, 19);
            label3.TabIndex = 5;
            label3.Text = "Doğum Tarihi:";
            // 
            // OgrenciDogumTarih
            // 
            OgrenciDogumTarih.Format = DateTimePickerFormat.Short;
            OgrenciDogumTarih.Location = new Point(140, 316);
            OgrenciDogumTarih.Name = "OgrenciDogumTarih";
            OgrenciDogumTarih.Size = new Size(169, 23);
            OgrenciDogumTarih.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(343, 315);
            label4.Name = "label4";
            label4.Size = new Size(72, 19);
            label4.TabIndex = 7;
            label4.Text = "Cinsiyet:";
            // 
            // OgrenciCinsCb
            // 
            OgrenciCinsCb.FormattingEnabled = true;
            OgrenciCinsCb.Items.AddRange(new object[] { "Kadın ", "Erkek" });
            OgrenciCinsCb.Location = new Point(432, 316);
            OgrenciCinsCb.Name = "OgrenciCinsCb";
            OgrenciCinsCb.Size = new Size(176, 23);
            OgrenciCinsCb.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(77, 352);
            label5.Name = "label5";
            label5.Size = new Size(57, 19);
            label5.TabIndex = 9;
            label5.Text = "Adres:";
            // 
            // AdresTb
            // 
            AdresTb.Location = new Point(140, 353);
            AdresTb.Multiline = true;
            AdresTb.Name = "AdresTb";
            AdresTb.Size = new Size(169, 88);
            AdresTb.TabIndex = 10;
            // 
            // OgrenciPb
            // 
            OgrenciPb.Location = new Point(674, 276);
            OgrenciPb.Name = "OgrenciPb";
            OgrenciPb.Size = new Size(169, 140);
            OgrenciPb.SizeMode = PictureBoxSizeMode.StretchImage;
            OgrenciPb.TabIndex = 11;
            OgrenciPb.TabStop = false;
            OgrenciPb.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(614, 349);
            button1.Name = "button1";
            button1.Size = new Size(39, 33);
            button1.TabIndex = 12;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkOrange;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(499, 470);
            button2.Name = "button2";
            button2.Size = new Size(169, 33);
            button2.TabIndex = 13;
            button2.Text = "RESET";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkCyan;
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(674, 470);
            button3.Name = "button3";
            button3.Size = new Size(169, 33);
            button3.TabIndex = 14;
            button3.Text = "EKLE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(53, 141, 66);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 57);
            panel1.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(12, 24);
            label8.Name = "label8";
            label8.Size = new Size(51, 25);
            label8.TabIndex = 17;
            label8.Text = "<<<";
            label8.Click += label8_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(809, 3);
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
            label6.Size = new Size(151, 25);
            label6.TabIndex = 16;
            label6.Text = "Öğrenci Kayıt";
            // 
            // OgrenciResimTb
            // 
            OgrenciResimTb.Location = new Point(432, 352);
            OgrenciResimTb.Name = "OgrenciResimTb";
            OgrenciResimTb.Size = new Size(176, 23);
            OgrenciResimTb.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(357, 356);
            label7.Name = "label7";
            label7.Size = new Size(58, 19);
            label7.TabIndex = 16;
            label7.Text = "Resim:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Kayit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 515);
            Controls.Add(OgrenciResimTb);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(OgrenciPb);
            Controls.Add(AdresTb);
            Controls.Add(label5);
            Controls.Add(OgrenciCinsCb);
            Controls.Add(label4);
            Controls.Add(OgrenciDogumTarih);
            Controls.Add(label3);
            Controls.Add(OgrenciTelefonTb);
            Controls.Add(label2);
            Controls.Add(OgrenciAdTb);
            Controls.Add(label1);
            Controls.Add(OgrenciDgv);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Kayit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kayit";
            Load += Kayit_Load;
            ((System.ComponentModel.ISupportInitialize)OgrenciDgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)OgrenciPb).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView OgrenciDgv;
        private Label label1;
        private TextBox OgrenciAdTb;
        private Label label2;
        private TextBox OgrenciTelefonTb;
        private Label label3;
        private DateTimePicker OgrenciDogumTarih;
        private Label label4;
        private ComboBox OgrenciCinsCb;
        private Label label5;
        private TextBox AdresTb;
        private PictureBox OgrenciPb;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private Label label6;
        private PictureBox pictureBox2;
        private TextBox OgrenciResimTb;
        private Label label7;
        private OpenFileDialog openFileDialog1;
        private Label label8;
    }
}