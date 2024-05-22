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
                        BackColor = Utility.GetRandomColor()
                    };
                    Controls.Add(panel);
                }
            }
        }
    }
}
