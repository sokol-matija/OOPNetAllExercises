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


namespace Zadatak04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPromiijeniPolozaj_Click(object sender, EventArgs e)
        {
            this.Location = Repozitorij.GetSlucajnaLokacija(this);
        }
    }
}
