using Utilities;

namespace Task06
{
    public partial class MainForm : Form
    {
        private Size panelSize = new Size(200, 200);
        private Panel? addedPanel;

        public MainForm()
        {
            InitializeComponent();
        }

        private void AddPanel_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel
            {
                Size = panelSize,
                Location = Utility.GetRandomLocationInParent(pnlContainer.Size, panelSize),
                BackColor = Utility.GetRandomColor()
            };

            pnlContainer.Controls.Add(panel);
            panel.BringToFront();
            addedPanel = panel;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (addedPanel is null)
            {
                return;
            }

            Button button = new Button { Text = "Remove" };
            button.Location = Utility.GetRandomLocationInParent(addedPanel.Size, button.Size);
            button.Click += Button_Click;

            addedPanel.Controls.Add(button);
            button.BringToFront();
        }

        private void Button_Click(object? sender, EventArgs e)
        {
            Button? button = sender as Button;
            button?.Parent.Controls.Remove(button);
        }

        private void RemovePanels_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
        }

        private void RemoveButtons_Click(object sender, EventArgs e)
        {
            foreach (Control control in pnlContainer.Controls)
            {
                if (control is Panel)
                {
                    control.Controls.Clear();
                }
            }
        }
    }
}