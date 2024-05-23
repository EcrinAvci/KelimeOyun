namespace KelimeOyun
{
    partial class PasswordForgot
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
            label1 = new Label();
            label2 = new Label();
            txtKullaniciAd = new TextBox();
            txtKullaniciSifre = new TextBox();
            btnGuncelle = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 104);
            label1.Name = "label1";
            label1.Size = new Size(108, 21);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 139);
            label2.Name = "label2";
            label2.Size = new Size(93, 21);
            label2.TabIndex = 1;
            label2.Text = "Yeni Şifre ";
            // 
            // txtKullaniciAd
            // 
            txtKullaniciAd.Location = new Point(179, 102);
            txtKullaniciAd.Name = "txtKullaniciAd";
            txtKullaniciAd.Size = new Size(150, 23);
            txtKullaniciAd.TabIndex = 2;
            // 
            // txtKullaniciSifre
            // 
            txtKullaniciSifre.Location = new Point(179, 139);
            txtKullaniciSifre.Name = "txtKullaniciSifre";
            txtKullaniciSifre.Size = new Size(150, 23);
            txtKullaniciSifre.TabIndex = 3;
            txtKullaniciSifre.UseSystemPasswordChar = true;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuncelle.Location = new Point(231, 168);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(98, 34);
            btnGuncelle.TabIndex = 4;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.password;
            pictureBox1.Location = new Point(117, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // PasswordForgot
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(362, 241);
            Controls.Add(pictureBox1);
            Controls.Add(btnGuncelle);
            Controls.Add(txtKullaniciSifre);
            Controls.Add(txtKullaniciAd);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PasswordForgot";
            Text = "PasswordForgot";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtKullaniciAd;
        private TextBox txtKullaniciSifre;
        private Button btnGuncelle;
        private PictureBox pictureBox1;
    }
}