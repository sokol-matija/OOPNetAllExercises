using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPExercise08Task01
{
	public partial class DigitalClockUC : UserControl
	{
		public DigitalClockUC()
		{
			InitializeComponent();
		}

        public bool ShowMiliSeconds { get; set; }

        private void timer_Tick(object sender, EventArgs e)
		{
			if (ShowMiliSeconds)
				label1.Text = DateTime.Now.ToString("HH:mm:ss.ff");
			else
				label1.Text = DateTime.Now.ToString("HH:mm:ss");
		}
	}
}
