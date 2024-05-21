namespace Task09
{
    public partial class MainForm : Form
    {
        private const string PATH = "data.txt";
        private const char SEPARATOR = ',';

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (!File.Exists(PATH))
            {
                return;
            }

            try
            {
                string line = File.ReadAllText(PATH);
                string[] details = line.Split(SEPARATOR);

                int x = int.Parse(details[0]);
                int y = int.Parse(details[1]);
                int width = int.Parse(details[2]);
                int height = int.Parse(details[3]);
                FormWindowState state = (FormWindowState)Enum.Parse(typeof(FormWindowState), details[4]);

                this.Location = new Point(x, y);
                this.Size = new Size(width, height);
                this.WindowState = state;

                FailSafe();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FailSafe()
        {
            Rectangle workingArea = Screen.GetWorkingArea(this);

            if (this.Width > workingArea.Width || this.Height > workingArea.Height)
            {
                this.Size = new Size(workingArea.Width, workingArea.Height);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {
            List<string> lines = new();
            string details = $"{this.Location.X}{SEPARATOR}{this.Location.Y}{SEPARATOR}{this.Width}{SEPARATOR}{this.Height}{SEPARATOR}{this.WindowState}";

            try
            {
                File.WriteAllText(PATH, details);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}