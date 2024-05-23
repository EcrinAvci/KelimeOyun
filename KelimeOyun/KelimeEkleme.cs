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
    public partial class KelimeEkleme : Form
    {
        public KelimeEkleme()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        private void AddQuestionWithImage(string soru, byte[] imageData, string kelime)
        {
            try
            {
                using (SqlConnection connection = bgl.baglanti())
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO tblSorular (SoruT, Resim, SoruK) VALUES (@SoruT, @Resim, @SoruK)", connection);
                    cmd.Parameters.AddWithValue("@SoruT", soru);
                    cmd.Parameters.AddWithValue("@Resim", imageData);
                    cmd.Parameters.AddWithValue("@SoruK", kelime);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Soru ve resim başarıyla yüklendi!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string soru = txtEngAd.Text;
            string kelime = txtTrAd.Text;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                byte[] imageData = File.ReadAllBytes(imagePath);
                AddQuestionWithImage(soru, imageData,kelime);
            }

        }
    }
}
