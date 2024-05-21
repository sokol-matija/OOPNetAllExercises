using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak11
{
    public partial class Form1 : Form
    {
        private string datoteka = "FormData.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private int ProcitajSlijedeciZapis(StreamReader r)
        {
            return int.Parse(r.ReadLine());
        }

        private void LoadData()
        {
            try
            {
                if (!File.Exists(datoteka))
                    return;

                using (StreamReader reader = new StreamReader(datoteka))
                {
                    this.Location = new Point(ProcitajSlijedeciZapis(reader), ProcitajSlijedeciZapis(reader));
                    this.Size = new Size(ProcitajSlijedeciZapis(reader), ProcitajSlijedeciZapis(reader));
                    this.WindowState = (FormWindowState)ProcitajSlijedeciZapis(reader);

                    /* FailSafe
                     * Veličina forma mora biti manja od veličine ekrana
                     * */

                    Rectangle rezolucijaEkrana = Screen.GetBounds(this);

                    if (this.Size.Width > rezolucijaEkrana.Width || this.Size.Height > rezolucijaEkrana.Height)
                        this.Size = new Size(rezolucijaEkrana.Width, rezolucijaEkrana.Height);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR\n" + ex.Message);
            }
        }

        private void SaveData()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(datoteka))
                {
                    /* Lokacija, veličina, stanje */
                    writer.WriteLine(this.Location.X);
                    writer.WriteLine(this.Location.Y);
                    writer.WriteLine(this.Size.Width);
                    writer.WriteLine(this.Size.Height);                    
                    writer.WriteLine((int)this.WindowState);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR\n" + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }
    }
}
