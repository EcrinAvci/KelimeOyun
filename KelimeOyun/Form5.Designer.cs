namespace KelimeOyun
{
    partial class Form5
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
            button1 = new Button();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            textBoxYeniKelimeCikmaSayisi = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(182, 179);
            button1.Name = "button1";
            button1.Size = new Size(125, 31);
            button1.TabIndex = 1;
            button1.Text = "Değiştir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(textBoxYeniKelimeCikmaSayisi);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(331, 242);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._326905;
            pictureBox1.Location = new Point(72, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // textBoxYeniKelimeCikmaSayisi
            // 
            textBoxYeniKelimeCikmaSayisi.Location = new Point(28, 179);
            textBoxYeniKelimeCikmaSayisi.Multiline = true;
            textBoxYeniKelimeCikmaSayisi.Name = "textBoxYeniKelimeCikmaSayisi";
            textBoxYeniKelimeCikmaSayisi.Size = new Size(114, 30);
            textBoxYeniKelimeCikmaSayisi.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(72, 19);
            label1.Name = "label1";
            label1.Size = new Size(183, 25);
            label1.TabIndex = 2;
            label1.Text = "Kelime Çıkma Sayısı";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 268);
            Controls.Add(groupBox1);
            Name = "Form5";
            Text = "Form5";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private GroupBox groupBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox textBoxYeniKelimeCikmaSayisi;
    }
}