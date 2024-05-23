namespace KelimeOyun
{
    partial class UserCreate
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
            txtKayitSifre = new TextBox();
            btnKayit = new Button();
            txtKullaniciKayit = new TextBox();
            lblKullaniciSifre = new Label();
            lblKullaniciAd = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtKayitSifre
            // 
            txtKayitSifre.Location = new Point(161, 199);
            txtKayitSifre.Multiline = true;
            txtKayitSifre.Name = "txtKayitSifre";
            txtKayitSifre.Size = new Size(181, 23);
            txtKayitSifre.TabIndex = 23;
            txtKayitSifre.UseSystemPasswordChar = true;
            // 
            // btnKayit
            // 
            btnKayit.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKayit.Location = new Point(253, 240);
            btnKayit.Name = "btnKayit";
            btnKayit.Size = new Size(89, 35);
            btnKayit.TabIndex = 22;
            btnKayit.Text = "Kayıt Ol";
            btnKayit.UseVisualStyleBackColor = true;
            btnKayit.Click += button2_Click;
            // 
            // txtKullaniciKayit
            // 
            txtKullaniciKayit.Location = new Point(161, 147);
            txtKullaniciKayit.Multiline = true;
            txtKullaniciKayit.Name = "txtKullaniciKayit";
            txtKullaniciKayit.Size = new Size(181, 25);
            txtKullaniciKayit.TabIndex = 19;
            // 
            // lblKullaniciSifre
            // 
            lblKullaniciSifre.AutoSize = true;
            lblKullaniciSifre.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKullaniciSifre.Location = new Point(25, 194);
            lblKullaniciSifre.Name = "lblKullaniciSifre";
            lblKullaniciSifre.Size = new Size(57, 25);
            lblKullaniciSifre.TabIndex = 18;
            lblKullaniciSifre.Text = "Şifre";
            // 
            // lblKullaniciAd
            // 
            lblKullaniciAd.AutoSize = true;
            lblKullaniciAd.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKullaniciAd.Location = new Point(25, 147);
            lblKullaniciAd.Name = "lblKullaniciAd";
            lblKullaniciAd.Size = new Size(130, 25);
            lblKullaniciAd.TabIndex = 17;
            lblKullaniciAd.Text = "Kullanıcı Adı";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.free_user_group_icon_307_thumb;
            pictureBox1.Location = new Point(80, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(212, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // UserCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(363, 282);
            Controls.Add(pictureBox1);
            Controls.Add(txtKayitSifre);
            Controls.Add(btnKayit);
            Controls.Add(txtKullaniciKayit);
            Controls.Add(lblKullaniciSifre);
            Controls.Add(lblKullaniciAd);
            Name = "UserCreate";
            Text = "UserCreate";
            Load += UserCreate_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKayitSifre;
        private Button btnKayit;
        private TextBox txtKullaniciKayit;
        private Label lblKullaniciSifre;
        private Label lblKullaniciAd;
        private PictureBox pictureBox1;
    }
}