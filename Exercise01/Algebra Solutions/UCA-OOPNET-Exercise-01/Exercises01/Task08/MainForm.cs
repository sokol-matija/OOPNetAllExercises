namespace Task08
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenForm_Click(object sender, EventArgs e)
        {
            new CustomForm().Show();
        }
    }
}