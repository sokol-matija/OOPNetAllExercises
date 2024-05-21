namespace OOPExercise01Task02
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

        private void OpenNewForm250Size_Click(object sender, EventArgs e)
        {
            Form250 form250 = new Form250();
            //var form250 = new Form250();
            //Form250 form250 = new();
            form250.Show();
        }

        private void OpenNewForm300Size_Click(object sender, EventArgs e)
        {
            Form300Red form300Red = new();
            form300Red.Show();
        }

        private void OpenNewFormNoControls_Click(object sender, EventArgs e)
        {

        }
   
    }
}
