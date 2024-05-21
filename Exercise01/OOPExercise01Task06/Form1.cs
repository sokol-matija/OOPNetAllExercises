using Utilities;

namespace OOPExercise01Task06
{
    public partial class Form1 : Form
    {
        private Size panelSize = new Size(200, 200);
        private Panel? addedPanel;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddPanel_Click(object sender, EventArgs e)
        {
            Panel panel = new()
            {
                Size = panelSize,
                BackColor = Utility.GetRandomColor(),
                Location = Utility.GetRandomLocationInParent(pnlContainer.Size, panelSize)
            };

            pnlContainer.Controls.Add(panel);
            panel.BringToFront();
            addedPanel = panel;
        }

        private void btnAddButton_Click(object sender, EventArgs e)
        {
            if (addedPanel == null)
            {
                MessageBox.Show("Please add a panel first.");
                return;
            }

            Button button = new Button { Text = "Remove" };
            button.Location = Utility.GetRandomLocationInParent(addedPanel.Size, button.Size);
            button.Click += Button_Click;

            addedPanel.Controls.Add(button);

        }

        private void Button_Click(object? sender, EventArgs e)
        {
            Button? button = sender as Button;
            button?.Parent?.Controls.Remove(button);
        }

        private void btnRemoveAllPanels_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
        }

        private void btnRemoveAllButtons_Click(object sender, EventArgs e)
        {
            foreach (Panel panel in pnlContainer.Controls)
            {
                            panel.Controls.Clear();
            }
        }
    }
}
