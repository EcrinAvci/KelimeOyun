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

        public int YeniKelimeCikmaSayisi { get; set; }

        public SettingsForm(int yeniKelimeCikmaSayisi)
        {
            InitializeComponent();
            YeniKelimeCikmaSayisi = yeniKelimeCikmaSayisi;
            textBox1.Text = yeniKelimeCikmaSayisi.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int yeniSayi))
            {
                YeniKelimeCikmaSayisi = yeniSayi;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin.");
            }
        }
    }
}
