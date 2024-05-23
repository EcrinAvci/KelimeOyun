namespace KelimeOyun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserLog userlogin = new UserLog();
            userlogin.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminLog adminlogin = new AdminLog(); 
            adminlogin.Show();
            this.Hide();
        }
    }
}
