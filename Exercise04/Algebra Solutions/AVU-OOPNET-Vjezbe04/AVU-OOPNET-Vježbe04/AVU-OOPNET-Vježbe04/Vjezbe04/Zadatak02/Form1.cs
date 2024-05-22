using oopnetLib;
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
        private Panel zadnjaOdabranaPanela = null;

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ContextMenuStrip = cmsFrm;
        }

        private void dodajPaneluEventhandler(object sender, EventArgs e)
        {
            ToolStripItem item = sender as ToolStripItem;
            var brojPanela = int.Parse(item.Tag.ToString());

            switch (brojPanela)
            {
                case 1:
                    DodajPanele(1);
                    break;
                case 5:
                    DodajPanele(5);
                    break;
                case 10:
                    DodajPanele(10);
                    break;
            }
        }

        private void DodajPanele(int brojPanela)
        {
            for (int i = 0; i < brojPanela; i++)
            {
                this.Controls.Add(GetPanel());
            }
        }

        private Control GetPanel()
        {
            Panel pnl = new Panel();
            pnl.Size = new Size(50, 50);
            pnl.BackColor = Repo.GetRandomColor();
            pnl.Location = Repo.GetRandomLocation(this, pnl);
            pnl.ContextMenuStrip = cmsPanel;
            pnl.Click += Pnl_Click;
            return pnl;
        }

        private void Pnl_Click(object sender, EventArgs e)
        {
            if(zadnjaOdabranaPanela != null)
                zadnjaOdabranaPanela.BorderStyle = BorderStyle.None;

            Panel pnl = sender as Panel;
            pnl.BorderStyle = BorderStyle.FixedSingle;
            pnl.BringToFront();
            zadnjaOdabranaPanela = pnl;
        }

        private void ukloniMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(zadnjaOdabranaPanela);
            zadnjaOdabranaPanela = null;
        }

        private void cmsPanel_Opened(object sender, EventArgs e)
        {
            if (zadnjaOdabranaPanela != null)
                zadnjaOdabranaPanela.BorderStyle = BorderStyle.None;

            Panel pnl = cmsPanel.SourceControl as Panel;
            pnl.BorderStyle = BorderStyle.FixedSingle;
            pnl.BringToFront();
            zadnjaOdabranaPanela = pnl;
        }

        private void ukloniSvePaneleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
        }
    }
}
