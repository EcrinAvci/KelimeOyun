using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeOyun
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        public event Action<int> NewWordCountChanged;

        public SettingsForm(int currentWordCount)
        {
            InitializeComponent();
            textBox1.Text = currentWordCount.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Kullanıcının girdiği değeri al ve geçerli bir tamsayı olup olmadığını kontrol et
            if (int.TryParse(textBox1.Text, out int newWordCount))
            {
                NewWordCountChanged?.Invoke(newWordCount);
                this.Close();
            }
            else
            {
                // Geçersiz giriş durumunda bir mesaj göster
                MessageBox.Show("Lütfen geçerli bir sayı girin.", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
