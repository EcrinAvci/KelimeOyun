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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public void verilerigoster(string veriler)
        {
            bgl.baglanti().Open();
            SqlDataAdapter da = new SqlDataAdapter(veriler, bgl.baglanti());
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewKullanici.DataSource = ds.Tables[0];
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            verilerigoster("Select * From tbl_Kullanici");

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = bgl.baglanti())
                {
                    connection.Open();
                    SqlCommand komut = new SqlCommand("Delete from tbl_Kullanici where KullaniciAdi=@p1", connection);
                    komut.Parameters.AddWithValue("@p1", txtAd.Text);
                    komut.ExecuteNonQuery();

                    MessageBox.Show("Kullanıcı Silindi.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridViewKullanici.SelectedCells[0].RowIndex;
            txtAd.Text = dataGridViewKullanici.Rows[secilen].Cells[1].Value.ToString();
            txtSifre.Text = dataGridViewKullanici.Rows[secilen].Cells[2].Value.ToString();
        }
    }
}
