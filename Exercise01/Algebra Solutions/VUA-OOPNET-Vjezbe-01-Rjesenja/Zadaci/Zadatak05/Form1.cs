using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTaskBar_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = !this.ShowInTaskbar;

            if (this.ShowInTaskbar)
                btnTaskBar.Text = "Ne prikazuj u TaskBar-u";
            else
                btnTaskBar.Text = "Prikazuj u TaskBar-u";
        }

        private void btnOnTop_Click(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;

            if (this.TopMost)
                btnOnTop.Text = "Ne prikazuj iznad ostalih prozora";
            else
                btnOnTop.Text = "Prikazuj iznad ostalih prozora";
        }
    }
}
