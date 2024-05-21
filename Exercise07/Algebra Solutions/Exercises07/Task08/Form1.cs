using System.Globalization;

namespace Task08
{
    public partial class Form1 : Form
    {
        private const string HR = "hr";
        private const string EN = "en";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetCulture(HR);
            ShowDateTime();
        }

        private void SetCulture(string jezik)
        {
            var culture = new CultureInfo(jezik);

            Thread.CurrentThread.CurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;

            // Update the UI manually to change the button's text
            this.Controls.Clear();
            InitializeComponent();
        }

        private void ShowDateTime()
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void BtnPromijeniKulturu_Click(object sender, EventArgs e)
        {
            if (Thread.CurrentThread.CurrentCulture.Name == HR)
            {
                SetCulture(EN);
            }
            else
            {
                SetCulture(HR);
            }

            ShowDateTime();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ShowDateTime();
        }
    }
}
