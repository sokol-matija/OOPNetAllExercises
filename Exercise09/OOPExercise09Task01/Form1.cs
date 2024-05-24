namespace OOPExercise09Task01
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
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ShowTime();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtNumber.Text);

            btnCalculate.Enabled = false;
            btnCancel.Enabled = true;
            lblStatus.Text = "Calculating...";

            backgroundWorker.RunWorkerAsync(n);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            backgroundWorker.CancelAsync();
        }

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (e.Argument is null) return;
            long n = (int)e.Argument;
            long sum = 0;
            int perviousPercent = 0;
            for (int i = 0; i < n; i++)
            {
                if (backgroundWorker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                int percent = (int)(((double)i + 1) * 100 / n);
                if(percent != perviousPercent)
                {
                    backgroundWorker.ReportProgress(percent);
                    perviousPercent = percent;
                }

                sum += i;
            }
            e.Result = sum;
        }

        private void backgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            lblPercentage.Text = e.ProgressPercentage + "%";
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if(e.Cancelled)
            {
                lblStatus.Text = "Cancelled";
            }
            else if(e.Result is not null)
            {
                lblStatus.Text = e.Result.ToString();
            }
            btnCalculate.Enabled = true;
            btnCancel.Enabled = false;
        }
    }
}
