using System.Windows.Forms;
using Utilities;

namespace OOPExercise04Task02
{

    public partial class Form1 : Form
    {
        private Size panelSize = new Size(40, 40);
        public Form1()
        {
            InitializeComponent();
        }

        private void panelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem item)
            {
                var n = int.Parse(item.Tag.ToString());

                for (int i = 0; i < n; i++)
                {
                    var panel = new Panel
                    {
                        Size = panelSize,
                        Location = Utility.GetRandomLocationInParent(this.Size, panelSize),
                        BackColor = Utility.GetRandomColor(),
                        ContextMenuStrip = cmsPanel
                    };

                    panel.Click += Panel_Click;
                    Controls.Add(panel);
                }
            }
        }

        private Panel SelectedPanel { get; set; }
        private void Panel_Click(object? sender, EventArgs e)
        {
            if (sender is Panel panel)
            {
                SelectPanel(panel);
            }
        }

        private void SelectPanel(Panel panel)
        {
            if (SelectedPanel != null)
            {
                SelectedPanel.BorderStyle = BorderStyle.None;
            }

            panel.BorderStyle = BorderStyle.FixedSingle;

            SelectedPanel = panel;
        }

        private void removeAllPanelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var panelsToRemove = new List<Panel>();

            foreach (var control in Controls)
            {
                if (control is Panel panel)
                {
                    panelsToRemove.Add(panel);
                }
            }

            foreach (var panel in panelsToRemove)
            {
                Controls.Remove(panel);
                panel.Dispose();
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control? sourceControl = cmsPanel.SourceControl;

            Controls.Remove(sourceControl);
        }

        private void cmsPanel_Opened(object sender, EventArgs e)
        {
            Control? sourceControl = cmsPanel.SourceControl;
            SelectPanel(sourceControl as Panel);
        }

        private void changeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel? panel = cmsPanel.SourceControl as Panel;
            panel.BackColor = Utility.GetRandomColor();
        }
    }
}
