
namespace OOPExercise01Task03
{
    public partial class MainForm : Form
    {
        private Random random = new Random();

        public MainForm()
        {
            InitializeComponent();
        }

        private void ChangeCollorAndSize_Click(object sender, EventArgs e)
        {
            Size = GetRandomSize();
            BackColor = GetRandomColor();
            CenterButton();
        }


        private Size GetRandomSize()
        {
            return new Size(random.Next(200, 800), random.Next(200, 600));
        }

        private Color GetRandomColor()
        {
            return Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }

        private void CenterButton()
        {
            btnChangeCollorAndSize.Location = new Point(
                (ClientSize.Width - btnChangeCollorAndSize.Width) / 2,
                (ClientSize.Height - btnChangeCollorAndSize.Height) / 2);
        }

    }
}
