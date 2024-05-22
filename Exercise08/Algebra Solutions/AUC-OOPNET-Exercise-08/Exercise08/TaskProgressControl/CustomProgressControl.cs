using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TaskProgressControl
{
    public partial class CustomProgressControl : UserControl
    {
        public int Percentage
        {
            get
            {
                return progressBar.Value;
            }
            private set
            {
                if (value < 0 || value > 100)
                {
                    return;
                }
                progressBar.Value = value;
                lbProgress.Text = $"{value}%";
            }
        }

        public CustomProgressControl()
        {
            InitializeComponent();
        }

        private void CustomProgressControl_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    ApplyStep(5);
                    break;
                case MouseButtons.Right:
                    ApplyStep(-5);
                    break;
            }
        }

        public void ApplyStep(int step)
            => Percentage += step;
        
    }
}
