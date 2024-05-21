using System.Data;
using System.Globalization;
using Task09.Models;

namespace Task09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var culture in CultureInfo.GetCultures(CultureTypes.AllCultures).OrderBy(k => k.Name))
            {
                ddlCulture.Items.Add(new Culture(culture.NativeName, culture));
            }
            ShowValues();
        }

        private void ShowValues()
        {
            // "c" as currency
            lblPrice.Text = (123.45m).ToString("c");
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblAmount.Text = (456.78).ToString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void CbKultura_SelectedIndexChanged(object sender, EventArgs e)
        {
            var culture = ddlCulture.SelectedItem as Culture;
            if (culture is null)
            {
                return;
            }

            Thread.CurrentThread.CurrentCulture = culture.Value;
            ShowValues();
        }
    }
}
