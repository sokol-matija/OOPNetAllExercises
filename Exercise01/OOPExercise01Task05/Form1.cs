namespace OOPExercise01Task05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowInTaskbar_Click(object sender, EventArgs e)
        {
            ShowInTaskbar = !ShowInTaskbar;

            if (ShowInTaskbar)
            {
                btnShowInTaskbar.Text = "Hide from taskbar";
            }
            else
            {
                btnShowInTaskbar.Text = "Show in taskbar";
            }

            
        }

        private void Topmost_Click(object sender, EventArgs e)
        {
            TopMost = !TopMost;

            if (TopMost)
            {
                btnTopmost.Text = "Disable topmost";
            }
            else
            {
                btnTopmost.Text = "Enable topmost";
            }
        }
    }
}
