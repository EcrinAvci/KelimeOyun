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
    public partial class UserCreate : Form
    {
        public UserCreate()
        {
            InitializeComponent();
        }

        private void UserCreate_Load(object sender, EventArgs e)
        {

        }
        sqlbaglantisi bgl =new sqlbaglantisi();
        private void button2_Click(object sender, EventArgs e)
        {
            using (var connection = bgl.baglanti())
            {
                connection.Open();

                SqlCommand komut2 = new SqlCommand("Insert Into tbl_Kullanici(KullaniciAdi , Sifre) values (@p1,@p2)", connection);
                komut2.Parameters.AddWithValue("@p1", txtKullaniciKayit.Text);
                komut2.Parameters.AddWithValue("@p2", txtKayitSifre.Text);
                komut2.ExecuteNonQuery();

                MessageBox.Show("Kaydınız Başarıyla Gerçekleşmiştir.");

                connection.Close();
            }
        }
    }
}
