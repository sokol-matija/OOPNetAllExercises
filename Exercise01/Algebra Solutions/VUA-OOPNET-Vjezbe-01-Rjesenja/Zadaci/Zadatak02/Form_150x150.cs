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

namespace Zadatak02
{
    public partial class Form_150x150 : Form
    {
        public Form_150x150()
        {
            InitializeComponent();

            this.Size = new Size(150, 150);
            PrikaziGumbZatvori();
        }

        private void PrikaziGumbZatvori()
        {
            Button btnZatvori = new Button();
            btnZatvori.Size = new Size(100, 100);
            Repozitorij.CentrirajGumb(btnZatvori, this);
            btnZatvori.Text = "Zatvori";
            btnZatvori.Click += btnZatvori_Click;
            this.Controls.Add(btnZatvori);
        }

        void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
