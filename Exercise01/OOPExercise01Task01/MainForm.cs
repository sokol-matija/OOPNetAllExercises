namespace OOPExercise01Task01
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowMsg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hellow 2IP2");
        }
    }
}
