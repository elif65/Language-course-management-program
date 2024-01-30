namespace DilKursuApp
{
    partial class Login
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
            label = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            KullaniciTb = new TextBox();
            SifreTb = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.White;
            label.Font = new Font("Engravers MT", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label.ForeColor = Color.FromArgb(53, 141, 66);
            label.Location = new Point(-2, 44);
            label.Name = "label";
            label.Size = new Size(127, 112);
            label.TabIndex = 18;
            label.Text = "E";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(190, 200);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 44;
            label3.Text = "Kullanıcı:";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Location = new Point(300, 224);
            label1.Name = "label1";
            label1.Size = new Size(200, 1);
            label1.TabIndex = 45;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Location = new Point(300, 275);
            label2.Name = "label2";
            label2.Size = new Size(200, 1);
            label2.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(234, 251);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 46;
            label4.Text = "Şifre:";
            // 
            // KullaniciTb
            // 
            KullaniciTb.BackColor = Color.FromArgb(53, 141, 66);
            KullaniciTb.BorderStyle = BorderStyle.None;
            KullaniciTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            KullaniciTb.ForeColor = Color.White;
            KullaniciTb.Location = new Point(300, 202);
            KullaniciTb.Name = "KullaniciTb";
            KullaniciTb.Size = new Size(200, 20);
            KullaniciTb.TabIndex = 48;
            // 
            // SifreTb
            // 
            SifreTb.BackColor = Color.FromArgb(53, 141, 66);
            SifreTb.BorderStyle = BorderStyle.None;
            SifreTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SifreTb.ForeColor = Color.White;
            SifreTb.Location = new Point(300, 253);
            SifreTb.Name = "SifreTb";
            SifreTb.PasswordChar = '*';
            SifreTb.Size = new Size(200, 20);
            SifreTb.TabIndex = 49;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 0, 64);
            button1.Location = new Point(322, 352);
            button1.Name = "button1";
            button1.Size = new Size(123, 33);
            button1.TabIndex = 50;
            button1.Text = "LOGİN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = Properties.Resources.close_150192_12801;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(754, 12);
            button2.Name = "button2";
            button2.Size = new Size(34, 34);
            button2.TabIndex = 51;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(53, 141, 66);
            button3.Location = new Point(122, 44);
            button3.Name = "button3";
            button3.Size = new Size(679, 112);
            button3.TabIndex = 52;
            button3.Text = "Ercel Dil Kursu";
            button3.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.WhiteSmoke;
            linkLabel1.Location = new Point(322, 292);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(126, 15);
            linkLabel1.TabIndex = 53;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "I Forgot My Password";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel2.LinkColor = Color.WhiteSmoke;
            linkLabel2.Location = new Point(355, 317);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(50, 15);
            linkLabel2.TabIndex = 54;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Sign Up";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 141, 66);
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(SifreTb);
            Controls.Add(KullaniciTb);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox KullaniciTb;
        private TextBox SifreTb;
        private Button button1;
        private Button button2;
        private Button button3;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
    }
}