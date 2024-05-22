namespace OOPExcercise01Task09
{
    public partial class Form1 : Form
    {
        private string formData = "FormData.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                if (!File.Exists(formData))
                {
                    return;
                }

                using (StreamReader reader = new StreamReader(formData))
                {
                    int x = int.Parse(reader.ReadLine());
                    int y = int.Parse(reader.ReadLine());
                    int width = int.Parse(reader.ReadLine());
                    int height = int.Parse(reader.ReadLine());
                    int windowState = int.Parse(reader.ReadLine());

                    Location = new Point(x, y);
                    Width = width;
                    Height = height;
                    WindowState = (FormWindowState)windowState;

                    Rectangle sceenRezolution = Screen.GetBounds(this);

                    if (Size.Width > sceenRezolution.Width || Size.Height > sceenRezolution.Height)
                    {
                        Size = new Size(sceenRezolution.Width, sceenRezolution.Height);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(formData))
                {
                    writer.WriteLine(Location.X);
                    writer.WriteLine(Location.Y);
                    writer.WriteLine(Width);
                    writer.WriteLine(Height);
                    writer.WriteLine((int)WindowState);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
