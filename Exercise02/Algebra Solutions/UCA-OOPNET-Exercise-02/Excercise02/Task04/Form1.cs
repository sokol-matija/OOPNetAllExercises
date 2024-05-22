namespace Task04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SubsribeButtonsToEvents();
        }

        private void SubsribeButtonsToEvents()
        {
            btnRed.MouseDown += btn_MouseDown;
            btnRed.MouseClick += btnRed_MouseClick;

            btnGreen.MouseDown += btn_MouseDown;
            btnGreen.MouseClick += btnGreen_MouseClick;

            btnBlue.MouseDown += btn_MouseDown;
            btnBlue.MouseClick += btnBlue_MouseClick;
        }

        
        void btn_MouseDown(object sender, MouseEventArgs e)
        {
            PrintMouseDown((Button)sender, e.Button);
        }

        private void PrintMouseDown(Button btn, MouseButtons mouseButton)
        {
            string click = "";

            switch (mouseButton)
            {
                case MouseButtons.Left:
                    click = "LEFT";
                    break;
                case MouseButtons.Right:
                    click = "RIGHT";
                    break;
            }

            Print($"{click} click on {btn.Text} button");
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            Print("btnRed_Click()");
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            Print("btnGreen_Click()");
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            Print("btnBlue_Click()");
        }

        private void btnRed_MouseClick(object sender, EventArgs e)
        {
            Print("btnRed_MouseClick()");
        }

        private void btnGreen_MouseClick(object sender, EventArgs e)
        {
            Print("btnGreen_MouseClick()");
        }

        private void btnBlue_MouseClick(object sender, EventArgs e)
        {
            Print("btnBlue_MouseClick()");
        }

        private void Print(string tekst)
        {
            txtInfo.AppendText(tekst);
            txtInfo.AppendText(Environment.NewLine);
        }
    }
}