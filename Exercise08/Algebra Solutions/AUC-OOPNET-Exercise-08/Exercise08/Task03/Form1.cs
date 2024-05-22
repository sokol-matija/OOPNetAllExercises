namespace Task03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIncreaseProgress_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
                if (control is CustomProgressBar progressBar)
                    progressBar.PerformStep();
        }
    }
}