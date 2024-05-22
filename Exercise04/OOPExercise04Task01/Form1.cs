namespace OOPExercise04Task01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image = toolStripButton1.Image;
            pictureBox1.Image = ((ToolStripButton)sender).Image;
        }

        private void Form1_Down(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch
                    (e.KeyCode)
                {
                    case Keys.F:
                        pictureBox1.Image = toolStripButton1.Image;
                        break;
                    case Keys.M:
                        pictureBox1.Image = toolStripButton2.Image;
                        break;
                    case Keys.T:
                        pictureBox1.Image = toolStripButton3.Image;
                        break;
                }
            }
        }
    }
}
