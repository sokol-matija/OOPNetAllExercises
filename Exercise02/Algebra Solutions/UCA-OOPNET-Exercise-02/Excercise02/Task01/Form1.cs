using System.Text;
using Utilities;
using static System.Net.WebRequestMethods;

namespace Task01
{
    public partial class Form1 : Form
    {
        FlowLayoutPanel lastAddedPanel;
        short btnIndex;
        short panelIndex;
        int flpWh = 200;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddPanel_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel.Controls.Count < 6)
                AddFlowLayoutPanel();
        }

        private void btnAddButton_Click(object sender, EventArgs e)
        {
            if (lastAddedPanel != null)
            {
                AddButton();
                btnIndex++;
            }
        }

        private void AddFlowLayoutPanel()
        {
            btnIndex = 1;

            lastAddedPanel = new FlowLayoutPanel();
            lastAddedPanel.Size = new Size(flpWh, flpWh);
            lastAddedPanel.Name = "FLPanela " + ++panelIndex;
            lastAddedPanel.BackColor = Utility.GetRandomColor();

            /* Buttons that will be added shoudld flow in the direction from top to bottom.*/
            lastAddedPanel.FlowDirection = FlowDirection.TopDown;
            lastAddedPanel.WrapContents = false;
            lastAddedPanel.AutoScroll = true;

            flowLayoutPanel.Controls.Add(lastAddedPanel);
        }

        private void AddButton()
        {
            Button btn = new Button();
            btn.Text = String.Format("Button number {0}", btnIndex);
            btn.Name = "Button " + btnIndex;
            btn.Click += btn_Click;
            lastAddedPanel.Controls.Add(btn);
        }

        void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button) sender;
            FlowLayoutPanel panel = (FlowLayoutPanel) btn.Parent;
            panel.Controls.Remove(btn);
        }

        private void btnControlHierarchy_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            if (lastAddedPanel != null)
            {
                foreach (FlowLayoutPanel panel in flowLayoutPanel.Controls)
                {
                    sb.Append(panel.Name);
                    sb.Append(Environment.NewLine);

                    foreach (Button btn in panel.Controls)
                    {
                        sb.Append("\t");
                        sb.Append(btn.Name);
                        sb.Append(Environment.NewLine);
                    }
                }
                MessageBox.Show(sb.ToString());
            }
        }

    }
}