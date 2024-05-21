namespace Task02
{
    public partial class Form1 : Form
    {
        private const int PANELS_COUNT = 200;
        private Size panelSize;

        public Form1()
        {
            InitializeComponent();

            panelSize = new Size
            {
                Width = 20,
                Height = 20
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < PANELS_COUNT; i++)
            {
                pnlContainer.Controls.Add(new Panel
                {
                    Size = panelSize,
                    ContextMenuStrip = contextMenuColor,
                    BorderStyle = BorderStyle.FixedSingle
                });
            }
        }

        private void SelectColor_Click(object sender, EventArgs e)
        {
            var panel = contextMenuColor.SourceControl as Panel;

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                panel.BackColor = colorDialog.Color;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            var panel = contextMenuColor.SourceControl as Panel;
            panel.BackColor = Color.Transparent;
        }
    }
}
