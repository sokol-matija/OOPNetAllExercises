using System.Drawing.Printing;

namespace OOPExercise07Task01_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Print_Click(object sender, EventArgs e)
        {
            printDialog.ShowDialog();
        }

        private void SelectMargin_Click(object sender, EventArgs e)
        {
            pageSetupDialog.ShowDialog();
        }

        private void Preview_Click(object sender, EventArgs e)
        {
            printPreviewDialog.ShowDialog();
        }

        private int printedPages = 0;
        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics?.DrawString("Hello, world!", new Font("Arial", 12), Brushes.Black, 100, 100);
            if (++printedPages < nudCopyesCount.Value)
            {
                e.HasMorePages = true;
            }
            else
            {
                printedPages = 0;
            }
        }

        private void printDocument_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (e.PrintAction == PrintAction.PrintToPreview)
            {
                MessageBox.Show("Printing finished successfully!");
            }
        }
    }
}
