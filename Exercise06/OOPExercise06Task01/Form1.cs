namespace OOPExercise06Task01
{
    public partial class Form1 : Form
    {
        private Color initBtnColor = Color.Yellow;
        private Button? buttonStartedDragDrop;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            StartDragAndDrop(sender as Button);
        }

        private void StartDragAndDrop(Button? button)
        {
            if(button is  null || button.BackColor == initBtnColor)
            {
                return;
            }

            lblInfo.Text = "Drag and drop the button to the other button";
            buttonStartedDragDrop = button;
            button.DoDragDrop(button, DragDropEffects.Move);
        }

        private void Button_DragEnter(object sender, DragEventArgs e)
        {
            Button? yellowButton = sender as Button;
            if (yellowButton == buttonStartedDragDrop)
            {
                return;
            }

            e.Effect = DragDropEffects.Move;
            lblInfo.Text = "Drop allowed!";
        }

        private void Button_DragLeave(object sender, EventArgs e)
        {
            lblInfo.Text = "Drop not allowed!";
        }

        private void Button_DragDrop(object sender, DragEventArgs e)
        {
            Button? yellowButton = sender as Button;

            Button? blueButton = (Button)e.Data.GetData(typeof(Button));

            yellowButton.BackColor = blueButton.BackColor;
            blueButton.BackColor = initBtnColor;
        }
    }
}
