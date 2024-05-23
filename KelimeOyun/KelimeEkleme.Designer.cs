namespace KelimeOyun
{
    partial class KelimeEkleme
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
            openFileDialog1 = new OpenFileDialog();
            txtEngAd = new TextBox();
            btnKelimeEkle = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            txtTrAd = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            label1.Location = new Point(49, 253);
            label1.Name = "label1";
            label1.Size = new Size(63, 21);
            label1.TabIndex = 0;
            label1.Text = "Resim ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            label2.Location = new Point(49, 184);
            label2.Name = "label2";
            label2.Size = new Size(107, 21);
            label2.TabIndex = 1;
            label2.Text = "İngilizce Adı";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtEngAd
            // 
            txtEngAd.Location = new Point(162, 186);
            txtEngAd.Name = "txtEngAd";
            txtEngAd.Size = new Size(137, 23);
            txtEngAd.TabIndex = 3;
            // 
            // btnKelimeEkle
            // 
            btnKelimeEkle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKelimeEkle.Location = new Point(162, 248);
            btnKelimeEkle.Name = "btnKelimeEkle";
            btnKelimeEkle.Size = new Size(137, 30);
            btnKelimeEkle.TabIndex = 6;
            btnKelimeEkle.Text = "Ekle";
            btnKelimeEkle.UseVisualStyleBackColor = true;
            btnKelimeEkle.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label4.Location = new Point(49, 9);
            label4.Name = "label4";
            label4.Size = new Size(248, 25);
            label4.TabIndex = 8;
            label4.Text = "KELİME EKLEME SAYFASI";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources._3159359;
            pictureBox1.Location = new Point(49, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(49, 221);
            label3.Name = "label3";
            label3.Size = new Size(90, 19);
            label3.TabIndex = 10;
            label3.Text = "Türkçe Adı";
            // 
            // txtTrAd
            // 
            txtTrAd.Location = new Point(162, 219);
            txtTrAd.Name = "txtTrAd";
            txtTrAd.Size = new Size(137, 23);
            txtTrAd.TabIndex = 11;
            // 
            // KelimeEkleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(345, 286);
            Controls.Add(txtTrAd);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(btnKelimeEkle);
            Controls.Add(txtEngAd);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "KelimeEkleme";
            Text = "Kelime Ekleme";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private OpenFileDialog openFileDialog1;
        private TextBox txtEngAd;
        private Button btnKelimeEkle;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox txtTrAd;
    }
}