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
    public partial class Form3 : Form
    {
        public Form3()
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
        private void AddQuestionWithImage(string soru, byte[] imageData)
        {
            try
            {
                if (bgl.baglanti().State != System.Data.ConnectionState.Open)
                {
                    bgl.baglanti().Open();
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO tblSorular (SoruT, Resim) VALUES (@SoruT, @Resim)", bgl.baglanti());
                cmd.Parameters.AddWithValue("@SoruT", soru);
                cmd.Parameters.AddWithValue("@Resim", imageData);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Soru ve resim başarıyla yüklendi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (bgl.baglanti().State == System.Data.ConnectionState.Open)
                {
                    bgl.baglanti().Close();
                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
                string soru=textBox1.Text;
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    byte[] imageData = File.ReadAllBytes(imagePath);
                    AddQuestionWithImage(soru, imageData);
                }
        }
    }
}
