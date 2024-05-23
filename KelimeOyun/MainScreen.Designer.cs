namespace KelimeOyun
{
    partial class MainScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.free_user_group_icon_307_thumb;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(40, 133);
            button1.Name = "button1";
            button1.Size = new Size(177, 150);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.dda4acff5ee800f4b70f1e73508ce8ee;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(248, 133);
            button2.Name = "button2";
            button2.Size = new Size(177, 150);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(87, 306);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(312, 306);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 3;
            label2.Text = "Admin";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Honeydew;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 100);
            panel1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(98, 40);
            label3.Name = "label3";
            label3.Size = new Size(264, 25);
            label3.TabIndex = 0;
            label3.Text = "6 AŞAMALI KELİME OYUNU";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(461, 380);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Kelime Oyunu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label3;
    }
}
