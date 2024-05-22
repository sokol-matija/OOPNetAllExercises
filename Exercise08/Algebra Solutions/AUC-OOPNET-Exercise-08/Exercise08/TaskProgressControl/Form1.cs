namespace TaskProgressControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnIncrement_Click(object sender, EventArgs e)
            => progressBar.ApplyStep(5);

        private void btnDecrement_Click(object sender, EventArgs e)
            => progressBar.ApplyStep(-5);

        private void btnPrint_Click(object sender, EventArgs e)
            => MessageBox.Show($"{progressBar.Percentage}%");

        private void btnAddProgressBar_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Add(new CustomProgressControl());
        }
    }
}