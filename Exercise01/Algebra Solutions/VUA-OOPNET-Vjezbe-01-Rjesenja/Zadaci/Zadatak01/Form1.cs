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
    public partial class FormZadatak01 : Form
    {
        public FormZadatak01()
        {
            InitializeComponent();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pozdrav!");
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
