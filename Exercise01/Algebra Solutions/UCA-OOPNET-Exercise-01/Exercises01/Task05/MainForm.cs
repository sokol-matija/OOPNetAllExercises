namespace Task05
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowTaskbar_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = !this.ShowInTaskbar;

            if (this.ShowInTaskbar)
            {
                btnShowTaskbar.Text = "Don't show in Taskbar";
            }
            else
            {
                btnShowTaskbar.Text = "Show in Taskbar";
            }
        }

        private void ShowTopMost_Click(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;

            if (this.TopMost)
            {
                btnShowTopMost.Text = "Don't show as Top Most Window";
            }
            else
            {
                btnShowTopMost.Text = "Show as Top Most Window";
            }
        }
    }
}