
namespace OOPExercise05Task01Practice01
{
    public partial class Form1 : Form
    {
        private PictureBox? selectedPicture;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowPictureCount();
        }

        private void ShowPictureCount()
        {
            lblStatus.Text = $"Pictures: {pnlContainer.Controls.Count}";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Picture |*.jpeg;*.jpg;*.png|All files|*.*"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ShowPicture(ofd.FileName);
            }
        }

        private void ShowPicture(string filePath)
        {
            PictureBox picture = new PictureBox
            {
                ImageLocation = filePath,
                Size = GetPictureSize(),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            picture.MouseClick += Picture_MouseClick;

            pnlContainer.Controls.Add(picture);
            ShowPictureCount();
        }

        private void Picture_MouseClick(object? sender, MouseEventArgs e)
        {
            PictureBox? picture = sender as PictureBox;
            if (picture is null)
            {
                return;
            }

            if (e.Button == MouseButtons.Left)
            {
                SelectPicture(picture);
            }
            else if (e.Button == MouseButtons.Right)
            {
                UpdatePicture(picture);
            }
        }

        private void RemovePicture(PictureBox picture)
        {
            pnlContainer.Controls.Remove(picture);
            ShowPictureCount();
            btnRemoveImage.Enabled = false;
        }

        private void SelectPicture(PictureBox picture)
        {
            if (selectedPicture is not null)
            {
                selectedPicture.BorderStyle = BorderStyle.None;
            }
            picture.BorderStyle = BorderStyle.Fixed3D;
            selectedPicture = picture;
            btnRemoveImage.Enabled = true;
        }

        private void UpdatePicture(PictureBox picture)
        {
            UpdatePictureForm updatePictureForm = new UpdatePictureForm(picture);
            if (updatePictureForm.ShowDialog() == DialogResult.OK)
            {
                picture.Image = updatePictureForm.GetNewPicture().Image;
            }
        }

        private Size GetPictureSize()
        {
            int width = pnlContainer.Width / 2 - 10;
            int height = (int)(width * (2 / 3.0));
            return new Size(width, height);
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Remove(selectedPicture);
            ShowPictureCount();
            btnRemoveImage.Enabled = false;
        }

        private void OpenProject_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Text files |*.txt|All files|*.*"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                OpenProject(ofd.FileName);
            }
        }

        private void OpenProject(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                pnlContainer.Controls.Clear();
                foreach (var line in lines)
                {
                    ShowPicture(line);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Text files |*.txt|All files|*.*"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                SaveProject(sfd.FileName);
            }
        }

        private void SaveProject(string filePath)
        {
            List<string> lines = new List<string>();
            foreach (var control in pnlContainer.Controls)
            {
                if (control is PictureBox picture)
                {
                    lines.Add(picture.ImageLocation);
                }
            }

            try
            {
                File.WriteAllLines(filePath, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            string filePat = $"{Application.StartupPath}\\pictures.txt";
            SaveProject(filePat);
            OpenProject(filePat);
        }
    }
}
