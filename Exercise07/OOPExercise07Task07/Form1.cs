using System.Drawing.Printing;

namespace OOPExercise07Task07
{
    public partial class Form1 : Form
    {

        private int printtedPages;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (printtedPages++ == 0)
            {
                PrintFirstPage(e);
                e.HasMorePages = true;
            }
            else
            {
                PrintSecondPage(e);
            }
        }

        private void PrintFirstPage(PrintPageEventArgs e)
        {
            var radius = e.MarginBounds.Width / 2;
            var diameter = e.MarginBounds.Width;
            e.Graphics?.FillEllipse(Brushes.Red, e.PageBounds.Width / 2 - radius, e.PageBounds.Height - radius, diameter, diameter);
        }

        private void PrintSecondPage(PrintPageEventArgs e)
        {
            var radius = e.MarginBounds.Width / 2;
            var diameter = e.MarginBounds.Width;
            e.Graphics?.FillEllipse(Brushes.Red, e.PageBounds.Width / 2 - radius, 0 - radius, diameter, diameter);
        }
    }
}
