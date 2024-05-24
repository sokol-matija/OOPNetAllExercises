namespace OOPExercise05Task02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 200; i++)
            {
                pnlContainer.Controls.Add(new Panel
                {
                    Size = new Size(20, 20),
                    BorderStyle = BorderStyle.FixedSingle,
                    ContextMenuStrip = cmsPanel,
                });
            }
        }

        private void SelectColor_Click(object sender, EventArgs e)
        {
            Panel? panel = cmsPanel.SourceControl as Panel;
            if (panel == null) return;
            
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                panel.BackColor = colorDialog.Color;
            }
        }

        private void ResetColor_Click(object sender, EventArgs e)
        {
            Panel? panel = cmsPanel.SourceControl as Panel;
            if (panel == null) return;

            panel.BackColor = Color.Transparent;
        }

    }
}
