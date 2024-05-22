

using System.Drawing.Drawing2D;
using Utilities;

namespace OOPExercise02Task07
{
    public partial class Form1 : Form
    {
        private int scorredPoints = 0;
        private int remainingTime = 10;

        public Form1()
        {
            InitializeComponent();
            ShowPanels();
            gameTimer.Start();
        }

        private void ShowPanels()
        {
            gamePanel.Controls.Clear();
            AddPanelToGamePanel(new Size(30, 30), Color.Black, 30);
            AddPanelToGamePanel(new Size(40, 40), Color.Black, 40);
            AddPanelToGamePanel(new Size(50, 50), Color.Black, 50);
            AddPanelToGamePanel(new Size(60, 60), Color.Black, 60);
            AddPanelToGamePanel(new Size(70, 70), Color.Black, 70);

            AddPanelToGamePanel(new Size(150, 150), Color.Red, -500);
        }

        private void AddPanelToGamePanel(Size size, Color red, int points)
        {
            Panel panel = new Panel();
            panel.Size = size;
            panel.BackColor = red;

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, size.Width, size.Height);
            panel.Region = new Region(path);

            do
            {
                panel.Location = Utility.GetRandomLocationInParent(gamePanel.Size, panel.Size);
            } while (ControlIntersectsWithAnotherControl(panel));

            panel.Tag = points;
            panel.Click += Panel_Click;
            gamePanel.Controls.Add(panel);
        }


        private void Panel_Click(object? sender, EventArgs e)
        {
            if (sender is Panel panel)
            {
                scorredPoints += (int)panel.Tag;
                lblPoints.Text = scorredPoints.ToString();
                // remove clicked panel
                gamePanel.Controls.Remove(panel);
                if (gamePanel.Controls.Count == 1 && gamePanel.Controls[0].BackColor == Color.Red || gamePanel.Controls.Count == 0)
                {
                    ShowPanels();
                }
            }

        }

        private bool ControlIntersectsWithAnotherControl(Panel panel)
        {
            foreach (Control control in gamePanel.Controls)
            {
                if (control.Bounds.IntersectsWith(panel.Bounds))
                {
                    return true;
                }
            }
            return false;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            remainingTime--;
            lblTime.Text = remainingTime.ToString();
            if (remainingTime == 0)
            {
                gameTimer.Stop();
                MessageBox.Show($"Game over! You scored {scorredPoints} points!");
            }

        }
    }
}
