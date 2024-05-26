namespace OOPExercise09Task02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowTime();
        }

        private void ShowTime()
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ShowTime();
        }

        private async void btnCalculate_Click(object sender, EventArgs e)
        {
            long n = long.Parse(tbNumber.Text);
            lblResult.Text = "Calculating...";
            btnCalculate.Enabled = false;

            long result = await CalculateAsync(n);
            lblResult.Text = result.ToString();
            btnCalculate.Enabled = true;
        }

        private Task<long> CalculateAsync(long n)
        {
            return Task.Run(() =>
            {
                return Calculate(n);
            });
        }

        private long Calculate(long n)
        {
            long sum = 0;
            for (long i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
