﻿namespace DilKursuApp
{
    partial class PuanYonetim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PuanYonetim));
            panel1 = new Panel();
            button6 = new Button();
            label8 = new Label();
            FilterTb = new TextBox();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            PuanTb = new TextBox();
            label4 = new Label();
            KursSecCb = new ComboBox();
            AciklamaTb = new TextBox();
            label3 = new Label();
            label1 = new Label();
            OgrenciIdTb = new TextBox();
            label2 = new Label();
            button5 = new Button();
            button4 = new Button();
            button1 = new Button();
            PuanDgv = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PuanDgv).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(53, 141, 66);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(FilterTb);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(871, 62);
            panel1.TabIndex = 47;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkOrange;
            button6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(786, 23);
            button6.Name = "button6";
            button6.Size = new Size(82, 31);
            button6.TabIndex = 56;
            button6.Text = "YENİLE";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(12, 23);
            label8.Name = "label8";
            label8.Size = new Size(51, 25);
            label8.TabIndex = 55;
            label8.Text = "<<<";
            label8.Click += label8_Click;
            // 
            // FilterTb
            // 
            FilterTb.Location = new Point(540, 29);
            FilterTb.Name = "FilterTb";
            FilterTb.Size = new Size(176, 23);
            FilterTb.TabIndex = 54;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkOrange;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(722, 23);
            button2.Name = "button2";
            button2.Size = new Size(59, 31);
            button2.TabIndex = 32;
            button2.Text = "ARA";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2122, -35);
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
            pictureBox2.Location = new Point(2822, -57);
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
            label6.Size = new Size(153, 25);
            label6.TabIndex = 16;
            label6.Text = "Puan Yönetim";
            // 
            // PuanTb
            // 
            PuanTb.Location = new Point(386, 301);
            PuanTb.Name = "PuanTb";
            PuanTb.Size = new Size(169, 23);
            PuanTb.TabIndex = 50;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(327, 300);
            label4.Name = "label4";
            label4.Size = new Size(53, 19);
            label4.TabIndex = 49;
            label4.Text = "Puan:";
            // 
            // KursSecCb
            // 
            KursSecCb.FormattingEnabled = true;
            KursSecCb.Location = new Point(113, 353);
            KursSecCb.Name = "KursSecCb";
            KursSecCb.Size = new Size(169, 23);
            KursSecCb.TabIndex = 48;
            // 
            // AciklamaTb
            // 
            AciklamaTb.Location = new Point(113, 398);
            AciklamaTb.Multiline = true;
            AciklamaTb.Name = "AciklamaTb";
            AciklamaTb.Size = new Size(169, 90);
            AciklamaTb.TabIndex = 44;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(17, 397);
            label3.Name = "label3";
            label3.Size = new Size(90, 19);
            label3.TabIndex = 43;
            label3.Text = "Açıklama:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(31, 352);
            label1.Name = "label1";
            label1.Size = new Size(76, 19);
            label1.TabIndex = 42;
            label1.Text = "Kurs Seç:";
            // 
            // OgrenciIdTb
            // 
            OgrenciIdTb.Location = new Point(113, 301);
            OgrenciIdTb.Name = "OgrenciIdTb";
            OgrenciIdTb.Size = new Size(169, 23);
            OgrenciIdTb.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(12, 300);
            label2.Name = "label2";
            label2.Size = new Size(95, 19);
            label2.TabIndex = 40;
            label2.Text = "Öğrenci Id:";
            // 
            // button5
            // 
            button5.BackColor = Color.DarkOrange;
            button5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(313, 455);
            button5.Name = "button5";
            button5.Size = new Size(169, 33);
            button5.TabIndex = 51;
            button5.Text = "RESET";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.OrangeRed;
            button4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(488, 455);
            button4.Name = "button4";
            button4.Size = new Size(169, 33);
            button4.TabIndex = 52;
            button4.Text = "GÜNCELLE";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkCyan;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(663, 455);
            button1.Name = "button1";
            button1.Size = new Size(169, 33);
            button1.TabIndex = 53;
            button1.Text = "SİL";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PuanDgv
            // 
            PuanDgv.BackgroundColor = Color.White;
            PuanDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PuanDgv.Location = new Point(113, 68);
            PuanDgv.Name = "PuanDgv";
            PuanDgv.RowTemplate.Height = 25;
            PuanDgv.Size = new Size(616, 210);
            PuanDgv.TabIndex = 55;
            PuanDgv.CellClick += PuanDgv_CellClick;
            // 
            // PuanYonetim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(871, 491);
            Controls.Add(PuanDgv);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(panel1);
            Controls.Add(PuanTb);
            Controls.Add(label4);
            Controls.Add(KursSecCb);
            Controls.Add(AciklamaTb);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(OgrenciIdTb);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PuanYonetim";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PuanYonetim";
            Load += PuanYonetim_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PuanDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label6;
        private TextBox PuanTb;
        private Label label4;
        private ComboBox KursSecCb;
        private TextBox AciklamaTb;
        private Label label3;
        private Label label1;
        private TextBox OgrenciIdTb;
        private Label label2;
        private Button button5;
        private Button button4;
        private Button button1;
        private Button button2;
        private TextBox FilterTb;
        private DataGridView PuanDgv;
        private Label label8;
        private Button button6;
    }
}