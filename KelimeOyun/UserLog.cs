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
    public partial class UserLog : Form
    {
        public UserLog()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        
        private void button1_Click(object sender, EventArgs e)
        {

            using (var connection = bgl.baglanti())
            {
                connection.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM tbl_Kullanici WHERE KullaniciAdi = @p1 AND Sifre = @p2", connection);
                komut.Parameters.AddWithValue("@p1", txtKullaniciAD.Text);
                komut.Parameters.AddWithValue("@p2", txtSifre.Text);
                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    UserModule form2 = new UserModule();
                    form2.Show();
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

        private void button2_Click(object sender, EventArgs e)
        {
            UserCreate userCreate = new UserCreate();
            userCreate.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordForgot pF= new PasswordForgot();
            pF.Show();
            this.Hide();
        }
    }
}
