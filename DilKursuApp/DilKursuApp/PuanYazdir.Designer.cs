namespace DilKursuApp
{
    partial class PuanYazdir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PuanYazdir));
            panel1 = new Panel();
            label8 = new Label();
            button6 = new Button();
            pictureBox2 = new PictureBox();
            FilterTb = new TextBox();
            button5 = new Button();
            label6 = new Label();
            button3 = new Button();
            PuanDgv = new DataGridView();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PuanDgv).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(53, 141, 66);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(FilterTb);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 57);
            panel1.TabIndex = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(12, 25);
            label8.Name = "label8";
            label8.Size = new Size(51, 25);
            label8.TabIndex = 58;
            label8.Text = "<<<";
            label8.Click += label8_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkOrange;
            button6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(806, 23);
            button6.Name = "button6";
            button6.Size = new Size(82, 31);
            button6.TabIndex = 57;
            button6.Text = "YENİLE";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3611, -85);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(91, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // FilterTb
            // 
            FilterTb.Location = new Point(567, 23);
            FilterTb.Name = "FilterTb";
            FilterTb.Size = new Size(176, 23);
            FilterTb.TabIndex = 30;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkOrange;
            button5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(749, 23);
            button5.Name = "button5";
            button5.Size = new Size(51, 31);
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
            label6.Location = new Point(362, 14);
            label6.Name = "label6";
            label6.Size = new Size(126, 25);
            label6.TabIndex = 16;
            label6.Text = "Puan Listesi";
            // 
            // button3
            // 
            button3.BackColor = Color.DarkCyan;
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(729, 456);
            button3.Name = "button3";
            button3.Size = new Size(143, 33);
            button3.TabIndex = 41;
            button3.Text = "YAZDIR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // PuanDgv
            // 
            PuanDgv.BackgroundColor = Color.White;
            PuanDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PuanDgv.Location = new Point(127, 97);
            PuanDgv.Name = "PuanDgv";
            PuanDgv.RowTemplate.Height = 25;
            PuanDgv.Size = new Size(625, 340);
            PuanDgv.TabIndex = 56;
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
            // PuanYazdir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 490);
            Controls.Add(PuanDgv);
            Controls.Add(panel1);
            Controls.Add(button3);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PuanYazdir";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PuanYazdir";
            Load += PuanYazdir_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PuanDgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private TextBox FilterTb;
        private Button button5;
        private Label label6;
        private Button button3;
        private Button button6;
        private DataGridView PuanDgv;
        private Label label8;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}