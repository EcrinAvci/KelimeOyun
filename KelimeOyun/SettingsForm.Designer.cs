namespace KelimeOyun
{
    partial class SettingsForm
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
            txtYeniKelime = new TextBox();
            btnKaydet = new Button();
            lblYeniKelime = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtYeniKelime
            // 
            txtYeniKelime.Location = new Point(216, 166);
            txtYeniKelime.Name = "txtYeniKelime";
            txtYeniKelime.Size = new Size(57, 23);
            txtYeniKelime.TabIndex = 0;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(216, 195);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(57, 23);
            btnKaydet.TabIndex = 1;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += button1_Click;
            // 
            // lblYeniKelime
            // 
            lblYeniKelime.AutoSize = true;
            lblYeniKelime.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblYeniKelime.Location = new Point(12, 166);
            lblYeniKelime.Name = "lblYeniKelime";
            lblYeniKelime.Size = new Size(198, 21);
            lblYeniKelime.TabIndex = 2;
            lblYeniKelime.Text = " Yeni Kelime Çıkma Sayısı :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._326905;
            pictureBox1.Location = new Point(51, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(281, 228);
            Controls.Add(pictureBox1);
            Controls.Add(lblYeniKelime);
            Controls.Add(btnKaydet);
            Controls.Add(txtYeniKelime);
            Name = "SettingsForm";
            Text = "SettingsForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtYeniKelime;
        private Button btnKaydet;
        private Label lblYeniKelime;
        private PictureBox pictureBox1;
    }
}