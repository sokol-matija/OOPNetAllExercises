using Utilities;

namespace OOPExecise01Task07
{
    public partial class Form1 : Form
    {
        private const string PATH = "data.txt";
        private const char SEPARATOR = ',';

        private const int STEP = 10;

        private Size panelSize = new Size(100, 100);
        private Panel? addedPanel;

        public Form1()
        {
            InitializeComponent();
        }

        private void CreatePanel_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel()
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

        private void MovePanel(int x, int y)
        {
            if (addedPanel is null)
            {
                MessageBox.Show("Please create a panel first");
                return;
            }

            //addedPanel.Location = new Point(addedPanel.Location.X + x, addedPanel.Location.Y + y);r

            // or 
            addedPanel.Location = new Point
            {
                X = addedPanel.Location.X + x,
                Y = addedPanel.Location.Y + y
            };
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {
            List<string> fileLines = new();
            foreach (Panel panel in this.Controls.OfType<Panel>())
            {
                fileLines.Add($"{panel.Location.X}{SEPARATOR}{panel.Location.Y}{SEPARATOR}{panel.BackColor.ToArgb()}");
            }
            try
            {
                File.WriteAllLines(PATH, fileLines);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
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
                foreach (string line in lines)
                {
                    string[] parts = line.Split(SEPARATOR);
                    if (parts.Length != 3)
                    {
                        continue;
                    }

                    Panel panel = new Panel()
                    {
                        Size = panelSize,
                        Location = new Point(int.Parse(parts[0]), int.Parse(parts[1])),
                        BackColor = Color.FromArgb(int.Parse(parts[2]))
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
