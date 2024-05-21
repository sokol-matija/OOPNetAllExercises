using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task03
{
    public partial class CustomProgressBar : UserControl
    {
        private Color backgroundColor;
        public Color BackgroundColor
        {
            get { return backgroundColor; }
            set { backgroundColor = value; }
        }

        private Color borderColor;
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; }
        }

        private Font percentageFont;
        public Font PercentageFont
        {
            get { return percentageFont; }
            set { percentageFont = value; }
        }

        private string outputFormat;
        public string OutputFormat
        {
            get { return outputFormat; }
            set { outputFormat = value; }
        }

        private double progress;

        public CustomProgressBar()
        {
            InitializeComponent();

            BackgroundColor = Color.LightBlue;
            BorderColor = Color.Gray;
            PercentageFont = new Font("Segoe UI", 12);
            OutputFormat = "{0}%";

            progress = 0.5;
        }

        public void PerformStep()
        {
            progress += 0.01;
            if (progress > 1)
            {
                progress = 0;
            }

            // Redraw the control
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            // Border
            pe.Graphics.DrawRectangle(new Pen(BorderColor), 0, 0, this.ClientRectangle.Width - 1, this.ClientRectangle.Height - 1);

            // Progress
            Rectangle progressRect = new Rectangle(1, 1, (int)(this.ClientSize.Width * progress) - 2, this.ClientSize.Height - 2);
            pe.Graphics.FillRectangle(new SolidBrush(backgroundColor), progressRect);

            // Percentage
            string postotak = OutputFormat.Replace("{0}", ((int)(progress * 100)).ToString());
            SizeF size = pe.Graphics.MeasureString(postotak, PercentageFont);

            int y = (int)(this.ClientSize.Height - size.Height) / 2;

            if (IsEnoughSpace(size, this.ClientSize, progressRect))
            {
                // Right side of the progress bar
                pe.Graphics.DrawString(postotak, PercentageFont, new SolidBrush(backgroundColor), progressRect.Width + 2, y);
            }
            else
            {
                // In the progress bar
                pe.Graphics.DrawString(postotak, PercentageFont, new SolidBrush(InvertColor(backgroundColor)), progressRect.Width - 2 - size.Width, y);
            }
        }

        public Color InvertColor(Color c)
        {
            const int RGBMAX = 255;
            return Color.FromArgb(RGBMAX - c.R, RGBMAX - c.G, RGBMAX - c.B);
        }


        // Is ProgressBar plus string larger than the rectangle container
        private bool IsEnoughSpace(SizeF stringSize, Size clientArea, Rectangle progressRect)
        {
            return progressRect.Width + 2 + stringSize.Width < clientArea.Width;
        }
    }
}
