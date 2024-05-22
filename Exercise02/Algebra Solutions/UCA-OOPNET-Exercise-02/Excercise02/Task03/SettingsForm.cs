namespace Task03
{
    public partial class SettingsForm : Form
    {
        private ViewForm form = new ViewForm();
        public SettingsForm()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            form.Show();
            int x = Width + Location.X + 10;
            form.Location = new Point(x, this.Location.Y);
        }

        private void btnChangeBackColor_Click(object sender, EventArgs e)
        {
            form.ChangeColor();
        }

        private void btnChangeWindowState_Click(object sender, EventArgs e)
        {
            form.ChangeWindowState();
        }

        private void btnAddButton_Click(object sender, EventArgs e)
        {
            form.AddButton();
        }

      
    }
}