namespace Task02
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowTime();
        }

        private void ShowTime()
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private async void Calculate_Click(object sender, EventArgs e)
        {
            long n = long.Parse(txtNumber.Text);

            btnCalculate.Enabled = false;
            lblResult.Text = "Calculating...";
            long result = await CalculateAsync(n);
            btnCalculate.Enabled = true;

            lblResult.Text = result.ToString("#,###");
        }

        private Task<long> CalculateAsync(long n)
        {
            return Task.Run(() =>
            {
                long sum = 0;

                for (long i = 1; i <= n; i++)
                {
                    sum += i;
                }

                return sum;
            });
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ShowTime();
        }
    }
}
