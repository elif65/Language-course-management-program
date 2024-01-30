namespace DilKursuApp
{
    partial class OgrenciYazdir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciYazdir));
            panel1 = new Panel();
            button1 = new Button();
            label8 = new Label();
            pictureBox2 = new PictureBox();
            FilterTb = new TextBox();
            button5 = new Button();
            label6 = new Label();
            yazdırDgv = new DataGridView();
            button3 = new Button();
            label1 = new Label();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yazdırDgv).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(53, 141, 66);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(FilterTb);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 57);
            panel1.TabIndex = 34;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(805, 17);
            button1.Name = "button1";
            button1.Size = new Size(67, 31);
            button1.TabIndex = 37;
            button1.Text = "YENİLE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(12, 19);
            label8.Name = "label8";
            label8.Size = new Size(51, 25);
            label8.TabIndex = 33;
            label8.Text = "<<<";
            label8.Click += label8_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3111, -41);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(91, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // FilterTb
            // 
            FilterTb.Location = new Point(565, 20);
            FilterTb.Name = "FilterTb";
            FilterTb.Size = new Size(176, 23);
            FilterTb.TabIndex = 30;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkOrange;
            button5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(747, 17);
            button5.Name = "button5";
            button5.Size = new Size(52, 31);
            button5.TabIndex = 31;
            button5.Text = "ARA";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label6
            // 
            label6.AllowDrop = true;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(345, 14);
            label6.Name = "label6";
            label6.Size = new Size(163, 25);
            label6.TabIndex = 16;
            label6.Text = "Öğrenci  Listesi";
            // 
            // yazdırDgv
            // 
            yazdırDgv.BackgroundColor = Color.White;
            yazdırDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            yazdırDgv.Location = new Point(0, 102);
            yazdırDgv.Name = "yazdırDgv";
            yazdırDgv.RowTemplate.Height = 25;
            yazdırDgv.Size = new Size(904, 345);
            yazdırDgv.TabIndex = 33;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkCyan;
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(747, 453);
            button3.Name = "button3";
            button3.Size = new Size(143, 33);
            button3.TabIndex = 35;
            button3.Text = "YAZDIR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(345, 60);
            label1.Name = "label1";
            label1.Size = new Size(188, 32);
            label1.TabIndex = 36;
            label1.Text = "Öğrenci  Listesi";
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // OgrenciYazdir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 490);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(yazdırDgv);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "OgrenciYazdir";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OgrenciYazdir";
            Load += OgrenciYazdir_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)yazdırDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private TextBox FilterTb;
        private Button button5;
        private Label label6;
        private DataGridView yazdırDgv;
        private Button button3;
        private Label label1;
        private Label label8;
        private Button button1;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}