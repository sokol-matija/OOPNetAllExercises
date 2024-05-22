namespace Task01
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, World!");
        }

        private void CloseApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}