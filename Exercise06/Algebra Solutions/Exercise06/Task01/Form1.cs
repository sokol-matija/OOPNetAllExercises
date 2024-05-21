using System.Security.Cryptography;
using Task01;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public bool dropSuccess;
        public Control controlThatStartedDnD;
        public Color InitColor = Color.Yellow;

        private ButtonStyle initStyle = new() { Foreground = Color.Black, Background = Color.Yellow };
        private ButtonStyle dropStyle = new() { Foreground = Color.White, Background = SystemColors.Highlight };


        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            InitButtons();
        }

        private void InitButtons()
        {
            button1.ApplyStyle(dropStyle);
            button2.ApplyStyle(initStyle);
            button3.ApplyStyle(initStyle);
            button4.ApplyStyle(initStyle);


            // Allow drop and set appropraite Drag listeners
            var buttons = this.Controls.OfType<Button>();
            foreach (var btn in buttons)
            {
                btn.AllowDrop = true;
                btn.MouseDown += button_MouseDown;
                btn.DragEnter += button_DragEnter;
                btn.DragLeave += button_DragLeave;
                btn.DragDrop += button_DragDrop;
            }

        }

        private void button_MouseDown(object sender, MouseEventArgs e)
        {
            startDnD(sender as Button);
        }

        private void startDnD(Button button)
        {
            if (button.BackColor == InitColor) return;
            lbInfo.Text = "Started DnD";

            controlThatStartedDnD = button;
            button.DoDragDrop(dropStyle, DragDropEffects.Move);

            if (dropSuccess)
            {
                button.BackColor = InitColor;
                button.ForeColor = Color.Black;
                dropSuccess = false;
                controlThatStartedDnD = null;
                lbInfo.Text = "";
            }
        }


        private void button_DragDrop(object sender, DragEventArgs e)
        {
            Button btn = sender as Button;

            var style = (ButtonStyle)e.Data.GetData(typeof(ButtonStyle));
            btn.ApplyStyle(style);

            dropSuccess = true;
        }

        private void button_DragEnter(object sender, DragEventArgs e)
        {
            Button btn = sender as Button;
            if (btn == controlThatStartedDnD)
                return;

            e.Effect = DragDropEffects.Move;

            lbInfo.Text = "Drop allowed";
        }

        private void button_DragLeave(object sender, EventArgs e)
        {
            lbInfo.Text = "Drop not allowed";
        }
    }
}