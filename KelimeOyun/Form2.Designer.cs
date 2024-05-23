namespace KelimeOyun
{
    partial class Form2
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
            label2 = new Label();
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources._3159359;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(192, 143);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(47, 158);
            label2.Name = "label2";
            label2.Size = new Size(116, 21);
            label2.TabIndex = 2;
            label2.Text = "Kelime Ekleme";
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources._8750666;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(232, 12);
            button2.Name = "button2";
            button2.Size = new Size(205, 143);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(305, 158);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 4;
            label1.Text = "Sınav";
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.options_icon_30;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(8, 196);
            button3.Name = "button3";
            button3.Size = new Size(196, 143);
            button3.TabIndex = 5;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources._6104564;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Location = new Point(232, 196);
            button4.Name = "button4";
            button4.Size = new Size(205, 143);
            button4.TabIndex = 6;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            label3.Location = new Point(71, 342);
            label3.Name = "label3";
            label3.Size = new Size(67, 21);
            label3.TabIndex = 7;
            label3.Text = "Ayarlar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            label4.Location = new Point(279, 342);
            label4.Name = "label4";
            label4.Size = new Size(120, 21);
            label4.TabIndex = 8;
            label4.Text = "Analiz Raporu";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 369);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label2;
        private Button button2;
        private Label label1;
        private Button button3;
        private Button button4;
        private Label label3;
        private Label label4;
    }
}