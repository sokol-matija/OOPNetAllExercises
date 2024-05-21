using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task01
{
    public partial class DigitalClock : UserControl
    {
        #region Properties

        private Color background = Color.Black;
        [Category("DigitalClock")]
        public Color Background
        {
            get { return background; }
            set {
                background = value;
                lbTime.BackColor = value;
            }
        }

        private Color foreColor = Color.White;
        [Category("DigitalClock")]
        public Color ForeColor
        {
            get { return foreColor; }
            set
            {
                foreColor = value;
                lbTime.ForeColor = value;
            }
        }

        [Category("DigitalClock")]
        public bool ShowHundreths { get; set; }

        #endregion

        private System.Windows.Forms.Timer timer;


        public DigitalClock()
        {
            InitializeComponent();
            IntiailizeTimeLabel();
            InitializeTimer();
        }


        private void IntiailizeTimeLabel()
        {
            lbTime.BackColor = Color.Black;
            lbTime.ForeColor = Color.White;
            ShowHundreths = true;
        }
        private void InitializeTimer()
        {
            timer = new();
            timer.Interval = 100;
            timer.Tick += RefreshTime;
            timer.Start();   
        }

        public void RefreshTime(object? sender, EventArgs e)
        {
            var hours = DateTime.Now.Hour;
            var minutes = DateTime.Now.Minute;
            var seconds = DateTime.Now.Second;

            var hh = hours < 10 ? $"0{hours}" : hours.ToString();
            var mm = minutes < 10 ? $"0{minutes}" : minutes.ToString();
            var ss = seconds < 10 ? $"0{seconds}" : seconds.ToString();
            var hs = DateTime.Now.Millisecond / 10;

            

            lbTime.Text = $"{hh}:{mm}:{ss}";
            if (ShowHundreths)
            {
                lbTime.Text += $".{hs}";
            }
        }
    }
}
