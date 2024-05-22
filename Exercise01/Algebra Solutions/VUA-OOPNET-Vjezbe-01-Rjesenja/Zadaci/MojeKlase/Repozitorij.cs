using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Dodano i referencirano... */
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace MojeKlase
{
    public class Repozitorij
    {
        private static Random rnd;
        static Repozitorij()
        {
            rnd = new Random();
        }

        public static void CentrirajGumb(Button btnZatvori, Form forma)
        {
            int sirinaForme = forma.ClientSize.Width;
            int visinaForme = forma.ClientSize.Height;

            int sirinaGumba = btnZatvori.Width;
            int visinaGumba = btnZatvori.Height;

            int x = (sirinaForme - sirinaGumba) / 2;
            int y = (visinaForme - visinaGumba) / 2;

            btnZatvori.Location = new Point(x, y);
        }
        public static Color GetRandomColor()
        {
            return Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
        }


        public static Point GetSlucajnaLokacija(Form forma)
        {
            Rectangle desktopRezolucija = Screen.GetBounds(forma);

            int maxX = desktopRezolucija.Width - forma.Width;
            int maxY = desktopRezolucija.Height - forma.Size.Width;

            return new Point(rnd.Next(0, maxX), rnd.Next(0, maxY));
        }
        public static Point GetSlucajnaLokacijaUnutarForme(Form forma, int sirinaKontrole, int visinaKontrole)
        {
            int maxX = forma.Width - sirinaKontrole;
            int maxY = forma.Height - visinaKontrole;

            return new Point(rnd.Next(0, maxX), rnd.Next(0, maxY));
        }

        public static Point GetSlucajnaLokacijaUnutarPanele(Panel panel, int sirinaKontrole, int visinaKontrole)
        {
            int maxX = panel.Width - sirinaKontrole;
            int maxY = panel.Height - visinaKontrole;

            return new Point(rnd.Next(0, maxX), rnd.Next(0, maxY));
        }

        public static Size GetRandomSize(int minW, int maxW, int minH, int maxH)
        {
            return new Size(rnd.Next(minW, maxW), rnd.Next(minH, maxH));
        }



        public static List<Osoba> GetOsobaListFromFile(string filePath)
        {
            List<Osoba> kolekcijaOsoba = new List<Osoba>();
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                   kolekcijaOsoba.Add(GetOsobaFromString(reader.ReadLine()));
                }
            }
            return kolekcijaOsoba;
        }

        public static void WriteOsobaToFile(Osoba o, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(String.Format("{0},{1},{2}", o.Ime, o.Prezime, o.Email));
            }
        }

        public static Osoba GetOsobaFromString(string o)
        {
            string[] poljeOsoba = o.Split(',');
            return new Osoba
            {
                Ime = poljeOsoba[0],
                Prezime = poljeOsoba[1],
                Email = poljeOsoba[2]
            };
        }

        public static Panel GetPanelOsoba(Osoba o)
        {
            Panel pnl = new Panel();
            pnl.Size = new Size(200, 100);
            pnl.BorderStyle = BorderStyle.FixedSingle;

            int x = 20;
            int y = 20;

            Point imeLokacija = new Point(x, y);
            Point prezimeLokacija = new Point(x, imeLokacija.Y + y);
            Point emailLokacija = new Point(x, prezimeLokacija.Y + y);

            pnl.Controls.Add(GetLabel(o.Ime, true, imeLokacija, "lblIme"));
            pnl.Controls.Add(GetLabel(o.Prezime, true, prezimeLokacija, "lblPrezime"));
            pnl.Controls.Add(GetLabel(o.Email, false, emailLokacija, "lblEmail"));
            return pnl;
        }


        public static Label GetLabel(string txt, bool bold, Point lokacija, string lblName)
        {
            Label lbl = new Label();
            lbl.Name = lblName;
            lbl.Text = txt;
            lbl.Location = lokacija;
            lbl.Width = 300;
            lbl.Height = 20;
            if (bold) lbl.Font = new System.Drawing.Font(lbl.Font, FontStyle.Bold);

            return lbl;
        }

    }
}
