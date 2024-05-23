namespace KelimeOyun
{
    partial class Admin
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
            dataGridViewKullanici = new DataGridView();
            btnSil = new Button();
            label2 = new Label();
            label3 = new Label();
            txtAd = new TextBox();
            txtSifre = new TextBox();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKullanici).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewKullanici
            // 
            dataGridViewKullanici.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKullanici.Location = new Point(205, 16);
            dataGridViewKullanici.Name = "dataGridViewKullanici";
            dataGridViewKullanici.Size = new Size(344, 282);
            dataGridViewKullanici.TabIndex = 0;
            dataGridViewKullanici.CellClick += dataGridView1_CellClick;
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSil.Location = new Point(117, 122);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(65, 31);
            btnSil.TabIndex = 1;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 44);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 3;
            label2.Text = "Kullanıcı Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 86);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 4;
            label3.Text = "Şifre:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(81, 41);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 6;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(82, 83);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(100, 23);
            txtSifre.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtSifre);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(1, 136);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(188, 159);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kullanıcı Sil";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dda4acff5ee800f4b70f1e73508ce8ee;
            pictureBox1.Location = new Point(7, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(555, 307);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewKullanici);
            Name = "Admin";
            Text = "Admin";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewKullanici).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewKullanici;
        private Button btnSil;
        private Label label2;
        private Label label3;
        private TextBox txtAd;
        private TextBox txtSifre;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
    }
}