namespace OOPExercise03Task04
{
    public partial class Form1 : Form
    {
        private const int INIT_WIDTH = 300;
        private const int INIT_HEIGHT = 200;

        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar_Scroll_1(object sender, EventArgs e)
        {
            double imagePercentage = trackBar.Value / 100.0;

            pictureBox.Size = new()
            {
                Width = (int)(INIT_WIDTH * imagePercentage),
                Height = (int)(INIT_HEIGHT * imagePercentage)
            };
            lblPercentage.Text = $"{trackBar.Value}%";
        }
    }
}
