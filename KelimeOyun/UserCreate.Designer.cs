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
            textBox2 = new TextBox();
            button2 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(148, 162);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(181, 23);
            textBox2.TabIndex = 23;
            textBox2.UseSystemPasswordChar = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(240, 203);
            button2.Name = "button2";
            button2.Size = new Size(89, 35);
            button2.TabIndex = 22;
            button2.Text = "Kayıt Ol";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(148, 110);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 25);
            textBox1.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 157);
            label2.Name = "label2";
            label2.Size = new Size(57, 25);
            label2.TabIndex = 18;
            label2.Text = "Şifre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 110);
            label1.Name = "label1";
            label1.Size = new Size(130, 25);
            label1.TabIndex = 17;
            label1.Text = "Kullanıcı Adı";
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.free_user_group_icon_307_thumb;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(116, 1);
            button1.Name = "button1";
            button1.Size = new Size(135, 103);
            button1.TabIndex = 24;
            button1.UseVisualStyleBackColor = true;
            // 
            // UserCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(363, 282);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserCreate";
            Text = "UserCreate";
            Load += UserCreate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private Button button2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}