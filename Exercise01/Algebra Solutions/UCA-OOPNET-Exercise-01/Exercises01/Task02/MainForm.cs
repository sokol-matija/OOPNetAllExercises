namespace Task02
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenFirstForm_Click(object sender, EventArgs e)
        {
            ShowForm(new FirstForm());
        }

        private void OpenSecondForm_Click(object sender, EventArgs e)
        {
            ShowForm(new SecondForm());
        }

        private void OpenThirdForm_Click(object sender, EventArgs e)
        {
            ShowForm(new ThirdForm());
        }

        private void ShowForm(Form form)
        {
            form.Show();
        }

        private void CloseApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}