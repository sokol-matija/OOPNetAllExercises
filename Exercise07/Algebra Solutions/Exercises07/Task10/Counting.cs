using System.Globalization;

namespace Task10
{
    public partial class Counting : Form
    {
        private int number;

        public Counting(CultureInfo culture)
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentUICulture = culture;

            number = 5;
            ShowNumber();
        }

        private void ShowNumber()
        {
            switch (number)
            {
                case 5:
                    lblNumber.Text = Resource.five;
                    break;
                case 4:
                    lblNumber.Text = Resource.four;
                    break;
                case 3:
                    lblNumber.Text = Resource.three;
                    break;
                case 2:
                    lblNumber.Text = Resource.two;
                    break;
                case 1:
                    lblNumber.Text = Resource.one;
                    break;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (--number <= 0)
            {
                this.Close();
            }

            ShowNumber();
        }
    }
}
