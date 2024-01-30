namespace DilKursuApp
{
    partial class YeniPuan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YeniPuan));
            panel1 = new Panel();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            button3 = new Button();
            button2 = new Button();
            AciklamaTb = new TextBox();
            label3 = new Label();
            label1 = new Label();
            OgrenciİdTb = new TextBox();
            label2 = new Label();
            PuanDgv = new DataGridView();
            KursSecCb = new ComboBox();
            PuanTb = new TextBox();
            label4 = new Label();
            OgrenciDgv = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PuanDgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OgrenciDgv).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(53, 141, 66);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(871, 62);
            panel1.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(12, 21);
            label8.Name = "label8";
            label8.Size = new Size(51, 25);
            label8.TabIndex = 33;
            label8.Text = "<<<";
            label8.Click += label8_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1451, -16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(2151, -38);
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
            label6.Location = new Point(368, 21);
            label6.Name = "label6";
            label6.Size = new Size(114, 25);
            label6.TabIndex = 16;
            label6.Text = "Yeni Puan";
            // 
            // button3
            // 
            button3.BackColor = Color.DarkCyan;
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(690, 452);
            button3.Name = "button3";
            button3.Size = new Size(169, 33);
            button3.TabIndex = 34;
            button3.Text = "EKLE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkOrange;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(515, 452);
            button2.Name = "button2";
            button2.Size = new Size(169, 33);
            button2.TabIndex = 33;
            button2.Text = "RESET";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // AciklamaTb
            // 
            AciklamaTb.Location = new Point(113, 395);
            AciklamaTb.Multiline = true;
            AciklamaTb.Name = "AciklamaTb";
            AciklamaTb.Size = new Size(169, 90);
            AciklamaTb.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(17, 394);
            label3.Name = "label3";
            label3.Size = new Size(90, 19);
            label3.TabIndex = 31;
            label3.Text = "Açıklama:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(31, 349);
            label1.Name = "label1";
            label1.Size = new Size(76, 19);
            label1.TabIndex = 29;
            label1.Text = "Kurs Seç:";
            // 
            // OgrenciİdTb
            // 
            OgrenciİdTb.Location = new Point(113, 298);
            OgrenciİdTb.Name = "OgrenciİdTb";
            OgrenciİdTb.Size = new Size(169, 23);
            OgrenciİdTb.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(12, 297);
            label2.Name = "label2";
            label2.Size = new Size(95, 19);
            label2.TabIndex = 27;
            label2.Text = "Öğrenci Id:";
            // 
            // PuanDgv
            // 
            PuanDgv.BackgroundColor = Color.White;
            PuanDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PuanDgv.Location = new Point(3, 68);
            PuanDgv.Name = "PuanDgv";
            PuanDgv.RowTemplate.Height = 25;
            PuanDgv.Size = new Size(332, 210);
            PuanDgv.TabIndex = 26;
            // 
            // KursSecCb
            // 
            KursSecCb.FormattingEnabled = true;
            KursSecCb.Items.AddRange(new object[] { "Yds Hazırlık", "YksDil Hazırlık", "YökDil Hazırlık", "Genel İngilizce" });
            KursSecCb.Location = new Point(113, 350);
            KursSecCb.Name = "KursSecCb";
            KursSecCb.Size = new Size(169, 23);
            KursSecCb.TabIndex = 36;
            // 
            // PuanTb
            // 
            PuanTb.Location = new Point(386, 298);
            PuanTb.Name = "PuanTb";
            PuanTb.Size = new Size(169, 23);
            PuanTb.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(327, 297);
            label4.Name = "label4";
            label4.Size = new Size(53, 19);
            label4.TabIndex = 37;
            label4.Text = "Puan:";
            // 
            // OgrenciDgv
            // 
            OgrenciDgv.BackgroundColor = Color.White;
            OgrenciDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OgrenciDgv.Location = new Point(341, 68);
            OgrenciDgv.Name = "OgrenciDgv";
            OgrenciDgv.RowTemplate.Height = 25;
            OgrenciDgv.Size = new Size(530, 210);
            OgrenciDgv.TabIndex = 39;
            OgrenciDgv.CellContentClick += dataGridView2_CellContentClick;
            // 
            // YeniPuan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(871, 491);
            Controls.Add(OgrenciDgv);
            Controls.Add(PuanTb);
            Controls.Add(label4);
            Controls.Add(KursSecCb);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(AciklamaTb);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(OgrenciİdTb);
            Controls.Add(label2);
            Controls.Add(PuanDgv);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "YeniPuan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YeniPuan";
            Load += YeniPuan_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PuanDgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)OgrenciDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label6;
        private Button button3;
        private Button button2;
        private TextBox AciklamaTb;
        private Label label3;
        private Label label1;
        private TextBox OgrenciİdTb;
        private Label label2;
        private DataGridView PuanDgv;
        private ComboBox KursSecCb;
        private TextBox PuanTb;
        private Label label4;
        private DataGridView OgrenciDgv;
        private Label label8;
    }
}