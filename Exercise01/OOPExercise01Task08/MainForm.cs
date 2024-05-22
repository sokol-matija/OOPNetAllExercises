using Utilities;

namespace OOPExercise01Task08
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnShowNewForm_Click(object sender, EventArgs e)
        {
            new CustomForm().Show();
        }
    }
}
