namespace Task05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddText_Click(object sender, EventArgs e)
        {
            TextInput textInput = new TextInput();

            if (textInput.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtText.AppendText(textInput.GetText());
                txtText.AppendText(Environment.NewLine);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtText.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}