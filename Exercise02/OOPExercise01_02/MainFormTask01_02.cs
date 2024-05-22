using System.Text;
using Utilities;

namespace OOPExercise01_02
{
    public partial class MainFormTask01_02 : Form
    {
        private Size panelSize = new Size(200, 200);
        private Panel? addedPanel;

        private int panelCounter = 1;
        private int buttonCounter = 1;

        public MainFormTask01_02()
        {
            InitializeComponent();
        }

        private void btnAddPanel_Click(object sender, EventArgs e)
        {
            addedPanel = new FlowLayoutPanel
            {
                Name = $"Panel {panelCounter++}",
                Size = panelSize,
                BackColor = Utility.GetRandomColor(),
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                AutoScroll = true
            };

            pnlContainer.Controls.Add(addedPanel);

            buttonCounter = 1;
        }

        private void btnAddButton_Click(object sender, EventArgs e)
        {
            if(addedPanel == null)
            {
                MessageBox.Show("Please add a panel first.");
                return;
            }

            Button button = new Button
            {
                Name = $"Button {buttonCounter}",
                Text = $"Button {buttonCounter++}",
            };
            button.Click += Button_Click;
            addedPanel.Controls.Add(button);
        }

        private void Button_Click(object? sender, EventArgs e)
        {
            Button? button = sender as Button;
            button?.Parent?.Controls.Remove(button);
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Panel panel in pnlContainer.Controls)
            {
                sb.AppendLine(panel.Name);
                foreach (Button button in panel.Controls)
                {
                    sb.AppendLine($"\t{button.Name}");
                }
            }

            MessageBox.Show(sb.ToString(),"Control Hierarchy");
        }
    }
}
