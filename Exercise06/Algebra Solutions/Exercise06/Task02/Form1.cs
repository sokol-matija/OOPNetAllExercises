namespace Task02
{
    public partial class Form1 : Form
    {
        private Point mouseDownPoint = Point.Empty;
        private Panel selectedPanel = null;
        public Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            InitializeForm();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void InitializeForm()
        {
            ContextMenuStrip = cms;
            AllowDrop = true;

            this.DragDrop += Form1_DragDrop;
            this.DragOver += Form1_DragOver;
        }

        private void addPanelEventhandler(object sender, EventArgs e)
        {
            ToolStripItem item = sender as ToolStripItem;
            var panelNumber = int.Parse(item.Text);
            AddPanels(panelNumber);
        }

        private void AddPanels(int panelNumber)
        {
            for (int i = 0; i < panelNumber; i++)
            {
                this.Controls.Add(GetPanel());
            }
        }

        private Panel GetPanel()
        {
            Panel pnl = new Panel();
            pnl.Size = GetRandomSize(30, 50);
            pnl.BackColor = GetRandomColor();
            pnl.Location = GetRandomLocation(pnl.Size);
            pnl.MouseDown += Pnl_MouseDown;

            return pnl;
        }

        private void Pnl_MouseDown(object sender, MouseEventArgs e)
        {
            Panel pnl = sender as Panel;
            SelectPanel(pnl);
            mouseDownPoint = pnl.PointToScreen(e.Location);

            pnl.DoDragDrop("nonsense", DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void SelectPanel(Panel pnl)
        {
            var allPanels = this.Controls.OfType<Panel>();
            foreach (var p in allPanels)
            {
                p.BorderStyle = BorderStyle.None;
            }

            selectedPanel = pnl;
            selectedPanel.BorderStyle = BorderStyle.FixedSingle;
            selectedPanel.BringToFront();
        }

        private Point GetRandomLocation(Size pnlSize)
        {
            var maxX = this.ClientSize.Width - pnlSize.Width;
            var maxY = this.ClientSize.Height - pnlSize.Height;

            var x = rnd.Next(maxX);
            var y = rnd.Next(maxY);

            return new Point(x, y);
        }

        private Color GetRandomColor()
        {
            var r = rnd.Next(256);
            var g = rnd.Next(256);
            var b = rnd.Next(256);
            return Color.FromArgb(r, g, b);
        }

        private Size GetRandomSize(int min, int max)
        {
            var sizeWH = rnd.Next(min, max);
            return new Size(sizeWH, sizeWH);
        }

        private void Form1_DragOver(object sender, DragEventArgs e)
        {
            
            if (e.KeyState == 1)
                e.Effect = DragDropEffects.Move;
            else if (e.KeyState == 2)   
                e.Effect = DragDropEffects.Copy;

        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
           
            int deltaX = mouseDownPoint.X - e.X;
            int deltaY = mouseDownPoint.Y - e.Y;

            int x = selectedPanel.Location.X - deltaX;
            int y = selectedPanel.Location.Y - deltaY;

            Point newLocation = new Point(x, y);

            if (e.Effect == DragDropEffects.Move)
                selectedPanel.Location = newLocation;
            else
                CopyPanel(newLocation);
        }

        private void CopyPanel(Point copyPanelLocation)
        {
            Panel pnl = new Panel();
            pnl.Size = selectedPanel.Size;
            pnl.BackColor = selectedPanel.BackColor;
            pnl.Location = copyPanelLocation;
            pnl.MouseDown += Pnl_MouseDown;

            this.Controls.Add(pnl);
            SelectPanel(pnl);
        }

        private void removeAllPanelsToolStripMenuItem_Click(object sender, EventArgs e) => Controls.Clear();
    }
}