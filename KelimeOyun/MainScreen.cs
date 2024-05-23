namespace KelimeOyun
{
    public partial class MainScreen : Form
    {
        public MainScreen()
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
