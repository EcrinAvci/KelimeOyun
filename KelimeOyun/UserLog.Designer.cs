namespace KelimeOyun
{
    partial class UserLog
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
            txtSifre = new TextBox();
            btnKayit = new Button();
            linkLblSifreUnuttum = new LinkLabel();
            btnGiris = new Button();
            txtKullaniciAD = new TextBox();
            lblSifre = new Label();
            lblKullaniciAd = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(172, 193);
            txtSifre.Multiline = true;
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(181, 23);
            txtSifre.TabIndex = 16;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // btnKayit
            // 
            btnKayit.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKayit.Location = new Point(172, 249);
            btnKayit.Name = "btnKayit";
            btnKayit.Size = new Size(89, 35);
            btnKayit.TabIndex = 14;
            btnKayit.Text = "Kayıt Ol";
            btnKayit.UseVisualStyleBackColor = true;
            btnKayit.Click += button2_Click;
            // 
            // linkLblSifreUnuttum
            // 
            linkLblSifreUnuttum.AutoSize = true;
            linkLblSifreUnuttum.Location = new Point(258, 221);
            linkLblSifreUnuttum.Name = "linkLblSifreUnuttum";
            linkLblSifreUnuttum.Size = new Size(95, 15);
            linkLblSifreUnuttum.TabIndex = 13;
            linkLblSifreUnuttum.TabStop = true;
            linkLblSifreUnuttum.Text = "Şifremi Unuttum";
            linkLblSifreUnuttum.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnGiris
            // 
            btnGiris.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGiris.Location = new Point(264, 249);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(89, 35);
            btnGiris.TabIndex = 12;
            btnGiris.Text = "GİRİŞ";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += button1_Click;
            // 
            // txtKullaniciAD
            // 
            txtKullaniciAD.Location = new Point(172, 141);
            txtKullaniciAD.Multiline = true;
            txtKullaniciAD.Name = "txtKullaniciAD";
            txtKullaniciAD.Size = new Size(181, 25);
            txtKullaniciAD.TabIndex = 11;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSifre.Location = new Point(36, 188);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(57, 25);
            lblSifre.TabIndex = 10;
            lblSifre.Text = "Şifre";
            // 
            // lblKullaniciAd
            // 
            lblKullaniciAd.AutoSize = true;
            lblKullaniciAd.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKullaniciAd.Location = new Point(36, 141);
            lblKullaniciAd.Name = "lblKullaniciAd";
            lblKullaniciAd.Size = new Size(130, 25);
            lblKullaniciAd.TabIndex = 9;
            lblKullaniciAd.Text = "Kullanıcı Adı";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.free_user_group_icon_307_thumb;
            pictureBox1.Location = new Point(104, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // UserLog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(395, 289);
            Controls.Add(pictureBox1);
            Controls.Add(txtSifre);
            Controls.Add(btnKayit);
            Controls.Add(linkLblSifreUnuttum);
            Controls.Add(btnGiris);
            Controls.Add(txtKullaniciAD);
            Controls.Add(lblSifre);
            Controls.Add(lblKullaniciAd);
            Name = "UserLog";
            Text = "UserLog";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSifre;
        private Button btnKayit;
        private LinkLabel linkLblSifreUnuttum;
        private Button btnGiris;
        private TextBox txtKullaniciAD;
        private Label lblSifre;
        private Label lblKullaniciAd;
        private PictureBox pictureBox1;
    }
}