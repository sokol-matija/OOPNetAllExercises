using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MojeKlase;

namespace Zadatak03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Repozitorij.CentrirajGumb(btn, this);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.Size = Repozitorij.GetRandomSize(200, 800, 200, 400);
            this.BackColor = Repozitorij.GetRandomColor();
            Repozitorij.CentrirajGumb(((Button)sender), this);
        }
    }
}
