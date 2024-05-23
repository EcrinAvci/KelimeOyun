using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeOyun
{
    public partial class UserModule : Form
    {
        public UserModule()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KelimeEkleme frm3 = new KelimeEkleme();
            frm3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Exam frm4 = new Exam();
            frm4.Show();
            this.Hide();
        }
    }
}
