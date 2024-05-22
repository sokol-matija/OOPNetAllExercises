using System.Globalization;

namespace Task10
{
    public partial class Form1 : Form
    {
        private const string HR = "hr", EN = "en", DE = "de";
        private string culture;

        public Form1()
        {
            InitializeComponent();
            culture = HR;
        }

        private void MiHR_Click(object sender, EventArgs e)
        {
            culture = HR;
        }

        private void MiEN_Click(object sender, EventArgs e)
        {
            culture = EN;
        }

        private void MiDE_Click(object sender, EventArgs e)
        {
            culture = DE;
        }

        private void BtnZapocniOdbrojavanje_Click(object sender, EventArgs e)
        {
            new Counting(new CultureInfo(culture)).Show();
        }
    }
}
