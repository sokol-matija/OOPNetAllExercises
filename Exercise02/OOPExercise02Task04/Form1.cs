namespace OOPExercise02Task04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            Print("btnRed_Click");
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            Print("btnGreen_Click");
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            Print("btnBlue_Click");
        }

        private void btnRed_MouseClick(object sender, MouseEventArgs e)
        {
            Print("btnRed_MouseClick");
        }

        private void btnGreen_MouseClick(object sender, MouseEventArgs e)
        {
            Print("btnGreen_MouseClick");
        }

        private void btnBlue_MouseClick(object sender, MouseEventArgs e)
        {
            Print("btnBlue_MouseClick");
        }

        private void Print(string text)
        {
            txtEvents.AppendText($"{text}{Environment.NewLine}");
        }

        private void btn_MouseDown(object sender, MouseEventArgs e)
        {
            string eventName = "";
            Button? btn = (Button)sender;
            switch (e.Button)
            {
                case MouseButtons.Left:
                    eventName = $"btn_MouseDown {btn.Name}- Left";
                    break;
                case MouseButtons.Right:
                    eventName = $"btn_MouseDown {btn.Name}- Right";
                    break;
                case MouseButtons.Middle:
                    eventName = $"btn_MouseDown {btn.Name}- Middle";
                    break;
            }
            Print($"{eventName} click on {btn?.Text} button");
        }
    }
}
