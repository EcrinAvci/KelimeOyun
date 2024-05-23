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
    public partial class AdminLog : Form
    {
        public AdminLog()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            using (var connection = bgl.baglanti())
            {
                connection.Open();

                SqlCommand komut = new SqlCommand("Select * From tbl_Admin WHERE AdminAdi=@p1 and Sifre=@p2", connection);
                komut.Parameters.AddWithValue("@p1", txtAdminAd.Text);
                komut.Parameters.AddWithValue("@p2", txtAdminSifre.Text);

                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    Admin form5 = new Admin();
                    form5.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı ya da şifreyi hatalı girdiniz!");
                }

                dr.Close();
                connection.Close();
            }



        }

    }
}
