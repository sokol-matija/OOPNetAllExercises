using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task02
{
    public partial class AnalogClock : UserControl
    {
        private System.Windows.Forms.Timer timer;
        public bool ShowSeconds { get; set; }
        private Pen hourPen;
        private Pen handsPen;

        private Color clockColor;
        public Color ClockColor
        {
            get { return clockColor; }
            set
            {
                clockColor = value;
                hourPen = new Pen(clockColor, 2f);
            }
        }
        private Color handsColor;
        public Color HandsColor
        {
            get { return handsColor; }
            set
            {
                handsColor = value;
                handsPen = new Pen(handsColor, 4f);
            }
        }

        public AnalogClock()
        {
            InitializeComponent();

            ShowSeconds = true;
            ClockColor = Color.DodgerBlue;
            HandsColor = Color.OrangeRed;

            timer = new();
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Redraw the control
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            Point center = new Point(this.ClientSize.Width / 2, this.ClientSize.Height / 2);

            // Clock
            pe.Graphics.DrawEllipse(hourPen, 0, 0, this.ClientSize.Width - 1, this.ClientSize.Height - 1);

            DateTime currentTime = DateTime.Now;

            // Clock hand length calculation
            int handLength = this.ClientSize.Width / 2 - 40;

            int x1 = center.X;
            int y1 = center.Y;

            // Hours
            double hourAngle = (currentTime.Hour / 12.0) * (2 * Math.PI);

            int x2Hours = center.X + (int)(handLength * Math.Sin(hourAngle));
            int y2Hours= center.Y - (int)(handLength * Math.Cos(hourAngle));

            pe.Graphics.DrawLine(handsPen, x1, y1, x2Hours, y2Hours);

            // Minutes
            handLength = handLength + 30;
            double minuteAngle = (currentTime.Minute / 60.0) * (2 * Math.PI);

            int x2min = center.X + (int)(handLength * Math.Sin(minuteAngle));
            int y2min = center.Y - (int)(handLength * Math.Cos(minuteAngle));

            pe.Graphics.DrawLine(handsPen, x1, y1, x2min, y2min);

            if (ShowSeconds)
            {
                // Seconds
                handLength = handLength + 10;

                double secondAngle = (currentTime.Second / 60.0) * (2 * Math.PI);

                int x2sec = center.X + (int)(handLength * Math.Sin(secondAngle));
                int y2sec = center.Y - (int)(handLength * Math.Cos(secondAngle));

                pe.Graphics.DrawLine(handsPen, x1, y1, x2sec, y2sec);
            }

            // Clock - Center
            pe.Graphics.FillEllipse(new SolidBrush(clockColor), center.X - 10, center.Y - 10, 20, 20);
        }
    }
}
