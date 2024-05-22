using System.Drawing.Drawing2D;

namespace Task07
{
    public partial class Form1 : Form
    {
        private Random r = new Random();
        private int scorredPoints = 0;
        private int remainingSeconds = 30;
        public Form1()
        {
            InitializeComponent();
            ShowPanels();
            gameTimer.Start();
        }

        private void AddPanelToGamePanel(Size size, Color color, int points)
        {
            Panel pnl = new Panel();
            pnl.Size = size;
            pnl.BackColor = color;

            // Transform panel in circle
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, size.Width, size.Height);
            pnl.Region = new Region(path);

            do
            {
                pnl.Location = GetRandomLocation(pnl);
            } while (ControlIntersectsWithAnotherControl(pnl));

            pnl.Tag = points;
            pnl.Click += Pnl_Click;
            gamePanel.Controls.Add(pnl);
        }

        private bool ControlIntersectsWithAnotherControl(Panel pnl)
        {
            foreach (Control ctrl in gamePanel.Controls)
            {
                if (ctrl.Bounds.IntersectsWith(pnl.Bounds))
                    return true;
            }
            return false;
        }

        private void Pnl_Click(object sender, EventArgs e)
        {
            if (sender is Panel pnl)
            {
                scorredPoints += (int)pnl.Tag;
                lblPoints.Text = scorredPoints.ToString();
            }
        }

        private Point GetRandomLocation(Panel pnl)
        {
            int maxX = gamePanel.Width - pnl.Width;
            int maxY = gamePanel.Height - pnl.Height;
            return new Point(r.Next(maxX), r.Next(maxY));
        }

        private void ShowPanels()
        {
            gamePanel.Controls.Clear();
            AddPanelToGamePanel(new Size(30, 30), Color.Red, 30);
            AddPanelToGamePanel(new Size(40, 40), Color.Red, 40);
            AddPanelToGamePanel(new Size(50, 50), Color.Red, 50);
            AddPanelToGamePanel(new Size(60, 60), Color.Red, 60);
            AddPanelToGamePanel(new Size(70, 70), Color.Red, 70);
            // Bomb!!!
            AddPanelToGamePanel(new Size(150, 150), Color.Black, -500);
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            remainingSeconds--;
            lblSeconds.Text = remainingSeconds.ToString();
            if (remainingSeconds > 0)
                ShowPanels();
            else
            {
                gameTimer.Stop();
                MessageBox.Show($"You scorred: {scorredPoints}", "GAME OVER");
                Application.Exit();
            }
        }
    }
}