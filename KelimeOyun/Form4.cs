using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using RadioButton = System.Windows.Forms.RadioButton;

namespace KelimeOyun
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            radioButtons = new RadioButton[] { radioButton1, radioButton2, radioButton3, radioButton4 };
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private int answeredQuestionCount = 0;

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                int userID = GetUserID();
                LoadDailyQuestions(userID); // Günlük soruları yükleyin
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int userID = GetUserID(); 
                bool isCorrect = CheckAnswer(); 

                UserAnsweredQuestion(userID, currentSoruID, isCorrect); // Kullanıcının cevabını işleyin
                LoadNextQuestion();

                answeredQuestionCount++;
                
                if (answeredQuestionCount == 10)
                {
                    MessageBox.Show("Tebrikler! Günlük soruları tamamladınız.");
                    Application.Exit();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private int currentOgrenciID;
        private int currentSoruID;
        private RadioButton[] radioButtons;

        private int GetUserID()
        {
           
            return 1;
        }
        private bool CheckAnswer()
        {
            RadioButton[] radioButtons = { radioButton1, radioButton2, radioButton3, radioButton4 };
            foreach (var radioButton in radioButtons)
            {
                if (radioButton.Checked && radioButton.Tag != null)
                {
                    return (bool)radioButton.Tag;
                }
            }
            return false;
        }

        private void ClearAnswers()
        {
            RadioButton[] radioButtons = { radioButton1, radioButton2, radioButton3, radioButton4 };
            foreach (var radioButton in radioButtons)
            {
                radioButton.Text = string.Empty;
                radioButton.Checked = false;
                radioButton.Tag = null;
            }
        }
        private void LoadDailyQuestions(int userID)
        {
            List<int> questionIDs = GetDailyQuestions();

            foreach (int questionID in questionIDs)
            {
                LoadQuestion(questionID);
                
                UpdateUserProgress(userID, questionID, false); // Başlangıçta sorular yüklenirken false geçilebilir

            }
        }
        private void LoadNextQuestion()
        {
            try
            {
                int userID = GetUserID(); 
                List<int> questionIDs = GetDailyQuestions(userID); 

              
                int currentIndex = questionIDs.IndexOf(currentSoruID);
                int nextIndex = currentIndex + 1;

               
                if (nextIndex < questionIDs.Count)
                {
                    int nextQuestionID = questionIDs[nextIndex];
                    LoadQuestion(nextQuestionID);
                }
                else
                {
                    MessageBox.Show("Tebrikler! Günlük soruları tamamladınız.");
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private List<int> GetDailyQuestions(int userID)
        {
            List<int> questionIDs = new List<int>();

            try
            {
                using (var connection = bgl.baglanti())
                {
                    connection.Open();

                    // Dünkü doğru yanıtlanan soruları al
                    SqlCommand cmdYesterday = new SqlCommand(@"SELECT TOP 10 SoruID FROM tbl_Cevaplar WHERE KullaniciID = @KullaniciID AND CevapTarihi = DATEADD(day, -1, GETDATE())", connection);
                    cmdYesterday.Parameters.AddWithValue("@KullaniciID", userID);

                    SqlDataReader readerYesterday = cmdYesterday.ExecuteReader();
                    while (readerYesterday.Read())
                    {
                        questionIDs.Add(Convert.ToInt32(readerYesterday["SoruID"]));
                    }
                    readerYesterday.Close();

                    // Dünkü doğru yanıtlanan soruların sayısını al
                    int answeredQuestionCount = questionIDs.Count;

                    // Eğer dünkü doğru yanıtlanan soruların sayısı 10'dan azsa, eksik olan soruları rastgele seç
                    if (answeredQuestionCount < 10)
                    {
                        SqlCommand cmdRandom = new SqlCommand(@"SELECT TOP " + (10 - answeredQuestionCount) + " SoruID FROM tblSorular WHERE SoruID NOT IN (SELECT SoruID FROM tbl_Cevaplar WHERE KullaniciID = @KullaniciID AND CevapTarihi = DATEADD(day, -1, GETDATE())) ORDER BY NEWID()", connection);
                        cmdRandom.Parameters.AddWithValue("@KullaniciID", userID);

                        SqlDataReader readerRandom = cmdRandom.ExecuteReader();
                        while (readerRandom.Read())
                        {
                            questionIDs.Add(Convert.ToInt32(readerRandom["SoruID"]));
                        }
                        readerRandom.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return questionIDs;
        }




        private void LoadQuestion(int questionID)
        {
            try
            {
                using (var connection = bgl.baglanti())
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM tblSorular WHERE SoruID=@SoruID", connection);
                    cmd.Parameters.AddWithValue("@SoruID", questionID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        label1.Text = reader["SoruT"].ToString();
                        ClearAnswers();
                        LoadAnswers(questionID);
                        LoadImage(questionID); // Sorulara resimleri yükle
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void LoadImage(int questionID)
        {
            try
            {
                using (var connection = bgl.baglanti())
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("SELECT Resim FROM tblSorular WHERE SoruID=@SoruID", connection);
                    cmd.Parameters.AddWithValue("@SoruID", questionID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        byte[] imageData = reader["Resim"] as byte[];
                        if (imageData != null && imageData.Length > 0)
                        {
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                pictureBox1.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            pictureBox1.Image = null; 
                        }
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void LoadAnswers(int questionID)
        {
            try
            {
                using (var connection = bgl.baglanti())
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_Cevaplar WHERE SoruID=@SoruID", connection);
                    cmd.Parameters.AddWithValue("@SoruID", questionID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    int answerIndex = 0;
                    while (reader.Read())
                    {
                        RadioButton radioButton = radioButtons[answerIndex];
                        radioButton.Text = reader["CevapT"].ToString();
                        radioButton.Tag = (bool)reader["DogruC"];
                        answerIndex++;
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); 
            }
        }




        private void UserAnsweredQuestion(int userID, int questionID, bool isCorrect)
        {
            ProcessAnswer(questionID, isCorrect);
            UpdateUserProgress(userID, questionID, isCorrect);
        }
        private void ProcessAnswer(int questionID, bool isCorrect)
        {
            try
            {
                using (var connection = bgl.baglanti())
                {
                    connection.Open();

                    if (isCorrect)
                    {
                        // Doğru sayısını güncelle
                        SqlCommand cmdUpdate = new SqlCommand(@"UPDATE tblSorular SET DogruSayisi = DogruSayisi + 1 WHERE SoruID = @SoruID", connection);
                        cmdUpdate.Parameters.AddWithValue("@SoruID", questionID);
                        cmdUpdate.ExecuteNonQuery();

                        // Cevap tarihini ekle
                        SqlCommand cmdInsert = new SqlCommand(@"INSERT INTO tbl_Cevaplar (SoruID, CevapTarihi) VALUES (@SoruID, @CevapTarihi)", connection);
                        cmdInsert.Parameters.AddWithValue("@SoruID", questionID);
                        cmdInsert.Parameters.AddWithValue("@CevapTarihi", DateTime.Today);
                        cmdInsert.ExecuteNonQuery();

                        // 6 kez doğru yanıtlanmışsa bilinen sorulara ekle
                        SqlCommand cmdCheck = new SqlCommand(@"SELECT DogruSayisi FROM tblSorular WHERE SoruID = @SoruID", connection);
                        cmdCheck.Parameters.AddWithValue("@SoruID", questionID);

                        object result = cmdCheck.ExecuteScalar();
                        int dogruSayisi = (result != null && result != DBNull.Value) ? (int)result : 0;
                        if (dogruSayisi >= 6)
                        {
                            SqlCommand cmdMove = new SqlCommand(@"INSERT INTO tbl_BilinenSorular (SoruID) VALUES (@SoruID);
                            DELETE FROM tblSorular WHERE SoruID = @SoruID;", connection);
                            cmdMove.Parameters.AddWithValue("@SoruID", questionID);
                            cmdMove.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        // Eğer yanlışsa doğru sayısını sıfırla
                        SqlCommand cmdReset = new SqlCommand(@"UPDATE tblSorular SET DogruSayisi = 0 WHERE SoruID = @SoruID", connection);
                        cmdReset.Parameters.AddWithValue("@SoruID", questionID);
                        cmdReset.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateUserProgress(int userID, int questionID, bool isCorrect)
        {
            try
            {
                using (var connection = bgl.baglanti())
                {
                    connection.Open();

                    if (isCorrect)
                    {
                        // Kullanıcının toplam doğru sayısını güncelle
                        SqlCommand cmdUpdateUser = new SqlCommand(@"UPDATE tbl_KullaniciIlerleme SET ToplamDogruSayisi = ToplamDogruSayisi + 1, SonGuncellemeTarihi = @SonGuncellemeTarihi WHERE KullaniciID = @KullaniciID", connection);
                        cmdUpdateUser.Parameters.AddWithValue("@KullaniciID", userID);
                        cmdUpdateUser.Parameters.AddWithValue("@SonGuncellemeTarihi", DateTime.Today);
                        int affectedRows = cmdUpdateUser.ExecuteNonQuery();

                        // Eğer kayıt yoksa ekle
                        if (affectedRows == 0)
                        {
                            SqlCommand cmdInsertUser = new SqlCommand(@"INSERT INTO tbl_KullaniciIlerleme (KullaniciID, ToplamDogruSayisi, SonGuncellemeTarihi)VALUES (@KullaniciID, 1, @SonGuncellemeTarihi)", connection);
                            cmdInsertUser.Parameters.AddWithValue("@KullaniciID", userID);
                            cmdInsertUser.Parameters.AddWithValue("@SonGuncellemeTarihi", DateTime.Today);
                            cmdInsertUser.ExecuteNonQuery();
                        }
                    }

                    // Soru ilerlemesini güncelle
                    ProcessAnswer(questionID, isCorrect);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private List<int> GetDailyQuestions()
        {
            List<int> questionIDs = new List<int>();

            try
            {
                using (var connection = bgl.baglanti())
                {
                    connection.Open();

                    // Dün doğru yanıtlanan soruları al
                    SqlCommand cmdYesterday = new SqlCommand(@"SELECT SoruID FROM tbl_Cevaplar WHERE CevapTarihi = @Yesterday", connection);
                    cmdYesterday.Parameters.AddWithValue("@Yesterday", DateTime.Today.AddDays(-1));

                    SqlDataReader readerYesterday = cmdYesterday.ExecuteReader();
                    while (readerYesterday.Read())
                    {
                        questionIDs.Add(Convert.ToInt32(readerYesterday["SoruID"]));
                    }
                    readerYesterday.Close();

                    // Rastgele 10 yeni soru seç, dün doğru yanıtlananlar hariç
                    SqlCommand cmdRandom = new SqlCommand(@"SELECT TOP 10 SoruID FROM tblSorular WHERE SoruID NOT IN (SELECT SoruID FROM tbl_Cevaplar WHERE CevapTarihi = @Yesterday) ORDER BY NEWID()", connection);
                    cmdRandom.Parameters.AddWithValue("@Yesterday", DateTime.Today.AddDays(-1));

                    SqlDataReader readerRandom = cmdRandom.ExecuteReader();
                    while (readerRandom.Read())
                    {
                        questionIDs.Add(Convert.ToInt32(readerRandom["SoruID"]));
                    }
                    readerRandom.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return questionIDs;
        }





        private void button2_Click(object sender, EventArgs e)
        {
        }

    }
}
