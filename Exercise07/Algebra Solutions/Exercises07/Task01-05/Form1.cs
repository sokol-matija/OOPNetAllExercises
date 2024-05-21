using System.Drawing.Printing;

namespace Task01_05
{
    public partial class Form1 : Form
    {
        private int printedPages;

        public Form1()
        {
            InitializeComponent();
            printedPages = 0;
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void BtnSelectMargins_Click(object sender, EventArgs e)
        {
            pageSetupDialog.ShowDialog();
        }

        private void BtnPreview_Click(object sender, EventArgs e)
        {
            printPreviewDialog.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            var font = new Font("Arial", 22, FontStyle.Regular, GraphicsUnit.Pixel);
            e.Graphics?.DrawString("Dobar dan.", font, Brushes.Green, new PointF(e.MarginBounds.X, e.MarginBounds.Y));

            if (++printedPages < nudCopiesCount.Value)
            {
                e.HasMorePages = true;
            }
            else
            {
                printedPages = 0;
            }
        }

        private void PrintDocument_EndPrint(object sender, PrintEventArgs e)
        {
            if (e.PrintAction == PrintAction.PrintToPrinter)
            {
                MessageBox.Show("Printing finished.");
            }
        }
    }
}
