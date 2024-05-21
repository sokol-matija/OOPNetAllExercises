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

namespace Zadatak06
{
    public partial class Form1 : Form
    {
        private int sirinaPanela = 200;
        private int visinaPanela = 200;
        private Panel zadnjiDodaniPanel;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodajPanel_Click(object sender, EventArgs e)
        {
            Panel pnl = new Panel();
            pnl.Size = new Size(sirinaPanela, visinaPanela);
            pnl.Location = Repozitorij.GetSlucajnaLokacijaUnutarForme(this, sirinaPanela, visinaPanela);
            pnl.BackColor = Repozitorij.GetRandomColor();
            pnlContainer.Controls.Add(pnl);
            pnl.BringToFront();
            zadnjiDodaniPanel = pnl;
        }

        private void btnDodajGumb_Click(object sender, EventArgs e)
        {
            if (zadnjiDodaniPanel == null)
                return;

            Button btn = new Button();
            btn.Text = "Makni me";
            btn.Location = Repozitorij.GetSlucajnaLokacijaUnutarPanele(zadnjiDodaniPanel, btn.Width, btn.Height);
            btn.Click += btn_Click;
            zadnjiDodaniPanel.Controls.Add(btn);
            btn.BringToFront();
        }

        void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;            
            btn.Parent.Controls.Remove(btn);
        }

        private void btnUkloniSvePanele_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
        }

        private void btnUkloniSveGumbe_Click(object sender, EventArgs e)
        {
            zadnjiDodaniPanel.Controls.Clear();
        }


    }
}
