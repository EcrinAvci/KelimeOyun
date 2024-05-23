namespace KelimeOyun
{
    partial class AdminLog
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
            txtAdminSifre = new TextBox();
            btn_AdminGiris = new Button();
            txtAdminAd = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtAdminSifre
            // 
            txtAdminSifre.Location = new Point(169, 193);
            txtAdminSifre.Multiline = true;
            txtAdminSifre.Name = "txtAdminSifre";
            txtAdminSifre.Size = new Size(181, 23);
            txtAdminSifre.TabIndex = 23;
            txtAdminSifre.UseSystemPasswordChar = true;
            // 
            // btn_AdminGiris
            // 
            btn_AdminGiris.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AdminGiris.Location = new Point(261, 233);
            btn_AdminGiris.Name = "btn_AdminGiris";
            btn_AdminGiris.Size = new Size(89, 35);
            btn_AdminGiris.TabIndex = 20;
            btn_AdminGiris.Text = "GİRİŞ";
            btn_AdminGiris.UseVisualStyleBackColor = true;
            btn_AdminGiris.Click += button1_Click;
            // 
            // txtAdminAd
            // 
            txtAdminAd.Location = new Point(169, 141);
            txtAdminAd.Multiline = true;
            txtAdminAd.Name = "txtAdminAd";
            txtAdminAd.Size = new Size(181, 25);
            txtAdminAd.TabIndex = 19;
            //txtAdminAd.TextChanged += txtAdminAd_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 193);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 18;
            label2.Text = "Şifre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 141);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 17;
            label1.Text = "Admin Adı:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dda4acff5ee800f4b70f1e73508ce8ee;
            pictureBox1.Location = new Point(87, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // AdminLog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(372, 272);
            Controls.Add(pictureBox1);
            Controls.Add(txtAdminSifre);
            Controls.Add(btn_AdminGiris);
            Controls.Add(txtAdminAd);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminLog";
            Text = "AdminLog";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtAdminSifre;
        private Button btn_AdminGiris;
        private TextBox txtAdminAd;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}