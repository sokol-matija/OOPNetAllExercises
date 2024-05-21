namespace Task03
{
    public partial class MainForm : Form
    {
        private Random random = new Random();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CenterButton();
        }

        private void CenterButton()
        {
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            int buttonWidth = btnChangeValues.Width;
            int buttonHeight = btnChangeValues.Height;

            int x = (formWidth - buttonWidth) / 2;
            int y = (formHeight - buttonHeight) / 2;

            btnChangeValues.Location = new Point(x, y);
        }

        private void ChangeValues_Click(object sender, EventArgs e)
        {
            this.Size = GetRandomSize();
            this.BackColor = GetRandomColor();
            CenterButton();
        }

        private Size GetRandomSize()
        {
            int minWidth = 200;
            int maxWidth = 800;
            int minHeight = 200;
            int maxHeight = 600;

            return new Size
            {
                Width = random.Next(minWidth, maxWidth),
                Height = random.Next(minHeight, maxHeight)
            };
        }

        private Color GetRandomColor()
        {
            return Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }
    }
}