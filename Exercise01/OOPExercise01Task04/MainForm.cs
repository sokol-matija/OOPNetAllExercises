
namespace OOPExecise01Task04
{
    public partial class MainForm : Form
    {
        private Random random = new Random();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnChangeLocation_Click(object sender, EventArgs e)
        {
            Location = GetRandomLocation();
        }

        private Point GetRandomLocation()
        {
            Rectangle rectangle = Screen.GetWorkingArea(this);

            int maxX = rectangle.Width - Width;
            int maxY = rectangle.Height - Height;

            return new Point(random.Next(maxX), random.Next(maxY));
        }
    }
}
    