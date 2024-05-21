using System.ComponentModel;

namespace Task01
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

        private void Calculate_Click(object sender, EventArgs e)
        {
            long n = long.Parse(txtNumber.Text);

            txtNumber.Enabled = false;
            btnCancel.Enabled = true;
            btnCalculate.Enabled = false;
            lblStatus.Text = "Calculating...";

            backgroundWorker.RunWorkerAsync(n);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            backgroundWorker.CancelAsync();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ShowTime();
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (e.Argument is null)
            {
                return;
            }

            long n = (long)e.Argument;

            long sum = 0;
            int previousPercentage = 0;

            for (long i = 1; i <= n; i++)
            {
                if (backgroundWorker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                int percentage = (int)((double)i / n * 100);
                if (percentage != previousPercentage)
                {
                    backgroundWorker.ReportProgress(percentage);
                }
                previousPercentage = percentage;

                sum += i;
            }

            e.Result = sum;
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            progressBarLbl.Text = $"{progressBar.Value}%";
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            txtNumber.Enabled = true;
            btnCancel.Enabled = false;
            btnCalculate.Enabled = true;

            if (e.Cancelled)
            {
                lblStatus.Text = "Calculating canceled!";
                return;
            }

            if (e.Result is not null)
            {
                // Separating thousands in ToString method
                lblStatus.Text = ((long)e.Result).ToString("#,###");
            }
        }
    }
}
