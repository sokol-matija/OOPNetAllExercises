using Task01.Models;

namespace Task01
{
    public partial class Form1 : Form
    {
        private PictureBox selectedPicture;

        public Form1()
        {
            InitializeComponent();
            ShowPictureCountStatus();
        }
        private void ShowPictureCountStatus()
        {
            lblInfo.Text = $"Picture count:{flpContainer.Controls.Count}";
        }

        private void btnAdd_Click(object sender, EventArgs e) => LoadPicture();

        private void LoadPicture()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Pictures|*.bmp;*.jpg;*.jpeg;*.png;|All files|*.*";
            ofd.InitialDirectory = Application.StartupPath;

            //ofd.SafeFileName - ime datoteke i ekstenzija
            //ofd.FileName - abs putanja i datoteka
            if (ofd.ShowDialog() == DialogResult.OK)
                ShowPicture(ofd.SafeFileName, ofd.FileName);
        }

        private void ShowPicture(string fileName, string filePath)
        {
            var title = Utility.GetPictureTitle(fileName, flpContainer);
            var picture = Utility.GetPictureBox(filePath, flpContainer);
            //https://stackoverflow.com/questions/3852410/what-is-the-difference-between-a-click-and-mouseclick
            picture.MouseClick += Picture_MouseClick;

            flpContainer.Controls.Add(Utility.GetPictureContainer(title, picture));
            ShowPictureCountStatus();
        }


        private void Picture_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;

            if (e.Button == MouseButtons.Left)
                SelectPicture(pictureBox);
            else
            {
                SelectPicture(pictureBox);
                ChangePictureTitle(selectedPicture);
            }
        }

        private void ChangePictureTitle(PictureBox pictureBox)
        {
            ChangePictureTitle f = new ChangePictureTitle(pictureBox);
            f.StartPosition = FormStartPosition.CenterScreen;

            if (f.ShowDialog() == DialogResult.OK)
            {
                PictureBox pb = f.GetUpdatedPicture();
                Label selectedPictureTitle = Utility.GetControl<Label>(selectedPicture.Parent);
                selectedPicture.Image = pb.Image;
                // Tag is used to transfer a new image title
                selectedPictureTitle.Text = pb.Tag.ToString().ToUpper();
            }
        }

        private void SelectPicture(PictureBox pictureBox)
        {
            if (selectedPicture == pictureBox) return;

            if (selectedPicture != null)
                Utility.SetPictureBoxMode(selectedPicture, PictureMode.Unmark);

            selectedPicture = pictureBox;
            Utility.SetPictureBoxMode(selectedPicture, PictureMode.Mark);

            btnRemove.Enabled = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var selectedPictureContainer = selectedPicture.Parent;
            flpContainer.Controls.Remove(selectedPictureContainer);

            selectedPicture = null;

            ToolStripItem btn = sender as ToolStripItem;
            btn.Enabled = false;

            ShowPictureCountStatus();
        }

        // Save pictures and open them again to simulate responsive picture boxes
        private void Form1_Resize(object sender, EventArgs e)
        {
            // data.txt will be default file for storing pictures
            var filePath = $"{Application.StartupPath}/data.txt";
            SaveProject(filePath);
            OpenProject(filePath);
        }

        private void menuItemEventhandler(object sender, EventArgs e)
        {
            ToolStripItem item = sender as ToolStripItem;
            if (item.Text == "Save")
                StartSavingProject();
            else
                StartOpeningProject();
        }

        private void StartSavingProject()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text files|*.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                SaveProject(sfd.FileName);
            }
        }

        private void SaveProject(string path)
        {
            try
            {
                File.WriteAllLines(path, GetSaveData());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private List<string> GetSaveData()
        {
            List<string> lines = new List<string>();

            foreach (FlowLayoutPanel flp in flpContainer.Controls)
            {
                Label lbl = Utility.GetControl<Label>(flp);
                PictureBox pb = Utility.GetControl<PictureBox>(flp);

                lines.Add($"{lbl.Text}|{pb.ImageLocation}");
            }

            return lines;
        }

        private void StartOpeningProject()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files|*.txt";
            ofd.InitialDirectory = Application.StartupPath;

            try
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    OpenProject(ofd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OpenProject(string path)
        {
            flpContainer.Controls.Clear();

            var lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                string[] data = line.Split('|');
                var fileName = data[0];
                var filePath = data[1];

                ShowPicture(fileName, filePath);
            }
        }
    }
}
