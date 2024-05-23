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
            SqlCommand komut2 = new SqlCommand("Insert Into tbl_Kullanici(KullaniciAdi , Sifre) values (@p1,@p2)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", textBox1.Text);
            komut2.Parameters.AddWithValue("@p2", textBox2.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Kaydınız Başarıyla Gerçekleşmiştir.");
        }
    }
}
