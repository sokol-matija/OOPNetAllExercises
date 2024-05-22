namespace OOPExercise02Task03
{
    public partial class Form1 : Form
    {
        private Test test = new Test();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            test.Show();
        }

        private void btnChangeBackColor_Click(object sender, EventArgs e)
        {
            test.ChangeBackColor();
        }

        private void btnChangeWinState_Click(object sender, EventArgs e)
        {
            test.ChangeWinState();
        }

        private void btnAddButton_Click(object sender, EventArgs e)
        {
            test.AddButton();
        }

    
    }
}
