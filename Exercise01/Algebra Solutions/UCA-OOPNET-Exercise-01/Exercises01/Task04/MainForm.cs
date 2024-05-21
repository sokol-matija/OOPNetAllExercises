namespace Task04
{
    public partial class MainForm : Form
    {
        private Random random = new Random();

        public MainForm()
        {
            InitializeComponent();
        }

        private void ChangeLocation_Click(object sender, EventArgs e)
        {
            this.Location = GetRandomLocation();
        }

        private Point GetRandomLocation()
        {
            Rectangle desktopResolutionWithoutTaskbar = Screen.GetWorkingArea(this);

            int maxX = desktopResolutionWithoutTaskbar.Width - this.Width;
            int maxY = desktopResolutionWithoutTaskbar.Height - this.Height;

            return new Point
            {
                X = random.Next(maxX),
                Y = random.Next(maxY)
            };
        }
    }
}