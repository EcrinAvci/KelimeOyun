using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeOyun
{
    public partial class AnalysisForm : Form
    {
        private List<QuestionResult> questionResults;

       /* public AnalysisForm(List<QuestionResult> results)
        {
            InitializeComponent();
            questionResults = results;
            LoadAnalysis();
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintPage);
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void LoadAnalysis()
        {
            var groupedResults = questionResults
                .GroupBy(q => q.Topic)
                .Select(g => new
                {
                    Topic = g.Key,
                    SuccessRate = g.Count(r => r.IsCorrect) * 100 / g.Count()
                })
                .ToList();

            dataGridView1.DataSource = groupedResults;
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
    }
}
