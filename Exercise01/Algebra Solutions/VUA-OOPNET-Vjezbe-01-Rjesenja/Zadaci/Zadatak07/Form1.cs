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
using System.IO;

namespace Zadatak07
{
    public partial class Form1 : Form
    {
        private int sirinaPanela = 100;
        private int visinaPanela = 100;
        private Panel zadnjiDodaniPanel;
        private int korak = 10;
        private string datoteka = "podaci.txt";

        public Form1()
        {
            InitializeComponent();
        }
        private void btnKreirajPanelu_Click(object sender, EventArgs e)
        {
            Panel pnl = new Panel();
            pnl.Size = new Size(sirinaPanela, visinaPanela);
            pnl.Location = Repozitorij.GetSlucajnaLokacijaUnutarForme(this, sirinaPanela, visinaPanela);
            pnl.BackColor = Repozitorij.GetRandomColor();
            this.Controls.Add(pnl);

            zadnjiDodaniPanel = pnl;
        }
        private void PomakniPanelu(int pomakX, int pomakY)
        {
            if(zadnjiDodaniPanel == null)
                return;

            zadnjiDodaniPanel.Location = new Point(
                zadnjiDodaniPanel.Location.X + pomakX, 
                zadnjiDodaniPanel.Location.Y + pomakY);
        }

        private void PrikaziPanelu(int x, int y, int r, int g, int b)
        {
            Panel pnl = new Panel();
            pnl.Size = new Size(sirinaPanela, visinaPanela);
            pnl.Location = new Point(x, y);
            pnl.BackColor = Color.FromArgb(r, g, b);
            zadnjiDodaniPanel = pnl;
            this.Controls.Add(pnl);
        }

        private void UcitajPodatke()
        {
            try
            {
                if (!File.Exists(datoteka))
                    return;

                using (StreamReader reader = new StreamReader(datoteka))
                {
                    string[] podaciPanele;

                    while (!reader.EndOfStream)
                    {
                        podaciPanele = reader.ReadLine().Split(',');

                        int x = int.Parse(podaciPanele[0]);
                        int y = int.Parse(podaciPanele[1]);
                        int r = int.Parse(podaciPanele[2]);
                        int g = int.Parse(podaciPanele[3]);
                        int b = int.Parse(podaciPanele[4]);

                        PrikaziPanelu(x, y, r, g, b);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR\n" + ex.Message);
            }
        }

        private void SpremiPodatke()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(datoteka))
                {
                    foreach (Control ctrl in this.Controls)
                    {
                        if(ctrl is Panel)
                        {
                            /* Svakoj paneli spremam lokaciju i boju */
                            Panel p = (Panel)ctrl;

                            writer.Write(p.Location.X);
                            writer.Write(",");
                            writer.Write(p.Location.Y);
                            writer.Write(",");
                            writer.Write(p.BackColor.R);
                            writer.Write(",");
                            writer.Write(p.BackColor.G);
                            writer.Write(",");
                            writer.Write(p.BackColor.B);
                            writer.Write(Environment.NewLine);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message);
            }
        }

        private void btnGore_Click(object sender, EventArgs e)
        {
            PomakniPanelu(0, -korak);
        }
        private void btnDole_Click(object sender, EventArgs e)
        {
            PomakniPanelu(0, korak);
        }
        private void btnLijevo_Click(object sender, EventArgs e)
        {
            PomakniPanelu(-korak, 0);
        }
        private void btnDesno_Click(object sender, EventArgs e)
        {
            PomakniPanelu(korak, 0);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SpremiPodatke();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }
    }
}
