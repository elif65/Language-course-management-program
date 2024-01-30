namespace DilKursuApp
{
    partial class YeniKurs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YeniKurs));
            KursDgv = new DataGridView();
            AdTb = new TextBox();
            label2 = new Label();
            SaatTb = new TextBox();
            label1 = new Label();
            AciklamaTb = new TextBox();
            label3 = new Label();
            button3 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)KursDgv).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // KursDgv
            // 
            KursDgv.BackgroundColor = Color.White;
            KursDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            KursDgv.Location = new Point(-1, 53);
            KursDgv.Name = "KursDgv";
            KursDgv.RowTemplate.Height = 25;
            KursDgv.Size = new Size(872, 198);
            KursDgv.TabIndex = 0;
            // 
            // AdTb
            // 
            AdTb.Location = new Point(113, 292);
            AdTb.Name = "AdTb";
            AdTb.Size = new Size(169, 23);
            AdTb.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(32, 292);
            label2.Name = "label2";
            label2.Size = new Size(75, 19);
            label2.TabIndex = 17;
            label2.Text = "Kurs Adı:";
            // 
            // SaatTb
            // 
            SaatTb.Location = new Point(113, 344);
            SaatTb.Name = "SaatTb";
            SaatTb.Size = new Size(169, 23);
            SaatTb.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(23, 344);
            label1.Name = "label1";
            label1.Size = new Size(86, 19);
            label1.TabIndex = 19;
            label1.Text = "Kurs Saati:";
            // 
            // AciklamaTb
            // 
            AciklamaTb.Location = new Point(113, 389);
            AciklamaTb.Multiline = true;
            AciklamaTb.Name = "AciklamaTb";
            AciklamaTb.Size = new Size(169, 90);
            AciklamaTb.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(17, 388);
            label3.Name = "label3";
            label3.Size = new Size(90, 19);
            label3.TabIndex = 21;
            label3.Text = "Açıklama:";
            // 
            // button3
            // 
            button3.BackColor = Color.DarkCyan;
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(690, 446);
            button3.Name = "button3";
            button3.Size = new Size(169, 33);
            button3.TabIndex = 24;
            button3.Text = "EKLE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkOrange;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(515, 446);
            button2.Name = "button2";
            button2.Size = new Size(169, 33);
            button2.TabIndex = 23;
            button2.Text = "RESET";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            panel1.Size = new Size(871, 57);
            panel1.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(12, 25);
            label8.Name = "label8";
            label8.Size = new Size(51, 25);
            label8.TabIndex = 34;
            label8.Text = "<<<";
            label8.Click += label8_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(780, 3);
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
            pictureBox2.Location = new Point(1480, -19);
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
            label6.Location = new Point(374, 9);
            label6.Name = "label6";
            label6.Size = new Size(104, 25);
            label6.TabIndex = 16;
            label6.Text = "Yeni Kurs";
            // 
            // YeniKurs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(871, 491);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(AciklamaTb);
            Controls.Add(label3);
            Controls.Add(SaatTb);
            Controls.Add(label1);
            Controls.Add(AdTb);
            Controls.Add(label2);
            Controls.Add(KursDgv);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "YeniKurs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YeniKurs";
            Load += YeniKurs_Load;
            ((System.ComponentModel.ISupportInitialize)KursDgv).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView KursDgv;
        private TextBox AdTb;
        private Label label2;
        private TextBox SaatTb;
        private Label label1;
        private TextBox AciklamaTb;
        private Label label3;
        private Button button3;
        private Button button2;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label8;
    }
}