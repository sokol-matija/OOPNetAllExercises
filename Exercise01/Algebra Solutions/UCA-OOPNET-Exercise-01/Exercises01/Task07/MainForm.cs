using Utilities;

namespace Task07
{
    public partial class MainForm : Form
    {
        private Size panelSize = new Size(100, 100);
        private Panel? addedPanel;

        private const int STEP = 10;
        private const char SEPARATOR = ',';
        private const string PATH = "data.txt";

        public MainForm()
        {
            InitializeComponent();
        }

        private void AddPanel_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel
            {
                Size = panelSize,
                Location = Utility.GetRandomLocationInParent(this.ClientSize, panelSize),
                BackColor = Utility.GetRandomColor()
            };

            this.Controls.Add(panel);
            addedPanel = panel;
        }

        private void Up_Click(object sender, EventArgs e)
        {
            MovePanel(0, -STEP);
        }

        private void Down_Click(object sender, EventArgs e)
        {
            MovePanel(0, STEP);
        }

        private void Left_Click(object sender, EventArgs e)
        {
            MovePanel(-STEP, 0);
        }

        private void Right_Click(object sender, EventArgs e)
        {
            MovePanel(STEP, 0);
        }

        private void MovePanel(int stepX, int stepY)
        {
            if (addedPanel is null)
            {
                return;
            }

            addedPanel.Location = new Point
            {
                X = addedPanel.Location.X + stepX,
                Y = addedPanel.Location.Y + stepY
            };
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {
            List<string> lines = new();

            foreach (Control control in this.Controls)
            {
                if (control is Panel panel)
                {
                    lines.Add($"{panel.Location.X}{SEPARATOR}{panel.Location.Y}{SEPARATOR}{panel.BackColor.R}{SEPARATOR}{panel.BackColor.G}{SEPARATOR}{panel.BackColor.B}");
                }
            }

            try
            {
                File.WriteAllLines(PATH, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                string[] lines = File.ReadAllLines(PATH);

                foreach (var line in lines)
                {
                    string[] details = line.Split(SEPARATOR);

                    int x = int.Parse(details[0]);
                    int y = int.Parse(details[1]);
                    int r = int.Parse(details[2]);
                    int g = int.Parse(details[3]);
                    int b = int.Parse(details[4]);

                    Panel panel = new Panel
                    {
                        Size = panelSize,
                        Location = new Point(x, y),
                        BackColor = Color.FromArgb(r, g, b)
                    };

                    this.Controls.Add(panel);
                    addedPanel = panel;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}