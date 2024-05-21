using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void OnPictureSelectEventhandler(object sender, EventArgs e)
        {
            ToolStripItem item = sender as ToolStripItem;
            pictureContainer.Image = item.Image;
            lblInfo.Text = $"Selected picture:{item.Text.ToUpper()}";
        }
    }
}
