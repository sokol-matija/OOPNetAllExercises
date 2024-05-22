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
    public partial class ViewForm : Form
    {
        short btnIndex = 0;
        public ViewForm()
        {
            InitializeComponent();
        }

        public void ChangeColor()
        {
            this.BackColor = Utilities.Utility.GetRandomColor();
        }

        public void ChangeWindowState()
        {
            this.WindowState = (FormWindowState)(new Random()).Next(0, 3);
        }

        public void AddButton()
        {
            Button btn = new Button();
            btn.Text = String.Format("Button {0}", ++btnIndex);
            flowLayoutPanel.Controls.Add(btn);
        }
    }
}
