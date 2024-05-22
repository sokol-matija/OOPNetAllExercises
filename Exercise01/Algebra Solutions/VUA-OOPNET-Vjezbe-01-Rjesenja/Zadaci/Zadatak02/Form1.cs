using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn150x150_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new Form_150x150());
        }

        void PrikaziFormu(Form forma)
        {
            forma.Show();
        }

        private void btn100x100_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new Form_100x100());
        }

        private void btn200x200_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new Form_300x300());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
