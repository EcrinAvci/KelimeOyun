using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeOyun
{
    public partial class PasswordForgot : Form
    {
        public PasswordForgot()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl= new sqlbaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            using (var connection = bgl.baglanti())
            {
                connection.Open();

                SqlCommand komut = new SqlCommand("Update tbl_Kullanici Set Sifre=@p2 WHERE KullaniciAdi=@p1", connection);
                komut.Parameters.AddWithValue("@p1", textBox1.Text);
                komut.Parameters.AddWithValue("@p2", textBox2.Text);
                komut.ExecuteNonQuery();

                MessageBox.Show("İşleminiz başarıyla gerçekleşmiştir.");

                connection.Close();
            }


        }
    }
}
