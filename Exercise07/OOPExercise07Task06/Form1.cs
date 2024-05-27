using System.Drawing.Drawing2D;
using System.Drawing.Printing;

namespace OOPExercise07Task06
{
    public partial class Form1 : Form
    {
        private const int RADIUS_OUTER = 50;
        private const int RADIUS_INNER = 20;

        public Form1()
        {
            InitializeComponent();
        }

        private void SetupPages_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void choosePrinterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (e.Graphics is null)
            {
                return;
            }

            // Sharpen graphics (edges are clearer)
            // You can also use AntiAlias ("smoothing the edges")
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            // 1) Drawing outer circles
            var diameterOuter = 2 * RADIUS_OUTER;
            var sizeOuter = new Size(diameterOuter, diameterOuter);

            // Top-Left
            DrawFilledCircle(e, Brushes.Purple, new Point { X = 0, Y = 0 }, sizeOuter);
            // Top-Right
            DrawFilledCircle(e, Brushes.Purple, new Point { X = e.PageBounds.Width - diameterOuter, Y = 0 }, sizeOuter);
            // Bottom-Left
            DrawFilledCircle(e, Brushes.Purple, new Point { X = 0, Y = e.PageBounds.Height - diameterOuter }, sizeOuter);
            // Bottom-Right
            DrawFilledCircle(e, Brushes.Purple, new Point { X = e.PageBounds.Width - diameterOuter, Y = e.PageBounds.Height - diameterOuter }, sizeOuter);

            // 2) Drawing lines (margins and diagonales)
            // Margine
            e.Graphics.DrawRectangle(Pens.Orange, e.MarginBounds);

            // Diagonales
            // From Top-Left to Bottom-Right
            e.Graphics.DrawLine(Pens.Orange, 0, 0, e.PageBounds.Width, e.PageBounds.Height);
            // From Top-Right to Bottom-Left
            e.Graphics.DrawLine(Pens.Orange, e.PageBounds.Width, 0, 0, e.PageBounds.Height);

            // 3) Drawing inner circles
            var diameterInner = 2 * RADIUS_INNER;
            var sizeInner = new Size(diameterInner, diameterInner);

            // Top-Left
            DrawFilledCircle(e, Brushes.Blue, new Point { X = e.MarginBounds.X, Y = e.MarginBounds.Y }, sizeInner);
            // Top-Right
            DrawFilledCircle(e, Brushes.Blue, new Point { X = e.MarginBounds.Right - diameterInner, Y = e.MarginBounds.Y }, sizeInner);
            // Bottom-Left
            DrawFilledCircle(e, Brushes.Blue, new Point { X = e.MarginBounds.X, Y = e.MarginBounds.Bottom - diameterInner }, sizeInner);
            // Bottom-Right
            DrawFilledCircle(e, Brushes.Blue, new Point { X = e.MarginBounds.Right - diameterInner, Y = e.MarginBounds.Bottom - diameterInner }, sizeInner);

            // Circle in the middle
            DrawFilledCircle(e, Brushes.Green, new Point { X = (e.PageBounds.Width / 2) - RADIUS_INNER, Y = (e.PageBounds.Height / 2) - RADIUS_INNER }, sizeInner);
        }

        private void DrawFilledCircle(PrintPageEventArgs e, Brush brush, Point point, Size size)
        {
            e.Graphics?.FillEllipse(brush, point.X, point.Y, size.Width, size.Height);
        }
    }
}
